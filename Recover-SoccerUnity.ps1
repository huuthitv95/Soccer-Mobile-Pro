#requires -Version 5.1
<#
.SYNOPSIS
Recovers Soccer-Mobile-Pro into a Unity 2020.3.49f1 asset/type project.
.DESCRIPTION
No gameplay restoration is claimed. No installed tool configuration is modified.
Run -PreflightOnly first. -SelfTest exercises helpers against synthetic inputs only.
Existing project/recovery outputs are never overwritten. Failed runs are retained.
#>
[CmdletBinding()]
param(
    [switch]$PreflightOnly,
    [switch]$SelfTest,
    [ValidateRange(60, 86400)][int]$StageTimeoutSeconds = 7200,
    # Explicitly reviewed full type names ONLY. Interop-marked types are still rejected.
    [string[]]$ConfirmedNonInteropLayoutTypes = @()
)
Set-StrictMode -Version Latest
$ErrorActionPreference = 'Stop'
$Source = 'C:\Users\ZGAMESVN\Downloads\Soccer-Mobile-Pro'
$Apk = Join-Path $Source 'Soccer-Mobile-Pro.apk'
$Project = 'C:\Users\ZGAMESVN\Downloads\Soccer-Unity-Project'
$Recovery = 'C:\Users\ZGAMESVN\Downloads\Soccer-Unity-Recovery'
$Ripper = 'C:\Tools\AssetRipper\AssetRipper.GUI.Premium.exe'
$Dumper = 'C:\Tools\Il2CppDumper\Il2CppDumper.exe'
$Editor = 'C:\Program Files\Unity\Hub\Editor\2020.3.49f1\Editor\Unity.exe'
$TargetVersion = '2020.3.49f1'
$RipperVersion = '2.0.0+1ac666f47d8e9dedf96afb0b914c70d7656151ea'
$Utf8 = New-Object System.Text.UTF8Encoding($false)
$script:OwnedProcesses = New-Object System.Collections.Generic.List[System.Diagnostics.Process]
$script:Stage = 'Preflight'
$report = $null
$reports = $null

function Write-Utf8([string]$Path, [string]$Content) {
    [IO.File]::WriteAllText($Path, $Content, $Utf8)
}
function Write-Json([string]$Path, $Value) {
    Write-Utf8 $Path (ConvertTo-Json -InputObject $Value -Depth 30)
}
function Set-RecoveryStage([string]$Name) {
    $script:Stage=$Name
    $report.stage=$Name
    $report.stages+=@([ordered]@{name=$Name;startedUtc=[DateTime]::UtcNow.ToString('o')})
    Write-Json (Join-Path $reports 'recovery.json') $report
}
function Assert-Empty([string]$Path) {
    if (Test-Path -LiteralPath $Path) {
        $item = Get-Item -LiteralPath $Path -Force
        if (!$item.PSIsContainer -or ($item.Attributes -band [IO.FileAttributes]::ReparsePoint) -or
            @(Get-ChildItem -LiteralPath $Path -Force).Count -ne 0) {
            throw "Refusing to overwrite or traverse existing output: $Path"
        }
    }
}
function Assert-Contained([string]$Root, [string]$Path) {
    $prefix = [IO.Path]::GetFullPath($Root).TrimEnd('\') + '\'
    $full = [IO.Path]::GetFullPath($Path)
    if (!$full.StartsWith($prefix, [StringComparison]::OrdinalIgnoreCase)) {
        throw "Path escapes output root: $Path"
    }
    # Also reject junction/symlink ancestors, including the root itself.
    $cursor = $full
    while ($cursor) {
        if (Test-Path -LiteralPath $cursor) {
            if ((Get-Item -LiteralPath $cursor -Force).Attributes -band [IO.FileAttributes]::ReparsePoint) {
                throw "Reparse point is not allowed in output path: $cursor"
            }
        }
        $cursor = [IO.Path]::GetDirectoryName($cursor)
    }
    return $full
}
function Quote-Argument([string]$Value) {
    # Windows CommandLineToArgvW-compatible quoting; never invoke a shell.
    return '"' + [regex]::Replace([regex]::Replace($Value, '(\\*)"', '$1$1\"'), '(\\+)$', '$1$1') + '"'
}
function Start-Owned([string]$Exe, [string[]]$Arguments, [string]$WorkingDirectory, [string]$LogBase) {
    Write-Json ($LogBase+'.command.json') @{executable=$Exe;arguments=$Arguments;workingDirectory=$WorkingDirectory}
    $argLine = ($Arguments | ForEach-Object { Quote-Argument $_ }) -join ' '
    $p = Start-Process -FilePath $Exe -ArgumentList $argLine -WorkingDirectory $WorkingDirectory `
        -WindowStyle Hidden -PassThru -RedirectStandardOutput ($LogBase + '.stdout.log') `
        -RedirectStandardError ($LogBase + '.stderr.log')
    # Retain the process handle: Windows PowerShell otherwise loses ExitCode after exit.
    $null = $p.Handle
    $script:OwnedProcesses.Add($p)
    return $p
}
function Wait-Owned([Diagnostics.Process]$Process, [int]$Timeout, [string]$Description) {
    $timer = [Diagnostics.Stopwatch]::StartNew()
    while (!$Process.HasExited) {
        if ($timer.Elapsed.TotalSeconds -ge $Timeout) {
            $Process.Kill()
            $Process.WaitForExit()
            throw "$Description timed out after $Timeout seconds. Logs are retained."
        }
        Start-Sleep -Milliseconds 250
        $Process.Refresh()
    }
    $Process.WaitForExit()
    if ($Process.ExitCode -ne 0) { throw "$Description failed with exit code $($Process.ExitCode). See logs." }
}
function Invoke-Owned([string]$Exe, [string[]]$Arguments, [string]$WorkingDirectory, [string]$LogBase, [int]$Timeout = $StageTimeoutSeconds) {
    $p = Start-Owned $Exe $Arguments $WorkingDirectory $LogBase
    Wait-Owned $p $Timeout $LogBase
}
function Get-Sdk {
    $dotnet = (Get-Command dotnet.exe -ErrorAction Stop).Source
    $lines = @(& $dotnet --list-sdks)
    if ($LASTEXITCODE -ne 0) { throw 'Cannot enumerate .NET SDKs.' }
    $available = @($lines | ForEach-Object {
        if ($_ -match '^(\d+\.\d+\.\d+) \[(.+)\]$') {
            [pscustomobject]@{ Version = [version]$Matches[1]; Path = Join-Path $Matches[2] $Matches[1] }
        }
    } | Where-Object { $_.Version.Major -ge 8 } | Sort-Object Version -Descending)
    if (!$available.Count) { throw 'The repair helper requires an installed .NET SDK 8 or newer (no automatic downloads).' }
    return [pscustomobject]@{ Exe = $dotnet; Version = $available[0].Version.ToString(); Path = $available[0].Path; Tfm = "net$($available[0].Version.Major).0" }
}
function Read-Il2CppInputInfo([string]$Binary, [string]$Metadata) {
    $stream=[IO.File]::OpenRead($Metadata)
    try {$reader=New-Object IO.BinaryReader($stream); $magic=$reader.ReadUInt32(); $metadataVersion=$reader.ReadInt32()} finally {$stream.Dispose()}
    # 0xFAB11BAF is a negative Int32 literal in Windows PowerShell 5.1.
    if($magic -ne 4205910959L) {throw 'Metadata magic is unsupported or protected; automatic recovery stopped.'}
    $elf=[IO.File]::OpenRead($Binary)
    try {$h=New-Object byte[] 20; $count=$elf.Read($h,0,20)} finally {$elf.Dispose()}
    if($count -ne 20 -or $h[0] -ne 127 -or $h[1] -ne 69 -or $h[2] -ne 76 -or $h[3] -ne 70 -or $h[4] -ne 2 -or $h[5] -ne 1 -or [BitConverter]::ToUInt16($h,18) -ne 183) {throw 'Selected binary is not a little-endian ELF64 AArch64 image.'}
    return $metadataVersion
}

# Embedded syntax-aware helper: references Roslyn from the installed .NET SDK.
$RepairSource = @'
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

sealed class Repair : CSharpSyntaxRewriter
{
    readonly HashSet<string> allow;
    static Dictionary<string,string> aliases = new();
    public readonly List<object> Changes = new();
    public readonly List<object> Warnings = new();
    public string FileName = "";
    public Repair(string[] allowTypes) { allow = new(allowTypes, StringComparer.Ordinal); }
    static string Name(AttributeSyntax a) {
        string name=a.Name.ToString();
        if(aliases.TryGetValue(name,out string? target)) name=target;
        return name.Split('.').Last().Replace("Attribute", "");
    }
    static string FullName(SyntaxNode n) => string.Join(".", n.AncestorsAndSelf().Reverse().Select(x => x switch {
        BaseNamespaceDeclarationSyntax ns => ns.Name.ToString(),
        TypeDeclarationSyntax t => t.Identifier.ValueText + (t.TypeParameterList == null ? "" : "`" + t.TypeParameterList.Parameters.Count),
        _ => ""
    }).Where(x => x.Length > 0));
    void Changed(SyntaxNode n, string reason) => Changes.Add(new { file = FileName, line = n.GetLocation().GetLineSpan().StartLinePosition.Line + 1, reason });
    static bool Has(SyntaxTokenList m, SyntaxKind k) => m.Any(k);
    static bool Empty(BlockSyntax? b, ArrowExpressionClauseSyntax? e) => e == null && (b == null || b.Statements.Count == 0);
    static string Default(TypeSyntax t) => "default(" + t.WithoutTrivia() + ")";
    static BlockSyntax Body(TypeSyntax type, SeparatedSyntaxList<ParameterSyntax> parameters, bool async = false)
    {
        string code = "";
        foreach (var p in parameters.Where(p => Has(p.Modifiers, SyntaxKind.OutKeyword)))
            code += p.Identifier.Text + " = " + (p.Type == null ? "default" : Default(p.Type)) + ";";
        // Ref returns require a real storage location. Task-like/custom async results
        // also cannot be safely fabricated. A throwing stub is valid and explicit.
        if (type is RefTypeSyntax || async)
            code += "throw new global::System.NotImplementedException(\"Recovered method has no implementation.\");";
        else if (type is not PredefinedTypeSyntax p || !p.Keyword.IsKind(SyntaxKind.VoidKeyword))
            code += "return " + Default(type) + ";";
        return (BlockSyntax)SyntaxFactory.ParseStatement("{" + code + "}");
    }
    public override SyntaxNode? VisitMethodDeclaration(MethodDeclarationSyntax n)
    {
        if (Empty(n.Body, n.ExpressionBody) && !Has(n.Modifiers, SyntaxKind.AbstractKeyword) &&
            !Has(n.Modifiers, SyntaxKind.ExternKeyword) && !Has(n.Modifiers, SyntaxKind.PartialKeyword) &&
            n.Parent is not InterfaceDeclarationSyntax)
        {
            Changed(n, "Fill absent/empty method body; preserve signature and out parameters");
            n = n.WithBody(Body(n.ReturnType, n.ParameterList.Parameters, Has(n.Modifiers, SyntaxKind.AsyncKeyword)))
                .WithSemicolonToken(default);
        }
        return base.VisitMethodDeclaration(n);
    }
    public override SyntaxNode? VisitOperatorDeclaration(OperatorDeclarationSyntax n)
    {
        if (Empty(n.Body, n.ExpressionBody) && !Has(n.Modifiers, SyntaxKind.ExternKeyword)) {
            Changed(n, "Fill operator stub"); n = n.WithBody(Body(n.ReturnType,n.ParameterList.Parameters)).WithSemicolonToken(default);
        }
        return base.VisitOperatorDeclaration(n);
    }
    public override SyntaxNode? VisitConversionOperatorDeclaration(ConversionOperatorDeclarationSyntax n)
    {
        if (Empty(n.Body, n.ExpressionBody) && !Has(n.Modifiers, SyntaxKind.ExternKeyword)) {
            Changed(n, "Fill conversion stub"); n = n.WithBody(Body(n.Type,n.ParameterList.Parameters)).WithSemicolonToken(default);
        }
        return base.VisitConversionOperatorDeclaration(n);
    }
    public override SyntaxNode? VisitAccessorDeclaration(AccessorDeclarationSyntax n)
    {
        // Semicolon accessors are auto-properties or abstract/interface contracts.
        if (n.IsKind(SyntaxKind.GetAccessorDeclaration) && n.Body != null && n.Body.Statements.Count == 0) {
            TypeSyntax? type = n.Parent?.Parent switch { PropertyDeclarationSyntax p => p.Type, IndexerDeclarationSyntax i => i.Type, _ => null };
            if(type != null) { Changed(n,"Fill empty getter"); n=n.WithBody(Body(type,default)); }
        }
        return base.VisitAccessorDeclaration(n);
    }
    public override SyntaxNode? VisitConstructorDeclaration(ConstructorDeclarationSyntax n)
    {
        if(n.Body==null && n.ExpressionBody==null && !Has(n.Modifiers,SyntaxKind.ExternKeyword)) {
            Changed(n,"Supply explicit missing-constructor stub");
            n=n.WithBody((BlockSyntax)SyntaxFactory.ParseStatement("{throw new global::System.NotImplementedException(\"Recovered constructor has no implementation.\");}"))
                .WithSemicolonToken(default);
        }
        return base.VisitConstructorDeclaration(n);
    }
    public override SyntaxNode? VisitAttributeList(AttributeListSyntax n)
    {
        var kept = new List<AttributeSyntax>();
        foreach(var a in n.Attributes) {
            string name = Name(a);
            if(name is "InitializeOnLoad" or "InitializeOnLoadMethod" or "RuntimeInitializeOnLoadMethod" or "DidReloadScripts" or "ExecuteAlways" or "ExecuteInEditMode") {
                Changed(a,"Disable recovered automatic execution hook: " + name); continue;
            }
            if(name is "StructLayout" or "FieldOffset") {
                var owner=a.Ancestors().OfType<TypeDeclarationSyntax>().FirstOrDefault();
                bool explicitLayout = name == "FieldOffset" || a.ToString().Contains("Explicit");
                bool interop = owner != null && owner.DescendantNodes().OfType<AttributeSyntax>().Any(x => Name(x) is "DllImport" or "MarshalAs" or "UnmanagedFunctionPointer" or "ComImport");
                if(explicitLayout && owner != null && allow.Contains(FullName(owner)) && !interop) {
                    Changed(a,"Remove reviewed non-interop explicit layout: " + FullName(owner)); continue;
                }
                if(explicitLayout) Warnings.Add(new { file=FileName, type=owner == null ? "" : FullName(owner), reason="Layout preserved: requires non-interop review (including external/native uses)." });
            }
            kept.Add(a);
        }
        return kept.Count == 0 ? null : n.WithAttributes(SyntaxFactory.SeparatedList(kept));
    }
    public static int Main(string[] args)
    {
        string root=args[0], report=args[1];
        var repair=new Repair(JsonSerializer.Deserialize<string[]>(File.ReadAllText(args[2]))!);
        var errors=new List<object>();
        var types=new List<object>();
        foreach(string file in Directory.GetFiles(root,"*.cs",SearchOption.AllDirectories)) {
            repair.FileName=file;
            string original=File.ReadAllText(file);
            var tree=CSharpSyntaxTree.ParseText(original,new CSharpParseOptions(LanguageVersion.CSharp9),file);
            aliases=tree.GetRoot().DescendantNodes().OfType<UsingDirectiveSyntax>().Where(u=>u.Alias!=null && u.Name!=null)
                .GroupBy(u=>u.Alias!.Name.Identifier.ValueText).ToDictionary(g=>g.Key,g=>g.First().Name!.ToString());
            var diagnostics=tree.GetDiagnostics().Where(d=>d.Severity==DiagnosticSeverity.Error).ToArray();
            // Broken syntax is not safe to rewrite. Let the report identify it.
            if(diagnostics.Length>0) { errors.Add(new {file, diagnostics=diagnostics.Select(d=>d.ToString()).ToArray()}); continue; }
            foreach(var type in tree.GetRoot().DescendantNodes().OfType<BaseTypeDeclarationSyntax>())
                types.Add(new { file, name=type.Identifier.ValueText, fullName=type is TypeDeclarationSyntax ? FullName(type) : type.Identifier.ValueText,
                    methods=type.ChildNodes().OfType<MethodDeclarationSyntax>().Select(m=>m.Identifier.ValueText).Distinct().ToArray() });
            int before=repair.Changes.Count;
            var rewritten=repair.Visit(tree.GetRoot())!;
            if(repair.Changes.Count!=before) {
                string output=rewritten.NormalizeWhitespace().ToFullString();
                var check=CSharpSyntaxTree.ParseText(output,new CSharpParseOptions(LanguageVersion.CSharp9));
                if(check.GetDiagnostics().Any(d=>d.Severity==DiagnosticSeverity.Error)) throw new Exception("Repair generated invalid syntax: "+file);
                File.WriteAllText(file,output,new System.Text.UTF8Encoding(false));
            }
        }
        File.WriteAllText(report,JsonSerializer.Serialize(new { changes=repair.Changes, warnings=repair.Warnings, syntaxErrors=errors, types },new JsonSerializerOptions { WriteIndented=true }));
        return errors.Count==0 ? 0 : 2;
    }
}
'@

function Build-RepairHelper([string]$Directory, $Sdk) {
    [void][IO.Directory]::CreateDirectory($Directory)
    Write-Utf8 (Join-Path $Directory 'Repair.cs') $RepairSource
    Write-Json (Join-Path $Directory 'global.json') @{sdk=@{version=$Sdk.Version;rollForward='disable'}}
    Write-Utf8 (Join-Path $Directory 'NuGet.Config') '<configuration><packageSources><clear /></packageSources></configuration>'
    Write-Utf8 (Join-Path $Directory 'Repair.csproj') @"
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup><OutputType>Exe</OutputType><TargetFramework>$($Sdk.Tfm)</TargetFramework><Nullable>enable</Nullable><EnableDefaultCompileItems>false</EnableDefaultCompileItems><NuGetAudit>false</NuGetAudit></PropertyGroup>
  <ItemGroup><Compile Include="Repair.cs" />
    <Reference Include="Microsoft.CodeAnalysis"><HintPath>`$(MSBuildSDKsPath)\..\Roslyn\bincore\Microsoft.CodeAnalysis.dll</HintPath></Reference>
    <Reference Include="Microsoft.CodeAnalysis.CSharp"><HintPath>`$(MSBuildSDKsPath)\..\Roslyn\bincore\Microsoft.CodeAnalysis.CSharp.dll</HintPath></Reference>
  </ItemGroup>
</Project>
"@
    Invoke-Owned $Sdk.Exe @('build','Repair.csproj','-c','Release','-o','bin','--nologo') $Directory (Join-Path $Directory 'build') 180
    return Join-Path $Directory 'bin\Repair.dll'
}

# Compiles only in a separate editor-only assembly. Scenes are opened additively and
# closed without saving; recovered edit-mode execution hooks are removed first.
$ValidatorSource = @'
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
public static class SoccerRecoveryValidation
{
    [Serializable] public class Item { public string path; public string kind; public int missingScripts; public string error; }
    [Serializable] public class Report { public string unityVersion; public bool compiled; public int scriptCount; public List<Item> items = new List<Item>(); public List<string> editorErrors = new List<string>(); }
    public static void Run()
    {
        var report = new Report { unityVersion = Application.unityVersion, compiled = !EditorUtility.scriptCompilationFailed };
        string root = Environment.GetEnvironmentVariable("SOCCER_RECOVERY_REPORTS");
        if (string.IsNullOrEmpty(root)) throw new Exception("Missing report directory.");
        Application.LogCallback capture=(message,stack,type)=>{
            if((type==LogType.Error || type==LogType.Exception || type==LogType.Assert) && report.editorErrors.Count<500)
                report.editorErrors.Add(message+"\n"+stack);
        };
        Application.logMessageReceived+=capture;
        try {
            report.scriptCount = AssetDatabase.FindAssets("t:MonoScript",new[]{"Assets"}).Length;
            foreach(string guid in AssetDatabase.FindAssets("t:Scene",new[]{"Assets"})) {
                string path=AssetDatabase.GUIDToAssetPath(guid);
                var item=new Item { path=path,kind="scene" }; report.items.Add(item);
                UnityEngine.SceneManagement.Scene scene=default;
                try {
                    scene=EditorSceneManager.OpenScene(path,OpenSceneMode.Additive);
                    foreach(var go in scene.GetRootGameObjects())
                        foreach(var t in go.GetComponentsInChildren<Transform>(true))
                            item.missingScripts+=GameObjectUtility.GetMonoBehavioursWithMissingScriptCount(t.gameObject);
                } catch(Exception e) { item.error=e.ToString(); }
                finally { if(scene.IsValid()) EditorSceneManager.CloseScene(scene,true); }
            }
            foreach(string guid in AssetDatabase.FindAssets("t:Prefab",new[]{"Assets"})) {
                string path=AssetDatabase.GUIDToAssetPath(guid); var item=new Item {path=path,kind="prefab"}; report.items.Add(item);
                try { var go=AssetDatabase.LoadAssetAtPath<GameObject>(path); if(go==null) throw new Exception("Prefab could not be loaded.");
                    foreach(var t in go.GetComponentsInChildren<Transform>(true)) item.missingScripts+=GameObjectUtility.GetMonoBehavioursWithMissingScriptCount(t.gameObject);
                } catch(Exception e) { item.error=e.ToString(); }
            }
            foreach(string guid in AssetDatabase.FindAssets("t:Shader",new[]{"Assets"})) {
                string path=AssetDatabase.GUIDToAssetPath(guid); var shader=AssetDatabase.LoadAssetAtPath<Shader>(path);
                report.items.Add(new Item {path=path,kind="shader",error=shader==null ? "Shader failed to load" : ShaderUtil.ShaderHasError(shader) ? "Shader compiler error; see Unity log" : null});
            }
            foreach(string kind in new[]{"Texture2D","AudioClip","Material","Mesh"})
                foreach(string guid in AssetDatabase.FindAssets("t:"+kind,new[]{"Assets"}).Take(10)) {
                    string path=AssetDatabase.GUIDToAssetPath(guid);
                    report.items.Add(new Item {path=path,kind=kind,error=AssetDatabase.LoadMainAssetAtPath(path)==null ? "Asset failed to load" : null});
                }
            File.WriteAllText(Path.Combine(root,"unity-validation.json"),JsonUtility.ToJson(report,true));
            EditorApplication.Exit(report.compiled && report.scriptCount>0 ? 0 : 3);
        } catch(Exception e) {
            File.WriteAllText(Path.Combine(root,"unity-validation-fatal.txt"),e.ToString()); EditorApplication.Exit(4);
        } finally { Application.logMessageReceived-=capture; }
    }
}
'@

function Get-Preflight {
    foreach ($path in @($Apk,$Ripper,$Dumper,$Editor)) {
        if (!(Test-Path -LiteralPath $path -PathType Leaf)) { throw "Required file missing: $path" }
    }
    foreach ($path in @($Project,$Recovery)) {
        [void](Assert-Contained 'C:\Users\ZGAMESVN\Downloads' $path)
        Assert-Empty $path
    }
    $sdk = Get-Sdk
    $versionText = (& $Ripper --version | Out-String).Trim()
    if ($LASTEXITCODE -ne 0 -or !$versionText.Contains($RipperVersion)) {
        throw "Unsupported AssetRipper API build. Expected $RipperVersion; found $versionText"
    }
    if (!(Get-Item -LiteralPath $Editor).VersionInfo.FileVersion.StartsWith('2020.3.49.')) {
        throw 'Unity editor file version does not match 2020.3.49.'
    }
    return [pscustomobject]@{ sdk=$sdk; apk=$Apk; apkSha256=(Get-FileHash -LiteralPath $Apk -Algorithm SHA256).Hash;
        assetRipper=$versionText; assetRipperSha256=(Get-FileHash -LiteralPath $Ripper).Hash;
        dumperSha256=(Get-FileHash -LiteralPath $Dumper).Hash; unity=$Editor }
}

function Invoke-SelfTest {
    $testRoot = Join-Path ([IO.Path]::GetTempPath()) ('SoccerRecovery-Test-' + [guid]::NewGuid().ToString('N'))
    [void][IO.Directory]::CreateDirectory($testRoot)
    $elfPath=Join-Path $testRoot 'synthetic.so'; $metaPath=Join-Path $testRoot 'synthetic.dat'
    $header=New-Object byte[] 20
    $header[0]=127; $header[1]=69; $header[2]=76; $header[3]=70; $header[4]=2; $header[5]=1; $header[18]=183
    [IO.File]::WriteAllBytes($elfPath,$header)
    [IO.File]::WriteAllBytes($metaPath,([BitConverter]::GetBytes([uint32]4205910959L)+[BitConverter]::GetBytes([int]29)))
    if((Read-Il2CppInputInfo $elfPath $metaPath) -ne 29){throw 'IL2CPP metadata/architecture fixture failed.'}
    $header[18]=62; [IO.File]::WriteAllBytes($elfPath,$header)
    $wrongArch=$false
    try {[void](Read-Il2CppInputInfo $elfPath $metaPath)} catch {$wrongArch=$_.Exception.Message -like '*AArch64*'}
    if(!$wrongArch){throw 'Wrong architecture was accepted.'}
    $header[18]=183; [IO.File]::WriteAllBytes($elfPath,$header)
    [IO.File]::WriteAllBytes($metaPath,(New-Object byte[] 8))
    $wrongMagic=$false
    try {[void](Read-Il2CppInputInfo $elfPath $metaPath)} catch {$wrongMagic=$_.Exception.Message -like '*Metadata magic*'}
    if(!$wrongMagic){throw 'Invalid metadata magic was accepted.'}
    $sdk = Get-Sdk
    $helper = Build-RepairHelper (Join-Path $testRoot 'helper with spaces') $sdk
    $fixture = Join-Path $testRoot 'fixture with spaces'
    [void][IO.Directory]::CreateDirectory($fixture)
    Write-Utf8 (Join-Path $fixture 'Example.cs') @'
using System; using System.Runtime.InteropServices; using System.Collections.Generic; using System.Threading.Tasks;
using Start = InitializeOnLoadAttribute;
class InitializeOnLoadAttribute:Attribute {}
[Start] class Aliased {}
[InitializeOnLoad] class Example {
  public Example(int number);
  public int Absent();
  public int Number(out int value) { }
  public ref int Reference() { }
  public async Task<int> Async() { }
  public int Value { get { } set {} }
  public int Auto { get; set; }
  public IEnumerable<int> ExistingIterator() { yield return 42; }
  public IEnumerable<int> EmptyIterator() { }
  public static Example operator +(Example a, Example b) { }
  public static explicit operator int(Example a) { }
}
abstract class Abstract { public abstract int Keep(); }
interface Contract { int Keep(); }
[StructLayout(LayoutKind.Explicit)] struct Reviewed { [FieldOffset(0)] public object Ref; }
[StructLayout(LayoutKind.Explicit)] struct Native { [FieldOffset(0)] public int N; }
[StructLayout(LayoutKind.Explicit)] struct Interop { [FieldOffset(0), MarshalAs(UnmanagedType.I4)] public int N; }
'@
    $allow = Join-Path $testRoot 'allow.json'
    Write-Json $allow @('Reviewed','Interop')
    $report = Join-Path $testRoot 'repairs.json'
    Invoke-Owned $sdk.Exe @($helper,$fixture,$report,$allow) $testRoot (Join-Path $testRoot 'repair') 60
    $text = Get-Content -LiteralPath (Join-Path $fixture 'Example.cs') -Raw
    if ($text -match '\[(InitializeOnLoad|Start)\]' -or $text -notmatch 'yield return 42' -or $text -notmatch 'FieldOffset' -or $text -notmatch 'NotImplementedException') { throw 'Repair assertions failed.' }
    $results = Get-Content -LiteralPath $report -Raw | ConvertFrom-Json
    if (@($results.changes | Where-Object reason -Like '*reviewed*').Count -ne 2) { throw 'Layout allowlist assertions failed.' }
    Write-Utf8 (Join-Path $fixture 'Fixture.csproj') "<Project Sdk=`"Microsoft.NET.Sdk`"><PropertyGroup><TargetFramework>$($sdk.Tfm)</TargetFramework><NuGetAudit>false</NuGetAudit></PropertyGroup></Project>"
    Copy-Item -LiteralPath (Join-Path (Split-Path (Split-Path $helper)) 'NuGet.Config') -Destination $fixture
    Copy-Item -LiteralPath (Join-Path (Split-Path (Split-Path $helper)) 'global.json') -Destination $fixture
    Invoke-Owned $sdk.Exe @('build','Fixture.csproj','--nologo') $fixture (Join-Path $testRoot 'fixture-compile') 180
    $broken=Join-Path $testRoot 'broken-syntax'
    [void][IO.Directory]::CreateDirectory($broken)
    $brokenFile=Join-Path $broken 'Broken.cs'
    Write-Utf8 $brokenFile 'class Broken { public ??? BrokenMethod(';
    $hashBefore=(Get-FileHash -LiteralPath $brokenFile).Hash
    $syntaxRejected=$false
    try {Invoke-Owned $sdk.Exe @($helper,$broken,(Join-Path $testRoot 'syntax-errors.json'),$allow) $testRoot (Join-Path $testRoot 'syntax-rejection') 60} catch {$syntaxRejected=$_.Exception.Message -like '*exit code 2*'}
    if(!$syntaxRejected -or (Get-FileHash -LiteralPath $brokenFile).Hash -ne $hashBefore) {throw 'Invalid syntax was not safely preserved/reported.'}
    $blocked = $false
    try { Assert-Empty $fixture } catch { $blocked=$true }
    if (!$blocked) { throw 'Existing-output refusal failed.' }
    $blocked=$false
    try { [void](Assert-Contained $fixture (Join-Path $fixture '..\escape')) } catch {$blocked=$true}
    if (!$blocked) { throw 'Traversal protection failed.' }
    $powershell = Join-Path $env:SystemRoot 'System32\WindowsPowerShell\v1.0\powershell.exe'
    $p = Start-Owned $powershell @('-NoProfile','-Command','Start-Sleep -Seconds 15') $testRoot (Join-Path $testRoot 'timeout')
    $timedOut=$false
    try { Wait-Owned $p 1 'Synthetic timeout' } catch { $timedOut=$_.Exception.Message -like '*timed out*' }
    if (!$timedOut -or !$p.HasExited) { throw 'Process timeout/cleanup failed.' }
    $failed=$false
    try {Invoke-Owned $powershell @('-NoProfile','-Command','exit 7') $testRoot (Join-Path $testRoot 'failure') 10} catch {$failed=$_.Exception.Message -like '*exit code 7*'}
    if(!$failed) {throw 'Nonzero exit-code handling failed.'}
    $socket=New-Object Net.Sockets.TcpListener([Net.IPAddress]::Loopback,0)
    $socket.Start()
    try {
        $contender=New-Object Net.Sockets.TcpListener([Net.IPAddress]::Loopback,$socket.LocalEndpoint.Port)
        $collision=$false
        try {$contender.Start()} catch {$collision=$true} finally {$contender.Stop()}
        if(!$collision) {throw 'Occupied-port fixture did not reject a second listener.'}
    } finally {$socket.Stop()}
    Write-Output "Self-test passed. Synthetic fixtures and logs: $testRoot"
}

function Invoke-RipperRequest([string]$Base, [string]$Route, [hashtable]$Form, [int]$Timeout = $StageTimeoutSeconds) {
    $response = Invoke-WebRequest -Uri ($Base+$Route) -Method Post -Body $Form -ContentType 'application/x-www-form-urlencoded' -UseBasicParsing -TimeoutSec $Timeout
    if ($response.StatusCode -ne 200 -or $response.Content -match '(?i)<title>[^<]*(error|exception)') {
        throw "AssetRipper rejected $Route. Inspect AssetRipper logs."
    }
}
function Get-GuidInventory([string]$Assets) {
    $map=@{}
    foreach($file in Get-ChildItem -LiteralPath $Assets -Recurse -File -Filter '*.meta') {
        $match=[regex]::Match([IO.File]::ReadAllText($file.FullName),'(?m)^guid:\s*([0-9a-f]{32})\s*$')
        if($match.Success) {
            $guid=$match.Groups[1].Value
            if($map.ContainsKey($guid)) {throw "Duplicate asset GUID $guid in $($file.FullName) and $($map[$guid])"}
            $map[$guid]=$file.FullName.Substring($Assets.Length+1)
        }
    }
    return $map
}

if ($SelfTest -and $PreflightOnly) { throw 'Choose either -SelfTest or -PreflightOnly.' }
try {
    if ($SelfTest) { Invoke-SelfTest; return }
    $preflight=Get-Preflight
    if ($PreflightOnly) { $preflight | ConvertTo-Json -Depth 5; return }

    [void][IO.Directory]::CreateDirectory($Recovery)
    $ownership=[IO.File]::Open((Join-Path $Recovery 'recovery-owner.lock'),[IO.FileMode]::CreateNew,[IO.FileAccess]::Write,[IO.FileShare]::None)
    $ownership.Dispose() # persistent marker makes concurrent/repeated invocations fail closed
    Assert-Empty $Project
    [void][IO.Directory]::CreateDirectory($Project)
    foreach($dir in @('Extracted','Tools','OriginalExport','Il2Cpp','Reports','Logs')) {
        [void][IO.Directory]::CreateDirectory((Join-Path $Recovery $dir))
    }
    $reports=Join-Path $Recovery 'Reports'
    $logs=Join-Path $Recovery 'Logs'
    $report=[ordered]@{ status='Running'; stage=$script:Stage; source=$preflight; targetVersion=$TargetVersion; startedUtc=[DateTime]::UtcNow.ToString('o'); limitations=@('Method bodies are stubs; this is not a playable gameplay reconstruction.','Unity version conversion is experimental.'); stages=@() }
    Write-Json (Join-Path $reports 'recovery.json') $report

    Set-RecoveryStage 'InspectAndExtract'
    Write-Host 'Inspecting APK backend and extracting matched recovery inputs...'
    Add-Type -AssemblyName System.IO.Compression.FileSystem
    $archive=[IO.Compression.ZipFile]::OpenRead($Apk)
    try {
        $entries=@($archive.Entries)
        $binaries=@($entries | Where-Object FullName -eq 'lib/arm64-v8a/libil2cpp.so')
        $metadata=@($entries | Where-Object FullName -eq 'assets/bin/Data/Managed/Metadata/global-metadata.dat')
        $allIl2cpp=@($entries | Where-Object FullName -match '(^|/)libil2cpp\.so$')
        $mono=@($entries | Where-Object FullName -match '^assets/bin/Data/Managed/[^/]+\.dll$')
        if($allIl2cpp.Count -or $metadata.Count) {
            if($binaries.Count -ne 1 -or $metadata.Count -ne 1) { throw 'Incomplete/ambiguous IL2CPP input: exactly one ARM64 binary and metadata pair is required.' }
            $report.backend='IL2CPP'
        } elseif($mono.Count) { $report.backend='Mono' }
        else { throw 'No supported Unity IL2CPP or managed Mono backend found. Supply the complete APK/splits.' }
        $selected=@($binaries)+@($metadata)+@($entries | Where-Object FullName -eq 'assets/bin/Data/globalgamemanagers')
        if($report.backend -eq 'Mono') { $selected+=@($mono) }
        foreach($entry in $selected) {
            $target=Assert-Contained (Join-Path $Recovery 'Extracted') (Join-Path (Join-Path $Recovery 'Extracted') $entry.FullName)
            [void][IO.Directory]::CreateDirectory([IO.Path]::GetDirectoryName($target))
            [IO.Compression.ZipFileExtensions]::ExtractToFile($entry,$target,$false)
        }
        $report.apkEntryCount=$entries.Count
    } finally { $archive.Dispose() }
    $ggm=Join-Path $Recovery 'Extracted\assets\bin\Data\globalgamemanagers'
    if(!(Test-Path -LiteralPath $ggm)) { throw 'globalgamemanagers missing; cannot establish original engine version.' }
    $stream=[IO.File]::OpenRead($ggm)
    try { $header=New-Object byte[] 128; [void]$stream.Read($header,0,$header.Length) } finally {$stream.Dispose()}
    $versionMatch=[regex]::Match([Text.Encoding]::ASCII.GetString($header),'\d{4}\.\d+\.\d+[abfp]\d+')
    if(!$versionMatch.Success) {throw 'Cannot identify source Unity version from serialized header.'}
    $report.sourceUnityVersion=$versionMatch.Value

    if($report.backend -eq 'IL2CPP') {
        Set-RecoveryStage 'Il2CppDumper'
        $privateDumper=Join-Path $Recovery 'Tools\Il2CppDumper'
        Copy-Item -LiteralPath (Split-Path $Dumper) -Destination $privateDumper -Recurse
        $configPath=Join-Path $privateDumper 'config.json'
        $config=Get-Content -LiteralPath $configPath -Raw | ConvertFrom-Json
        $config.GenerateDummyDll=$true; $config.GenerateStruct=$true; $config.RequireAnyKey=$false
        $config.ForceIl2CppVersion=$false; $config.ForceDump=$false
        Write-Json $configPath $config
        $binary=Join-Path $Recovery 'Extracted\lib\arm64-v8a\libil2cpp.so'
        $meta=Join-Path $Recovery 'Extracted\assets\bin\Data\Managed\Metadata\global-metadata.dat'
        $metadataVersion=Read-Il2CppInputInfo $binary $meta
        $report.metadataVersion=$metadataVersion
        $report.binarySha256=(Get-FileHash -LiteralPath $binary).Hash
        $report.metadataSha256=(Get-FileHash -LiteralPath $meta).Hash
        $dumpOut=Join-Path $Recovery 'Il2Cpp'
        Invoke-Owned (Join-Path $privateDumper 'Il2CppDumper.exe') @($binary,$meta,$dumpOut) $privateDumper (Join-Path $logs 'il2cpp')
        foreach($name in @('dump.cs','script.json','stringliteral.json','il2cpp.h')) {
            if(!(Test-Path -LiteralPath (Join-Path $dumpOut $name))) {throw "Il2CppDumper did not produce $name. Inspect logs for unsupported metadata or registration failures."}
        }
        if(@(Get-ChildItem -LiteralPath (Join-Path $dumpOut 'DummyDll') -Filter '*.dll' -ErrorAction SilentlyContinue).Count -eq 0) {throw 'Il2CppDumper produced no dummy assemblies.'}
        # Enrichment scripts ship with the tool; the dumper need not copy them itself.
        Get-ChildItem -LiteralPath $privateDumper -Filter '*.py' | Copy-Item -Destination $dumpOut
    }

    Set-RecoveryStage 'AssetRipperExport'
    Write-Host 'Exporting APK through the installed AssetRipper headless HTTP API...'
    $privateRipper=Join-Path $Recovery 'Tools\AssetRipper'
    Copy-Item -LiteralPath (Split-Path $Ripper) -Destination $privateRipper -Recurse
    $listener=New-Object Net.Sockets.TcpListener([Net.IPAddress]::Loopback,0)
    $listener.Start(); $port=$listener.LocalEndpoint.Port; $listener.Stop()
    $base="http://127.0.0.1:$port"
    $p=Start-Owned (Join-Path $privateRipper (Split-Path $Ripper -Leaf)) @('--headless','--port',"$port",'--log-path',(Join-Path $logs 'assetripper.log')) $privateRipper (Join-Path $logs 'assetripper')
    $ready=$false; $clock=[Diagnostics.Stopwatch]::StartNew()
    while($clock.Elapsed.TotalSeconds -lt 60 -and !$p.HasExited) {
        try {$page=Invoke-WebRequest "$base/Settings/Edit" -UseBasicParsing -TimeoutSec 2; $ready=$page.StatusCode -eq 200; if($ready){break}} catch {}
        Start-Sleep -Milliseconds 500; $p.Refresh()
    }
    if(!$ready -or $p.HasExited) {throw 'AssetRipper did not start its local API. Check port/process logs.'}
    # Ensure the listener belongs to our process, not a competing port claimant.
    if(@(Get-NetTCPConnection -LocalPort $port -State Listen | Where-Object OwningProcess -eq $p.Id).Count -eq 0) {throw 'AssetRipper port ownership verification failed.'}
    $settings=@{
        DefaultVersion=$report.sourceUnityVersion; TargetVersion=$TargetVersion;
        ScriptContentLevel='Level1'; ScriptExportMode='Decompiled'; ScriptLanguageVersion='CSharp9_0';
        StreamingAssetsMode='Extract'; ShaderExportMode='Decompile';
        ScriptTypesFullyQualified='on'; RemoveNullableAttributes='on'; ExportUnreadableAssets='on';
        SaveSettingsToDisk='on'
    }
    foreach($key in @('TargetVersion','ScriptContentLevel','ScriptExportMode','ScriptLanguageVersion','ShaderExportMode')) {
        if($page.Content -notmatch ('name="'+$key+'"')) {throw "Unsupported AssetRipper settings contract: $key"}
    }
    Invoke-RipperRequest $base '/Settings/Update' $settings 60
    $saved=Get-Content -LiteralPath (Join-Path $privateRipper 'AssetRipper.Settings.json') -Raw | ConvertFrom-Json
    if($saved.Import.TargetVersion -ne $TargetVersion -or [string]$saved.Import.ScriptContentLevel -notin @('1','Level1') -or [string]$saved.Export.ScriptExportMode -notin @('0','Decompiled')) {throw 'AssetRipper did not accept the requested target/stub/source settings.'}
    Write-Json (Join-Path $reports 'assetripper-settings.json') $saved
    Invoke-RipperRequest $base '/LoadFile' @{Path=$Apk}
    Invoke-RipperRequest $base '/Export/UnityProject' @{Path=$Project;CreateSubfolder='false'}
    if(!$p.HasExited) {$p.Kill(); $p.WaitForExit()}
    if(!(Test-Path -LiteralPath (Join-Path $Project 'Assets'))) {
        $candidates=@(Get-ChildItem -LiteralPath $Project -Directory | Where-Object {Test-Path -LiteralPath (Join-Path $_.FullName 'Assets')})
        if($candidates.Count -ne 1) {throw 'AssetRipper export did not yield exactly one Unity project.'}
        $wrapper=Assert-Contained $Project $candidates[0].FullName
        foreach($child in Get-ChildItem -LiteralPath $wrapper -Force) {
            $dest=Assert-Contained $Project (Join-Path $Project $child.Name)
            if(Test-Path -LiteralPath $dest) {throw "Project wrapper collision: $dest"}
            Move-Item -LiteralPath $child.FullName -Destination $dest
        }
        Remove-Item -LiteralPath $wrapper # now empty; never recursively delete an output
    }
    foreach($child in Get-ChildItem -LiteralPath $Project -Force) {Copy-Item -LiteralPath $child.FullName -Destination (Join-Path $Recovery 'OriginalExport') -Recurse}
    $assets=Join-Path $Project 'Assets'
    $initialGuids=Get-GuidInventory $assets
    Write-Json (Join-Path $reports 'original-guids.json') $initialGuids
    if(@(Get-ChildItem -LiteralPath $assets -Recurse -Filter '*.unity').Count -eq 0) {throw 'Export contains no recovered scenes.'}
    if(@(Get-ChildItem -LiteralPath $assets -Recurse -Filter '*.cs').Count -eq 0) {throw 'Export contains no recovered C# scripts.'}
    $dlls=@(Get-ChildItem -LiteralPath $assets -Recurse -Filter '*.dll')
    Write-Json (Join-Path $reports 'unexpected-assemblies.json') @($dlls | Select-Object FullName)
    if($dlls.Count) {throw 'Source-only export contains DLLs. Review unexpected-assemblies.json before importing; no DLL was silently deleted.'}
    if(!(Test-Path -LiteralPath (Join-Path $assets 'Scripts'))) {throw 'Exporter did not produce Assets\Scripts. Refusing a blind relocation across assembly boundaries.'}

    Set-RecoveryStage 'RepairAndMap'
    $helper=Build-RepairHelper (Join-Path $Recovery 'Tools\Repair') $preflight.sdk
    $allowPath=Join-Path $reports 'confirmed-noninterop-types.json'
    Write-Json $allowPath @($ConfirmedNonInteropLayoutTypes)
    Invoke-Owned $preflight.sdk.Exe @($helper,$assets,(Join-Path $reports 'script-repairs.json'),$allowPath) $Recovery (Join-Path $logs 'script-repair')
    $javaRoot=Join-Path $Source 'app\src\main\java'
    $typeInventory=(Get-Content -LiteralPath (Join-Path $reports 'script-repairs.json') -Raw | ConvertFrom-Json).types
    $bridges=@(Get-ChildItem -LiteralPath $javaRoot -Recurse -Filter '*.java' | Select-String -Pattern 'UnitySendMessage\s*\(|"UnitySendMessage"|System\.loadLibrary\s*\(|\bnative\s+[^;{]+\(' | ForEach-Object {
        $line=$_.Line.Trim()
        $send=[regex]::Match($line,'UnitySendMessage\s*\(\s*"([^"]+)"\s*,\s*"([^"]+)"')
        $candidates=@()
        if($send.Success) {
            $method=$send.Groups[2].Value
            $candidates=@($typeInventory | Where-Object {$_.methods -contains $method} | Select-Object file,fullName)
        }
        [pscustomobject]@{ source=$_.Path; line=$_.LineNumber; declaration=$line;
            gameObjectTarget=if($send.Success){$send.Groups[1].Value}else{$null};
            methodTarget=if($send.Success){$send.Groups[2].Value}else{$null}; candidates=$candidates;
            mapping='Unverified candidates only: UnitySendMessage targets scene objects, not class names; JNI/dynamic calls require manual mapping' }
    })
    Write-Json (Join-Path $reports 'java-bridges.json') $bridges
    $currentGuids=Get-GuidInventory $assets
    foreach($guid in $initialGuids.Keys) {if(!$currentGuids.ContainsKey($guid)) {throw "Repair lost asset GUID $guid"}}
    $missingRefs=@(Get-ChildItem -LiteralPath $assets -Recurse -File | Where-Object Extension -in @('.unity','.prefab','.asset','.mat','.controller') | ForEach-Object {
        $path=$_.FullName
        foreach($m in [regex]::Matches([IO.File]::ReadAllText($path),'guid:\s*([0-9a-f]{32})')) {
            $g=$m.Groups[1].Value
            if($g -notmatch '^0{16}' -and !$currentGuids.ContainsKey($g)) {[pscustomobject]@{file=$path;guid=$g;status='Not in Assets: check Packages or missing export'}}
        }
    })
    Write-Json (Join-Path $reports 'external-or-missing-references.json') $missingRefs
    if(!(Test-Path -LiteralPath (Join-Path $Project 'Packages\manifest.json'))) {throw 'Export is missing Packages\manifest.json; cannot safely infer package dependencies.'}
    [void](Get-Content -LiteralPath (Join-Path $Project 'Packages\manifest.json') -Raw | ConvertFrom-Json)
    $versionFile=Join-Path $Project 'ProjectSettings\ProjectVersion.txt'
    if(!(Test-Path -LiteralPath $versionFile) -or (Get-Content -LiteralPath $versionFile -Raw) -notmatch ('m_EditorVersion:\s*'+[regex]::Escape($TargetVersion)+'\b')) {throw 'Export target version does not match 2020.3.49f1.'}
    $validationDir=Join-Path $assets 'SoccerRecoveryValidation\Editor'
    if(Test-Path -LiteralPath (Split-Path $validationDir)) {throw 'Recovery validator path conflicts with an exported asset.'}
    [void][IO.Directory]::CreateDirectory($validationDir)
    Write-Utf8 (Join-Path $validationDir 'SoccerRecoveryValidation.cs') $ValidatorSource
    Write-Json (Join-Path $validationDir 'SoccerRecoveryValidation.asmdef') @{name='SoccerRecoveryValidation';includePlatforms=@('Editor');autoReferenced=$false;overrideReferences=$true;precompiledReferences=@();references=@()}

    Set-RecoveryStage 'UnityValidation'
    Write-Host 'Importing and validating with Unity 2020.3.49f1. Package resolution may require network access.'
    $oldReportEnv=[Environment]::GetEnvironmentVariable('SOCCER_RECOVERY_REPORTS','Process')
    try {
        [Environment]::SetEnvironmentVariable('SOCCER_RECOVERY_REPORTS',$reports,'Process')
        # No -quit: the validation method owns completion and calls EditorApplication.Exit.
        Invoke-Owned $Editor @('-batchmode','-projectPath',$Project,'-executeMethod','SoccerRecoveryValidation.Run','-logFile',(Join-Path $logs 'unity.log')) $Project (Join-Path $logs 'unity-process')
    } finally { [Environment]::SetEnvironmentVariable('SOCCER_RECOVERY_REPORTS',$oldReportEnv,'Process') }
    $validationPath=Join-Path $reports 'unity-validation.json'
    if(!(Test-Path -LiteralPath $validationPath)) {throw 'Unity did not complete the validation method. Check licensing, compilation, package and crash logs.'}
    $validation=Get-Content -LiteralPath $validationPath -Raw | ConvertFrom-Json
    if(!$validation.compiled -or $validation.unityVersion -ne $TargetVersion) {throw 'Unity validation failed compilation/version checks.'}
    $unityLog=Get-Content -LiteralPath (Join-Path $logs 'unity.log') -Raw
    if($unityLog -match '(?im)(error CS\d+|Scripts have compiler errors|Assembly .* will not be loaded|Fatal Error!|Failed to load assembly)') {throw 'Unity log contains compilation, assembly-load or fatal errors.'}
    $report.validation=$validation
    $report.assetIssues=@($validation.items | Where-Object {$_.error -or $_.missingScripts -gt 0}).Count + @($validation.editorErrors).Count
    $report.status=if($report.assetIssues -gt 0 -or $missingRefs.Count -gt 0){'CompiledWithAssetIssues'}else{'Compiled'}
    $report.stage='Complete'; $report.finishedUtc=[DateTime]::UtcNow.ToString('o')
    Write-Json (Join-Path $reports 'recovery.json') $report
    Write-Host "Recovery result: $($report.status). Project: $Project"
    Write-Host "Review $reports\recovery.json. Gameplay methods remain stubs."
} catch {
    if($null -ne $report -and $reports) {
        $report.status='Failed'; $report.stage=$script:Stage; $report.error=$_.Exception.ToString(); $report.finishedUtc=[DateTime]::UtcNow.ToString('o')
        Write-Json (Join-Path $reports 'recovery.json') $report
    }
    throw
} finally {
    foreach($process in $script:OwnedProcesses) {
        try {if(!$process.HasExited){$process.Kill();$process.WaitForExit()}} catch {Write-Warning "Could not stop owned process $($process.Id): $_"}
        $process.Dispose()
    }
}

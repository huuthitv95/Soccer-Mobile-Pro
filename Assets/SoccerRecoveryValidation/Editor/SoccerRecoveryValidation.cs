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
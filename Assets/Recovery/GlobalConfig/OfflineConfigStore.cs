using System;
using System.Globalization;
using System.IO;
using UnityEngine;

namespace Soccer.Recovery.GlobalConfig
{
    public enum OfflineAccent { Lime, Blue, Amber }

    // Recovery schema v1. None of these fields claims to decode the original 76-byte tail.
    [Serializable]
    public sealed class OfflineConfigData
    {
        public int version = 1;
        public bool showBanner = true;
        public float panelOpacity = .96f;
        public string profileName = "Offline";
        public OfflineAccent accent = OfflineAccent.Lime;
        public OfflineConfigData Copy() { return (OfflineConfigData)MemberwiseClone(); }
        public bool Validate(out string error)
        {
            error = null;
            if (version != 1) error = "Phiên bản cấu hình không được hỗ trợ.";
            else if (float.IsNaN(panelOpacity) || float.IsInfinity(panelOpacity) || panelOpacity < .65f || panelOpacity > 1f)
                error = "Độ đậm nền phải từ 0.65 đến 1.00.";
            else if (string.IsNullOrWhiteSpace(profileName) || profileName.Length > 32 || profileName.IndexOfAny(new[] {'\r','\n','\t'}) >= 0)
                error = "Tên hồ sơ cần 1–32 ký tự, trên một dòng.";
            else if (!Enum.IsDefined(typeof(OfflineAccent), accent)) error = "Màu nhấn không hợp lệ.";
            return error == null;
        }
    }

    public sealed class OfflineConfigField
    {
        public readonly string Key, Label, Kind, DefaultValue, Evidence;
        public readonly bool Editable;
        public OfflineConfigField(string key, string label, string kind, string value, string evidence, bool editable = true)
        { Key=key; Label=label; Kind=kind; DefaultValue=value; Evidence=evidence; Editable=editable; }
    }

    public static class OfflineConfigRegistry
    {
        public static readonly OfflineConfigField[] Fields = {
            new OfflineConfigField("showBanner", "Hiện nhãn hồ sơ", "bool", "true", "Recovery: OfflineConfigWindow.Apply"),
            new OfflineConfigField("panelOpacity", "Độ đậm nền (0.65–1.00)", "number", "0.96", "Recovery: OfflineConfigWindow.Apply"),
            new OfflineConfigField("profileName", "Tên hồ sơ (tối đa 32 ký tự)", "string", "Offline", "Recovery: OfflineConfigWindow.Apply"),
            new OfflineConfigField("accent", "Màu nhấn", "enum", "Lime", "Recovery: OfflineConfigWindow.Apply"),
            new OfflineConfigField("NativeOverlayAdWidth", "NativeOverlayAdWidth", "float", "1", "Native ctor RVA 0xC5258C; recovered consumer unsupported", false),
            new OfflineConfigField("NativeOverlayAdHeight", "NativeOverlayAdHeight", "float", "1", "Native ctor RVA 0xC5258C; recovered consumer unsupported", false),
            new OfflineConfigField("EnableStarPlayerAppearance", "EnableStarPlayerAppearance", "bool", "false", "SimpleConfig metadata; zero-initialized field, consumer stub", false),
            new OfflineConfigField("EnableScreenTimeTrackerTester", "EnableScreenTimeTrackerTester", "bool", "false", "SimpleConfig metadata; zero-initialized field, consumer stub", false),
            new OfflineConfigField("BlockRV", "BlockRV", "bool", "false", "SimpleConfig metadata; zero-initialized field, consumer stub", false)
        };
        public static bool Matches(OfflineConfigField f, string query)
        { return string.IsNullOrEmpty(query) || (f.Key + " " + f.Label).IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0; }
    }

    public sealed class OfflineConfigStore
    {
        public string Path { get; private set; }
        public string LoadNotice { get; private set; }
        public OfflineConfigStore(string path) { Path = path; }
        public OfflineConfigData Load()
        {
            LoadNotice = null;
            if (!File.Exists(Path)) return new OfflineConfigData();
            try
            {
                var json = File.ReadAllText(Path);
                // Require every v1 member: JsonUtility otherwise accepts partial documents silently.
                foreach (var key in new[] {"version", "showBanner", "panelOpacity", "profileName", "accent"})
                    if (!System.Text.RegularExpressions.Regex.IsMatch(json, "\"" + key + "\"\\s*:"))
                        throw new InvalidDataException("Missing " + key);
                var data = JsonUtility.FromJson<OfflineConfigData>(json);
                string error;
                if (data == null || !data.Validate(out error)) throw new InvalidDataException("Invalid config values");
                return data;
            }
            catch (Exception e) when (e is IOException || e is InvalidDataException || e is UnauthorizedAccessException || e is ArgumentException || e is FormatException)
            {
                var backup = Path + ".invalid-" + Guid.NewGuid().ToString("N") + ".json";
                try { File.Copy(Path, backup); }
                catch (Exception copyError) when (copyError is IOException || copyError is UnauthorizedAccessException)
                { LoadNotice = "Không đọc/lưu được cấu hình lỗi. Bản gốc được giữ nguyên; đang dùng mặc định."; return new OfflineConfigData(); }
                LoadNotice = "Cấu hình lỗi đã được giữ lại; đang dùng mặc định.";
                return new OfflineConfigData();
            }
        }
        public void Save(OfflineConfigData data)
        {
            string error;
            if (!data.Validate(out error)) throw new ArgumentException(error);
            Directory.CreateDirectory(System.IO.Path.GetDirectoryName(Path));
            var temp = Path + ".tmp-" + Guid.NewGuid().ToString("N");
            try
            {
                File.WriteAllText(temp, JsonUtility.ToJson(data, true), new System.Text.UTF8Encoding(false));
                if (File.Exists(Path)) File.Replace(temp, Path, null);
                else File.Move(temp, Path);
            }
            finally { if (File.Exists(temp)) File.Delete(temp); }
        }
    }

    public sealed class OfflineConfigSession
    {
        private readonly OfflineConfigStore store;
        public OfflineConfigData Current { get; private set; }
        public OfflineConfigData Draft { get; private set; }
        public string Notice { get { return store.LoadNotice; } }
        public OfflineConfigSession(OfflineConfigStore store) { this.store=store; Current=store.Load(); Begin(); }
        public void Begin() { Draft=Current.Copy(); }
        public void Cancel() { Begin(); }
        public void ResetDraft() { Draft=new OfflineConfigData(); }
        public bool Save(out string error)
        {
            if (!Draft.Validate(out error)) return false;
            try { store.Save(Draft); Current=Draft.Copy(); return true; }
            catch (Exception e) when (e is IOException || e is UnauthorizedAccessException)
            { error="Không lưu được cấu hình: " + e.Message; return false; }
        }
        public bool SetNumber(string value, out string error)
        {
            float number;
            if (!float.TryParse(value, NumberStyles.Float, CultureInfo.InvariantCulture, out number) || float.IsNaN(number) || float.IsInfinity(number) || number<.65f || number>1f)
            { error="Độ đậm nền phải từ 0.65 đến 1.00 (dùng dấu chấm)."; return false; }
            Draft.panelOpacity=number; error=null; return true;
        }
    }
}

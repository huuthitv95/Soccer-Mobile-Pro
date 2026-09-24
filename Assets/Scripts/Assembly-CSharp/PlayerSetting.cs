public class PlayerSetting : global::UnityEngine.MonoBehaviour
{
    public enum DumpType
    {
        DumpAll = 0,
        DumpABtest = 1
    }

    [global::UnityEngine.HideInInspector]
    public string deviceId;
    private static PlayerSetting inst;
    public static bool MatchStartRequested;
    public static int VERSION_NUMBER;
    public static global::Srv.AllSettings setting;
    public static string Savepath;
    public const int HASH_BYTES = 16;
    private static global::System.Collections.Generic.Dictionary<ushort, global::System.Action<global::Common.GameMessage>> handlers;
    public static bool hideUI;
    public static bool hideDebug;
    public static bool fullPlayback;
    private static bool _profileLoaded;
    private static bool _syncdirty;
    private static bool _localdirty;
    public static readonly string Dumppath;
    public static bool? IsAdult;
    private static int lastPlayTime;
    private bool restrict;
    private static bool FirebaseCheckAndFixStarted;
    private static string nationality;
    private static NationalData.eNation userNation;
    private static NationalData.eContinent userContinent;
    public static string[] cityInfo;
    private static string path => null;
    private static string pathbackup => null;
    private static string externalpath => null;
    public static bool isiPad { get; private set; }
    public static bool noMetal { get; set; }
    public static float DeviceMemory => 0f;
    public static bool ProfileLoaded => false;
    public static NationalData.eNation UserNation => NationalData.eNation.None;
    public static NationalData.eContinent UserContinent => NationalData.eContinent.None;
    public static string Nationality => null;

    private void Awake()
    {
    }

    private void Start()
    {
    }

    public static void WriteServerLog(string name, string p = "", string p2 = "")
    {
    }

    private global::System.Collections.IEnumerator AsyncLoadSavePath()
    {
        return null;
    }

    private void LoadSavePath()
    {
    }

    public static void Load()
    {
    }

    private static void OnSettingReady()
    {
    }

    private static void InitialSetting()
    {
    }

    public static bool LoadFromFile()
    {
        return false;
    }

    public static bool LoadHashedFile(string filepath, out byte[] buf, out int length)
    {
        buf = null;
        length = default;
        return false;
    }

    public static void Save()
    {
    }

    public static void SaveIapCriticalImmediate()
    {
    }

    public static bool TrySaveIapCriticalImmediate(out string error)
    {
        error = null;
        return false;
    }

    public static void Clear()
    {
    }

    private void CheckDirtyFlag()
    {
    }

    public static void MarkLocalDirtyFlag()
    {
    }

    public static void MarkSyncDirtyFlag()
    {
    }

    private static void SaveToFile()
    {
    }

    public static int GetCurrentDate()
    {
        return 0;
    }

    public static byte[] HashBuffer(byte[] input)
    {
        return null;
    }

    public static byte[] HashBuffer(byte[] input, int offset, int length)
    {
        return null;
    }

    public static bool DumpToFile()
    {
        return false;
    }

    public static string DumpToString(PlayerSetting.DumpType dumpType)
    {
        return null;
    }

    public static bool LoadDump(string str, PlayerSetting.DumpType dumpType)
    {
        return false;
    }

    public static bool LoadDumpABTest(global::System.Collections.Generic.Dictionary<string, string> data)
    {
        return false;
    }

    private static bool LoadDumpImplement(global::System.Action loadAction)
    {
        return false;
    }

    public static bool LoadDumpFile()
    {
        return false;
    }

    public static global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>> DumpABTest()
    {
        return null;
    }

    public static void AddMatchCount()
    {
    }

    public static int GetMatchCount()
    {
        return 0;
    }

    public static void AddMatchEndCount()
    {
    }

    public static int GetMatchEndCount()
    {
        return 0;
    }

    private void InitFirebase()
    {
    }

    public void CheckAndFixFirebaseDependencies()
    {
    }

    private void OnFirebaseInitialed(global::System.Threading.Tasks.Task<global::Firebase.DependencyStatus> task)
    {
    }

    public static void LoadNationality()
    {
    }

    public static void RequestCityInfo()
    {
    }

    public static RemoteSync GetRemoteSync()
    {
        return null;
    }
}
public class AdmobADUnit : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.TextAsset AdUnitFile;
    public static AdmobADUnit Inst;
    public static bool DelayLoad;
    private void Start()
    {
    }

    public bool CheckAdUnitRespHashValue(string resp)
    {
        return false;
    }

    private global::System.Collections.Generic.List<string> ParseAdUnitFileData(string data)
    {
        return null;
    }

    private bool SaveAdUnitDataToLocalMemory(global::System.Collections.Generic.List<string> adUnitList)
    {
        return false;
    }

    public bool GetRemoteAdUnitConfig(string resp)
    {
        return false;
    }

    public void GetLocalAdUnitConfig()
    {
    }
}
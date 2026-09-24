public class CustomADBoard : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.MeshFilter[] meshFilter;
    private float anmationDuration;
    [global::UnityEngine.SerializeField]
    private float showDuration;
    private static readonly int PauseId;
    private static readonly int ReverseId;
    private static readonly int PauseFrameId;
    private static readonly int StartTimeId;
    private static readonly int AnimationDurationId;
    private global::UnityEngine.Coroutine playRoutine;
    private global::UnityEngine.MeshRenderer[] renderers;
    private CustomADDisplayTracker[] trackers;
    private global::UnityEngine.Material sharedMaterial;
    private global::UnityEngine.Material sharedMaterialB;
    private static bool useCustomMode;
    private static global::System.Collections.Generic.List<CustomADGroupConfig.ADGroup> activeGroups;
    private static int currentGroupIndex;
    private string[] materialPath;
    private const string MATERIAL_DIR = "Assets/StadiumCommon/CustomADBoard/Materials/";
    public static void InitCustomMode(CustomADGroupConfig config, global::System.Collections.Generic.List<int> enabledGroupIds)
    {
    }

    public static void ResetCustomMode()
    {
    }

    private void Awake()
    {
    }

    private void OnEnable()
    {
    }

    private void OnDisable()
    {
    }

    private void CreateMesh()
    {
    }

    private void CacheRenderers()
    {
    }

    private void SetTrackersGroupId(int groupId)
    {
    }

    private global::System.Collections.IEnumerator PlayLoop()
    {
        return null;
    }

    private void SetPlaybackControl(float pause, float reverse, float pauseFrame, float startTime, float animationDuration)
    {
    }

    private global::UnityEngine.Material GetNextMaterial()
    {
        return null;
    }

    private void ApplyMaterial()
    {
    }

    private void ApplyGroupMaterial()
    {
    }

    private void ApplyOriginalMaterial()
    {
    }
}
public static class LeaveMatchDatas
{
    public static int controllerId;
    public static int fistBump1PlayerId;
    public static int fistBump2PlayerId;
    public static int userTeamId;
    public static global::UnityEngine.Vector3 startPos;
    public static global::UnityEngine.Quaternion startRot;
    public static bool StartPosValid => false;

    private static void Clear()
    {
    }

    public static void OnMatchCreate(CupMatchBase match, AISampleBase aISample)
    {
    }

    public static void OnPlayerReady(InGamePlayer player)
    {
    }
}
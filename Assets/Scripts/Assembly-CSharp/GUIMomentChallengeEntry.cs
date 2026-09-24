public class GUIMomentChallengeEntry : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject inProgress;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject completed;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text[] timeTexts;
    [global::UnityEngine.SerializeField]
    private GUITeam userTeam;
    [global::UnityEngine.SerializeField]
    private GUITeam opponentTeam;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text scoreText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text matchTimeText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject failTip;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject completedTip;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text rewardText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text progressText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text unlockDescText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text unlockDescText2;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject lockedMark;
    private MomentChallengeManager manager;
    private MomentChallengeConfigManager.ChallengeInfo currentChallenge;
    public static void OpenMomentChallengeWindowNoRedPoint()
    {
    }

    public static void OpenMomentChallengeWindowFormRewardUnlock()
    {
    }

    private static void OpenMomentChallengeWindowInternal(bool refreshRedPoint)
    {
    }

    public static void OpenMomentChallengeWindow()
    {
    }

    public static void ApplyUnlockRewardImage(global::UnityEngine.UI.Image image, global::UnityEngine.UI.Text desc, global::UnityEngine.GameObject playMark)
    {
    }

    public static void Apply26CupUnlockButtonStyle(global::UnityEngine.UI.Image image, global::UnityEngine.UI.Text desc, global::UnityEngine.GameObject playMark)
    {
    }

    public static void ApplyEuroCupUnlockButtonStyle(global::UnityEngine.UI.Image image, global::UnityEngine.UI.Text desc, global::UnityEngine.GameObject playMark)
    {
    }

    private static void ApplyEventUnlockButtonStyle(global::UnityEngine.UI.Image image, global::UnityEngine.UI.Text desc, global::UnityEngine.GameObject playMark, string spriteName)
    {
    }

    public static bool EnableMomentChallenge()
    {
        return false;
    }

    public static bool IsUnlocked()
    {
        return false;
    }

    public static string GetUnlockDesc()
    {
        return null;
    }

    public void UpdateUI()
    {
    }

    private void ApplyStateIndicators(bool completedState)
    {
    }

    private void UpdateTeams()
    {
    }

    private void UpdateMatchSnapshot()
    {
    }

    private void UpdateCountdownTexts(MomentChallengeManager sourceManager)
    {
    }

    private static string FormatCountdown(global::System.TimeSpan remain)
    {
        return null;
    }
}
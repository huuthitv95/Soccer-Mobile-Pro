public class CoachTrustRules
{
    public const int MinTrustPoint = 0;
    public const int MaxTrustPoint = 1500;
    public const int TeamSubstituteTrustMin = 200;
    public const int TeamStarterTrustMin = 600;
    public const int TeamStarTrustMin = 1300;
    public const int FringeSubInSignalMinute = 70;
    public const int SubstituteSubInSignalMinute = 50;
    private const float MatchRatingTrustScale = 60f;
    private const float MatchRatingTrustBase = 6f;
    private const float TransferTrustKeepRatio = 0.8f;
    private const float TransferTrustRatingScale = 10f;
    private global::Srv.UserPlayerDataArchive archive;
    private global::FLGameProgressSetting.LocalArchives storer;
    public int CurrentTrust => 0;
    public CoachTrustTier CurrentTrustTier => CoachTrustTier.TeamFringe;
    public CoachTrustPreMatchPlan CurrentPreMatchPlan => default;
    public bool StarterState => false;

    public CoachTrustRules(global::Srv.UserPlayerDataArchive archive = null, global::FLGameProgressSetting.LocalArchives storer = null)
    {
    }

    public int ApplyMatchRating(float matchRating)
    {
        return 0;
    }

    public int ApplyTransferTrust(float playerRating)
    {
        return 0;
    }

    public bool TryMarkFirstReachedTier(CoachTrustTier tier)
    {
        return false;
    }

    private void SetTrust(int trust)
    {
    }

    public static int GetTrustDeltaByMatchRating(float matchRating)
    {
        return 0;
    }

    public static int GetTransferTrust(int trustBeforeTransfer, float playerRating)
    {
        return 0;
    }

    public static int ClampTrust(int trust)
    {
        return 0;
    }

    public static CoachTrustTier GetTrustTier(int trust)
    {
        return CoachTrustTier.TeamFringe;
    }

    public static bool IsStarter(CoachTrustTier trustTier)
    {
        return false;
    }

    public static int GetAutoSubInSignalMinute(CoachTrustTier trustTier)
    {
        return 0;
    }

    public static CoachTrustPreMatchPlan GetPreMatchPlan(int trust)
    {
        return default;
    }
}
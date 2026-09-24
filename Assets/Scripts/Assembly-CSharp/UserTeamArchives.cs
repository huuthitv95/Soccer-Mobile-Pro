public class UserTeamArchives
{
    private static global::Srv.GlobalGameProgressSettings Data => null;

    public static global::Srv.GameMode LastPlayed
    {
        get
        {
            return global::Srv.GameMode.WorldCup;
        }

        set
        {
        }
    }

    public static void CheckInit()
    {
    }

    public static CupMatchBase GetNextMatch()
    {
        return null;
    }
}
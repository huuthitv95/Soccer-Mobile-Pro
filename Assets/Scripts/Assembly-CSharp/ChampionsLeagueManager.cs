public class ChampionsLeagueManager : global::Common.Singleton<ChampionsLeagueManager>
{
    public global::System.Collections.Generic.List<global::SL.CupRules> Rules;
    public global::System.Collections.Generic.List<FACup> ChampionsLeagueMode;
    private global::System.Collections.Generic.Dictionary<string, (global::SL.CupRules, global::SL.CupRules)> RuleVariations;
    private FACup lastPlayed;
    public FACup LastPlayedCup
    {
        get
        {
            return null;
        }

        set
        {
        }
    }

    public global::System.Collections.Generic.Dictionary<string, (global::SL.CupRules, global::SL.CupRules)> GetRuleVariations()
    {
        return null;
    }

    public global::SL.CupRules GetVariationRule(string ruleName)
    {
        return null;
    }

    public void Init()
    {
    }

    public FACup CreateChampionsLeague(string protoName)
    {
        return null;
    }

    public bool HasArchive(global::SL.CupRules cup)
    {
        return false;
    }

    public bool HasValidArchive()
    {
        return false;
    }

    public void DeleteChampionsLeague(FACup cup)
    {
    }

    public void ResetLastPlayed()
    {
    }
}
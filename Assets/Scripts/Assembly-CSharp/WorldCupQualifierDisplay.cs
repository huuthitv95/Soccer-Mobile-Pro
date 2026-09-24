public class WorldCupQualifierDisplay : FACupDisplayBase, global::MultiStageTournament.MultiStageTournamentDisplay, global::FL.UIController.IPromotionRelegationMark
{
    private global::FLDataTable.WorldCupQualifierDisplayConfig displayConig;
    private MultiStageTournamentQualificationRules qualRules;
    private global::MultiStageTournament.GroupRules groupRules;
    private WorldCupQualifierManager manager;
    public override string CupName => null;
    private string Description => null;

    public WorldCupQualifierDisplay(global::FLDataTable.WorldCupQualifierDisplayConfig displayConig, MultiStageTournamentQualificationRules rules, global::MultiStageTournament.GroupRules groupRules, WorldCupQualifierManager manager)
    {
    }

    public void ShowRuleDescription(global::System.Action cb)
    {
    }

    void global::FL.UIController.IPromotionRelegationMark.Updater(global::System.Collections.Generic.List<global::FL.UIController.GUIPromotionRelegationMark> list, global::System.Action<(string, string, string)> onDesc)
    {
    }
}
namespace FL.TourEvent
{
    [global::System.Serializable]
    public class SelectableTeamTemplateConfig
    {
        public int templateTeamId;
        public string teamNameId;
        public string[] formationRoles;
        public global::FL.TourEvent.TourEventAbilityRangeConfig replacementPlayerAbilityRange;
        public int[] playerPoolIds;
        public void Normalize()
        {
        }

        public global::System.Collections.Generic.List<FormationTool.UIRole> GetFormationRoles()
        {
            return null;
        }
    }
}
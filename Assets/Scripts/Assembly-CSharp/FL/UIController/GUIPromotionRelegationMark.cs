namespace FL.UIController
{
    [global::System.Serializable]
    public struct GUIPromotionRelegationMark
    {
        [global::UnityEngine.SerializeField]
        private GUIPointStatisticsBoard.UIPromotionRule UI;
        public TeamsData team;
        public int order;
        public global::UnityEngine.GameObject PromotionMark => null;
        public global::UnityEngine.GameObject RelegationMark => null;
        public global::UnityEngine.GameObject PlayOffMark => null;

        public GUIPromotionRelegationMark(TeamsData team, int order, in GUIPointStatisticsBoard.UIPromotionRule UI)
        {
            this.UI = default;
            this.team = null;
            this.order = 0;
        }

        public void Hide()
        {
        }

        public void ShowMark(global::UnityEngine.GameObject targetMask)
        {
        }
    }
}
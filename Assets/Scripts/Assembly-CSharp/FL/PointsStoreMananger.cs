namespace FL
{
    public class PointsStoreMananger
    {
        private class SortCompare : global::System.Collections.Generic.IComparer<global::FLDataTable.PointsShopConfig>
        {
            private global::FL.PointsStoreMananger m_manager;
            public SortCompare(global::FL.PointsStoreMananger manager)
            {
            }

            public int Compare(global::FLDataTable.PointsShopConfig x, global::FLDataTable.PointsShopConfig y)
            {
                return 0;
            }
        }

        private global::Srv.PointsStoreArchive m_archive;
        private global::System.Collections.Generic.List<global::FLDataTable.PointsShopConfig> configs;
        public global::Common.Event<int> OnPointChange;
        private global::System.Action<global::FLDataTable.PointsShopConfig> OnGainReward;
        private int fixedSortPrefixCount;
        private global::FL.PointsStoreMananger.SortCompare sortCompare;
        public PointsStoreMananger(global::Srv.PointsStoreArchive archive, global::System.Collections.Generic.List<global::FLDataTable.PointsShopConfig> configs, global::System.Action<global::FLDataTable.PointsShopConfig> OnGainReward, int fixedSortPrefixCount = 3)
        {
        }

        public int GetPoints()
        {
            return 0;
        }

        public void AddPoints(int points)
        {
        }

        public void CostPoints(int points)
        {
        }

        public int GetPurchaseRecord(int id)
        {
            return 0;
        }

        public void AddPurchaseRecord(int id)
        {
        }

        public global::System.Collections.Generic.List<global::FLDataTable.PointsShopConfig> GetShopConfigs()
        {
            return null;
        }

        public void BuyItem(global::FLDataTable.PointsShopConfig item)
        {
        }

        public void Reset()
        {
        }
    }
}
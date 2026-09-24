namespace FL.TourEvent
{
    [global::System.Serializable]
    public class TourEventMapConfig
    {
        public int[] entryNodeIds;
        public int finalNodeId;
        public global::System.Collections.Generic.List<global::FL.TourEvent.TourEventNodeConfig> nodes;
        public global::System.Collections.Generic.Dictionary<string, int[]> adjacencyList;
        public void Normalize()
        {
        }

        public int[] GetNextNodeIds(int nodeId)
        {
            return null;
        }
    }
}
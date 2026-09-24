namespace UnityEngine.Timeline
{
    internal class IntervalTree<T>
        where T : global::UnityEngine.Timeline.IInterval
    {
        internal struct Entry
        {
            public long intervalStart;
            public long intervalEnd;
            public T item;
        }

        private const int kMinNodeSize = 10;
        private const int kInvalidNode = -1;
        private const long kCenterUnknown = long.MaxValue;
        private readonly global::System.Collections.Generic.List<global::UnityEngine.Timeline.IntervalTree<T>.Entry> m_Entries;
        private readonly global::System.Collections.Generic.List<global::UnityEngine.Timeline.IntervalTreeNode> m_Nodes;
        public bool dirty { get; internal set; }

        public void Add(T item)
        {
        }

        public void IntersectsWith(long value, global::System.Collections.Generic.List<T> results)
        {
        }

        public void IntersectsWithRange(long start, long end, global::System.Collections.Generic.List<T> results)
        {
        }

        public void UpdateIntervals()
        {
        }

        private void Query(global::UnityEngine.Timeline.IntervalTreeNode intervalTreeNode, long value, global::System.Collections.Generic.List<T> results)
        {
        }

        private void QueryRange(global::UnityEngine.Timeline.IntervalTreeNode intervalTreeNode, long start, long end, global::System.Collections.Generic.List<T> results)
        {
        }

        private void Rebuild()
        {
        }

        private int Rebuild(int start, int end)
        {
            return 0;
        }

        public void Clear()
        {
        }
    }
}
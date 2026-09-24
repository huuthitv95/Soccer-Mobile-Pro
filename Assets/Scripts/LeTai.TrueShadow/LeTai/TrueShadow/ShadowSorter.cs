namespace LeTai.TrueShadow
{
    public class ShadowSorter : global::UnityEngine.MonoBehaviour
    {
        private readonly struct SortEntry : global::System.IComparable<global::LeTai.TrueShadow.ShadowSorter.SortEntry>
        {
            public readonly global::LeTai.TrueShadow.TrueShadow shadow;
            public readonly global::UnityEngine.Transform shadowTransform;
            public readonly global::UnityEngine.Transform rendererTransform;
            public SortEntry(global::LeTai.TrueShadow.TrueShadow shadow)
            {
                this.shadow = null;
                shadowTransform = null;
                rendererTransform = null;
            }

            public int CompareTo(global::LeTai.TrueShadow.ShadowSorter.SortEntry other)
            {
                return 0;
            }
        }

        private readonly struct SortGroup
        {
            public readonly global::UnityEngine.Transform parentTransform;
            public readonly global::System.Collections.Generic.List<global::LeTai.TrueShadow.ShadowSorter.SortEntry> sortEntries;
            public SortGroup(global::LeTai.TrueShadow.ShadowSorter.SortEntry firstEntry)
            {
                parentTransform = null;
                sortEntries = null;
            }

            public void Add(global::LeTai.TrueShadow.ShadowSorter.SortEntry pair)
            {
            }

            public override int GetHashCode()
            {
                return 0;
            }

            public override bool Equals(object obj)
            {
                return false;
            }
        }

        private static global::LeTai.TrueShadow.ShadowSorter instance;
        private readonly global::LeTai.TrueShadow.IndexedSet<global::LeTai.TrueShadow.TrueShadow> shadows;
        private readonly global::LeTai.TrueShadow.IndexedSet<global::LeTai.TrueShadow.ShadowSorter.SortGroup> sortGroups;
        public static global::LeTai.TrueShadow.ShadowSorter Instance => null;

        public void Register(global::LeTai.TrueShadow.TrueShadow shadow)
        {
        }

        public void UnRegister(global::LeTai.TrueShadow.TrueShadow shadow)
        {
        }

        private void LateUpdate()
        {
        }

        private void AddSortEntry(global::LeTai.TrueShadow.TrueShadow shadow)
        {
        }

        public void Sort()
        {
        }

        private void OnApplicationQuit()
        {
        }
    }
}
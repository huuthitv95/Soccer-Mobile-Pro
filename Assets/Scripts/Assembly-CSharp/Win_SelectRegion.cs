public class Win_SelectRegion : global::Common.WindowBase
{
    private class LoopListAdapter<T> : global::UnityEngine.UI.LoopScrollPrefabSource, global::UnityEngine.UI.LoopScrollDataSource
    {
        private readonly Win_SelectRegion owner;
        private readonly global::UnityEngine.Transform root;
        private readonly global::UnityEngine.Transform list;
        private readonly global::UnityEngine.Transform proto;
        private readonly global::System.Action<T, global::UnityEngine.Transform> onBind;
        private readonly global::UnityEngine.UI.LoopScrollRect loopScrollRect;
        private readonly global::System.Collections.Generic.Stack<global::UnityEngine.Transform> pool;
        private global::System.Collections.Generic.IList<T> datas;
        private readonly bool useLoop;
        public bool IsValid => false;
        public bool UseLoop => false;

        public LoopListAdapter(Win_SelectRegion owner, global::UnityEngine.Transform root, global::System.Action<T, global::UnityEngine.Transform> onBind)
        {
        }

        public void Refresh(global::System.Collections.Generic.IList<T> source, int startIndex = 0)
        {
        }

        public global::UnityEngine.GameObject GetObject(int index)
        {
            return null;
        }

        public void ReturnObject(global::UnityEngine.Transform trans)
        {
        }

        public void ProvideData(global::UnityEngine.Transform transform, int idx)
        {
        }
    }

    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform continentList;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.LoopVerticalScrollRect regionList;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnConfirm;
    private NationalData.eNation currentNation;
    private NationalData.eContinent currentContinent;
    private global::System.Action<NationalData.eNation> onSelectAction;
    private Win_SelectRegion.LoopListAdapter<NationalData.eNation> regionLoopAdapter;
    private global::System.Collections.Generic.Dictionary<NationalData.eContinent, global::System.Collections.Generic.List<NationalData.eNation>> continentCountries;
    public void Fill(NationalData.eNation cur, global::System.Action<NationalData.eNation> onSelecter)
    {
    }

    private void InitContinentCountries()
    {
    }

    private void UpdateContinentItem(global::UnityEngine.Transform item, NationalData.eContinent continent)
    {
    }

    private void UpdateRegionItem(global::UnityEngine.Transform item, NationalData.eNation nation)
    {
    }

    private NationalData.eContinent GetFirstAvailableContinent()
    {
        return NationalData.eContinent.None;
    }

    private void RefreshContinentList()
    {
    }

    private void OnSelectContinent(NationalData.eContinent continent)
    {
    }

    private void RefreshRegionList()
    {
    }

    private void OnRegionSelected(NationalData.eNation nation)
    {
    }

    private bool EnsureRegionLoopAdapter()
    {
        return false;
    }

    private void BindRegionItem(NationalData.eNation nation, global::UnityEngine.Transform item)
    {
    }
}
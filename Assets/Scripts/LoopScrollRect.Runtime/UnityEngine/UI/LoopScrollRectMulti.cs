namespace UnityEngine.UI
{
    public abstract class LoopScrollRectMulti : global::UnityEngine.UI.LoopScrollRectBase
    {
        [global::System.NonSerialized]
        [global::UnityEngine.HideInInspector]
        public global::UnityEngine.UI.LoopScrollMultiDataSource dataSource;
        protected override void ProvideData(global::UnityEngine.Transform transform, int index)
        {
        }

        protected override global::UnityEngine.RectTransform GetFromTempPool(int itemIdx)
        {
            return null;
        }

        protected override void ReturnToTempPool(bool fromStart, int count)
        {
        }

        protected override void ClearTempPool()
        {
        }
    }
}
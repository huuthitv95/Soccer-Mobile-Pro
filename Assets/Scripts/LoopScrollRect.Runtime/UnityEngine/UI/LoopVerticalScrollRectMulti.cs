namespace UnityEngine.UI
{
    [global::UnityEngine.DisallowMultipleComponent]
    public class LoopVerticalScrollRectMulti : global::UnityEngine.UI.LoopScrollRectMulti
    {
        protected LoopVerticalScrollRectMulti()
        {
        }

        protected override float GetSize(global::UnityEngine.RectTransform item, bool includeSpacing)
        {
            return 0f;
        }

        protected override float GetDimension(global::UnityEngine.Vector2 vector)
        {
            return 0f;
        }

        protected override float GetAbsDimension(global::UnityEngine.Vector2 vector)
        {
            return 0f;
        }

        protected override global::UnityEngine.Vector2 GetVector(float value)
        {
            return default;
        }

        protected override void Awake()
        {
        }

        protected override bool UpdateItems(ref global::UnityEngine.Bounds viewBounds, ref global::UnityEngine.Bounds contentBounds)
        {
            return false;
        }
    }
}
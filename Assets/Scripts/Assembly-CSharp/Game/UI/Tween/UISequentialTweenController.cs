namespace Game.UI.Tween
{
    [global::UnityEngine.DisallowMultipleComponent]
    public class UISequentialTweenController : global::UnityEngine.MonoBehaviour
    {
        public enum Axis
        {
            X = 0,
            Y = 1
        }

        public global::Game.UI.Tween.UISequentialTweenController.Axis orderAxis;
        public float baseInterval;
        public float neighborThreshold;
        public bool autoPlayOnRebuild;
        public bool deferPlay;
        public bool collectOnAwake;
        public float globalStartDelay;
        public bool assignDelayToTween;
        public bool filterByTypes;
        public global::System.Collections.Generic.List<global::Game.UI.Tween.SequentialTweenItemType> allowedTypes;
        private readonly global::System.Collections.Generic.List<global::Game.UI.Tween.ISequentialTweenItem> _items;
        private bool _dirty;
        private global::UnityEngine.RectTransform _controllerRect;
        private void Awake()
        {
        }

        public void CollectChildren()
        {
        }

        public void Register(global::Game.UI.Tween.ISequentialTweenItem item)
        {
        }

        public void Unregister(global::Game.UI.Tween.ISequentialTweenItem item)
        {
        }

        public void RebuildDelays(float tempGlobalDelay = 0f)
        {
        }

        private float GetAxisLocalValue(global::UnityEngine.RectTransform target, bool secondary = false)
        {
            return 0f;
        }

        public void PlayAll(float tempGlobalDelay = 0f)
        {
        }

        public void StopAll()
        {
        }

        public void CtxRebuildPlay()
        {
        }

        public void CtxRebuildOnly()
        {
        }
    }
}
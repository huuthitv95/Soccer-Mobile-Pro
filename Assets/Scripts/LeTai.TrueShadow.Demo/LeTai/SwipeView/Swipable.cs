namespace LeTai.SwipeView
{
    public abstract class Swipable<TData> : global::UnityEngine.MonoBehaviour
    {
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action<global::UnityEngine.Vector2> m_removed;
        internal global::LeTai.SwipeView.SwipeView<TData> view;
        internal global::UnityEngine.Vector2 snapPosition;
        internal global::UnityEngine.Vector3 snapScale;
        protected bool isSwiping;
        protected bool isSnaping;
        private global::UnityEngine.Coroutine runningSnap;
        private global::UnityEngine.Vector3 currentPosVel;
        private global::UnityEngine.Vector3 currentScaleVel;
        public TData Data { get; protected set; }
        internal global::UnityEngine.RectTransform RectTransform { get; private set; }

        public event global::System.Action<global::UnityEngine.Vector2> removed
        {
            [global::System.Runtime.CompilerServices.CompilerGenerated]
            add
            {
            }

            [global::System.Runtime.CompilerServices.CompilerGenerated]
            remove
            {
            }
        }

        private void Awake()
        {
        }

        protected internal void StartSnap(bool snapOut = false)
        {
        }

        private void DoTilt()
        {
        }

        protected global::System.Collections.IEnumerator Snap(bool snapOut)
        {
            return null;
        }

        public void Swipe(global::UnityEngine.Vector2 offset)
        {
        }

        public abstract void SetData(TData data);
        internal void EndSwipe(global::UnityEngine.Vector2 offset)
        {
        }

        protected virtual void OnRemoved(global::UnityEngine.Vector2 offset)
        {
        }
    }
}
namespace UnityEngine.UI.Extensions
{
    public class ScrollRectTweener : global::UnityEngine.MonoBehaviour, global::UnityEngine.EventSystems.IDragHandler, global::UnityEngine.EventSystems.IEventSystemHandler
    {
        private global::UnityEngine.UI.ScrollRect scrollRect;
        private global::UnityEngine.Vector2 startPos;
        private global::UnityEngine.Vector2 targetPos;
        private bool wasHorizontal;
        private bool wasVertical;
        public float moveSpeed;
        public bool disableDragWhileTweening;
        private void Awake()
        {
        }

        public void ScrollHorizontal(float normalizedX)
        {
        }

        public void ScrollHorizontal(float normalizedX, float duration)
        {
        }

        public void ScrollVertical(float normalizedY)
        {
        }

        public void ScrollVertical(float normalizedY, float duration)
        {
        }

        public void Scroll(global::UnityEngine.Vector2 normalizedPos)
        {
        }

        private float GetScrollDuration(global::UnityEngine.Vector2 normalizedPos)
        {
            return 0f;
        }

        private global::UnityEngine.Vector2 DeNormalize(global::UnityEngine.Vector2 normalizedPos)
        {
            return default;
        }

        private global::UnityEngine.Vector2 GetCurrentPos()
        {
            return default;
        }

        public void Scroll(global::UnityEngine.Vector2 normalizedPos, float duration)
        {
        }

        private global::System.Collections.IEnumerator DoMove(float duration)
        {
            return null;
        }

        public global::UnityEngine.Vector2 EaseVector(float currentTime, global::UnityEngine.Vector2 startValue, global::UnityEngine.Vector2 changeInValue, float duration)
        {
            return default;
        }

        public void OnDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        private void StopScroll()
        {
        }

        private void LockScrollability()
        {
        }

        private void RestoreScrollability()
        {
        }
    }
}
namespace LeTai.TrueShadow
{
    public class AnimatedBiStateButton : global::UnityEngine.MonoBehaviour, global::UnityEngine.EventSystems.IPointerDownHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IPointerUpHandler, global::UnityEngine.EventSystems.IPointerEnterHandler, global::UnityEngine.EventSystems.IPointerExitHandler
    {
        public enum State
        {
            Up = 0,
            AnimateDown = 1,
            Down = 2,
            AnimateUp = 3
        }

        public float animationDuration;
        public global::UnityEngine.AnimationCurve animationCurve;
        public bool useEnterExitEvents;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action m_willPress;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action m_willRelease;
        protected global::LeTai.TrueShadow.AnimatedBiStateButton.State state;
        protected float pressAmount;
        protected bool IsAnimating => false;

        public event global::System.Action willPress
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

        public event global::System.Action willRelease
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

        private void Update()
        {
        }

        private void DoAnimation()
        {
        }

        protected void Press()
        {
        }

        protected void Release()
        {
        }

        private void PollPointerUp()
        {
        }

        protected virtual void Animate(float visualPressAmount)
        {
        }

        public void OnPointerDown(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public void OnPointerUp(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public void OnPointerEnter(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public void OnPointerExit(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        protected virtual void OnWillPress()
        {
        }

        protected virtual void OnWillRelease()
        {
        }
    }
}
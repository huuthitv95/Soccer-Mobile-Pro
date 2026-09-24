namespace UnityEngine.UI
{
    [global::UnityEngine.SelectionBase]
    [global::UnityEngine.DisallowMultipleComponent]
    public class Selectable : global::UnityEngine.EventSystems.UIBehaviour, global::UnityEngine.EventSystems.IMoveHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IPointerDownHandler, global::UnityEngine.EventSystems.IPointerUpHandler, global::UnityEngine.EventSystems.IPointerEnterHandler, global::UnityEngine.EventSystems.IPointerExitHandler, global::UnityEngine.EventSystems.ISelectHandler, global::UnityEngine.EventSystems.IDeselectHandler
    {
        public enum Transition
        {
            None = 0,
            ColorTint = 1,
            SpriteSwap = 2,
            Animation = 3
        }

        protected enum SelectionState
        {
            Normal = 0,
            Highlighted = 1,
            Pressed = 2,
            Selected = 3,
            Disabled = 4
        }

        protected static global::UnityEngine.UI.Selectable[] s_Selectables;
        protected static int s_SelectableCount;
        private bool m_EnableCalled;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Navigation m_Navigation;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Selectable.Transition m_Transition;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.ColorBlock m_Colors;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.SpriteState m_SpriteState;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.AnimationTriggers m_AnimationTriggers;
        [global::UnityEngine.SerializeField]
        private bool m_Interactable;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Graphic m_TargetGraphic;
        private bool m_GroupsAllowInteraction;
        protected int m_CurrentIndex;
        private readonly global::System.Collections.Generic.List<global::UnityEngine.CanvasGroup> m_CanvasGroupCache;
        public static global::UnityEngine.UI.Selectable[] allSelectablesArray => null;
        public static int allSelectableCount => 0;

        [global::System.Obsolete]
        public static global::System.Collections.Generic.List<global::UnityEngine.UI.Selectable> allSelectables => null;

        public global::UnityEngine.UI.Navigation navigation
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.Selectable.Transition transition
        {
            get
            {
                return global::UnityEngine.UI.Selectable.Transition.None;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.ColorBlock colors
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.SpriteState spriteState
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.AnimationTriggers animationTriggers
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.Graphic targetGraphic
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public bool interactable
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        private bool isPointerInside { get; set; }
        private bool isPointerDown { get; set; }
        private bool hasSelection { get; set; }

        public global::UnityEngine.UI.Image image
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.Animator animator => null;
        protected global::UnityEngine.UI.Selectable.SelectionState currentSelectionState => global::UnityEngine.UI.Selectable.SelectionState.Normal;

        public static int AllSelectablesNoAlloc(global::UnityEngine.UI.Selectable[] selectables)
        {
            return 0;
        }

        protected Selectable()
        {
        }

        protected override void Awake()
        {
        }

        protected override void OnCanvasGroupChanged()
        {
        }

        private bool ParentGroupAllowsInteraction()
        {
            return false;
        }

        public virtual bool IsInteractable()
        {
            return false;
        }

        protected override void OnDidApplyAnimationProperties()
        {
        }

        protected override void OnEnable()
        {
        }

        protected override void OnTransformParentChanged()
        {
        }

        private void OnSetProperty()
        {
        }

        protected override void OnDisable()
        {
        }

        protected virtual void InstantClearState()
        {
        }

        protected virtual void DoStateTransition(global::UnityEngine.UI.Selectable.SelectionState state, bool instant)
        {
        }

        public global::UnityEngine.UI.Selectable FindSelectable(global::UnityEngine.Vector3 dir)
        {
            return null;
        }

        private static global::UnityEngine.Vector3 GetPointOnRectEdge(global::UnityEngine.RectTransform rect, global::UnityEngine.Vector2 dir)
        {
            return default;
        }

        private void Navigate(global::UnityEngine.EventSystems.AxisEventData eventData, global::UnityEngine.UI.Selectable sel)
        {
        }

        public virtual global::UnityEngine.UI.Selectable FindSelectableOnLeft()
        {
            return null;
        }

        public virtual global::UnityEngine.UI.Selectable FindSelectableOnRight()
        {
            return null;
        }

        public virtual global::UnityEngine.UI.Selectable FindSelectableOnUp()
        {
            return null;
        }

        public virtual global::UnityEngine.UI.Selectable FindSelectableOnDown()
        {
            return null;
        }

        public virtual void OnMove(global::UnityEngine.EventSystems.AxisEventData eventData)
        {
        }

        private void StartColorTween(global::UnityEngine.Color targetColor, bool instant)
        {
        }

        private void DoSpriteSwap(global::UnityEngine.Sprite newSprite)
        {
        }

        private void TriggerAnimation(string triggername)
        {
        }

        protected bool IsHighlighted()
        {
            return false;
        }

        protected bool IsPressed()
        {
            return false;
        }

        private void EvaluateAndTransitionToSelectionState()
        {
        }

        public virtual void OnPointerDown(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public virtual void OnPointerUp(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public virtual void OnPointerEnter(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public virtual void OnPointerExit(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public virtual void OnSelect(global::UnityEngine.EventSystems.BaseEventData eventData)
        {
        }

        public virtual void OnDeselect(global::UnityEngine.EventSystems.BaseEventData eventData)
        {
        }

        public virtual void Select()
        {
        }
    }
}
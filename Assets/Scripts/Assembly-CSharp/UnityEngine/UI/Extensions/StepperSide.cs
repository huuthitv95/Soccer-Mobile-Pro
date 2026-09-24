namespace UnityEngine.UI.Extensions
{
    public class StepperSide : global::UnityEngine.EventSystems.UIBehaviour, global::UnityEngine.EventSystems.IPointerClickHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.ISubmitHandler
    {
        private global::UnityEngine.UI.Selectable button => null;
        private global::UnityEngine.UI.Extensions.Stepper stepper => null;
        private bool leftmost => false;

        protected StepperSide()
        {
        }

        public virtual void OnPointerClick(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public virtual void OnSubmit(global::UnityEngine.EventSystems.BaseEventData eventData)
        {
        }

        private void Press()
        {
        }
    }
}
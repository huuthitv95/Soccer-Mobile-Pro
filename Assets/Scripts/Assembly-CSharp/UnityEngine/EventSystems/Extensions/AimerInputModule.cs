namespace UnityEngine.EventSystems.Extensions
{
    public class AimerInputModule : global::UnityEngine.EventSystems.PointerInputModule
    {
        public string activateAxis;
        public global::UnityEngine.Vector2 aimerOffset;
        public static global::UnityEngine.GameObject objectUnderAimer;
        protected AimerInputModule()
        {
        }

        public override void ActivateModule()
        {
        }

        public override void Process()
        {
        }

        protected virtual global::UnityEngine.EventSystems.PointerEventData GetAimerPointerEventData()
        {
            return null;
        }

        private void ProcessInteraction(global::UnityEngine.EventSystems.PointerEventData pointer, bool pressed, bool released)
        {
        }

        public override void DeactivateModule()
        {
        }
    }
}
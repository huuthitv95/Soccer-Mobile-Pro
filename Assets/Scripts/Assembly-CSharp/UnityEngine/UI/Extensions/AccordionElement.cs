namespace UnityEngine.UI.Extensions
{
    public class AccordionElement : global::UnityEngine.UI.Toggle
    {
        [global::UnityEngine.SerializeField]
        private float m_MinHeight;
        private global::UnityEngine.UI.Extensions.Accordion m_Accordion;
        private global::UnityEngine.RectTransform m_RectTransform;
        private global::UnityEngine.UI.LayoutElement m_LayoutElement;
        [global::System.NonSerialized]
        private readonly global::UnityEngine.UI.Extensions.Tweens.TweenRunner<global::UnityEngine.UI.Extensions.Tweens.FloatTween> m_FloatTweenRunner;
        protected AccordionElement()
        {
        }

        protected override void Awake()
        {
        }

        public void OnValueChanged(bool state)
        {
        }

        protected float GetExpandedHeight()
        {
            return 0f;
        }

        protected void StartTween(float startFloat, float targetFloat)
        {
        }

        protected void SetHeight(float height)
        {
        }
    }
}
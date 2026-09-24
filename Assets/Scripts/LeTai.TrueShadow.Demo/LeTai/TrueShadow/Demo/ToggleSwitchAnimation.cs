namespace LeTai.TrueShadow.Demo
{
    public class ToggleSwitchAnimation : global::UnityEngine.MonoBehaviour
    {
        public global::UnityEngine.Color onColor;
        public global::UnityEngine.Color offColor;
        public global::UnityEngine.UI.Graphic background;
        public global::UnityEngine.RectTransform handle;
        public float handleInset;
        public float transitionDuration;
        private global::UnityEngine.Coroutine anim;
        private void Start()
        {
        }

        private global::System.Collections.IEnumerator Animate(float fromX, global::UnityEngine.Color fromColor)
        {
            return null;
        }

        public void Toggle(bool isOn)
        {
        }
    }
}
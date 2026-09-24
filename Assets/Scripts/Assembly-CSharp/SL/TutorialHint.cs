namespace SL
{
    public class TutorialHint : global::UnityEngine.MonoBehaviour
    {
        public enum HintType
        {
            None = -1,
            Normal = 0,
            Item = 1,
            Zoom = 2,
            SlideCamera = 3
        }

        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.CanvasScaler canvasScaler;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.RectTransform hint2D;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.GameObject hint2DZoom;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.GameObject hint2DSlide;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.TrailRenderer trail;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Camera uiCamera;
        private global::UnityEngine.RectTransform gameview;
        private global::UnityEngine.Vector3 hintOriginalPos;
        public global::System.Action OnAnimCycleEndAction;
        public global::SL.TutorialHint.HintType Type { get; set; }
        public float Curve { private get; set; }
        public bool ShowHand => false;
        public float HintDelay { get; set; }

        private void Start()
        {
        }

        private void Update()
        {
        }

        private void OnDisable()
        {
        }

        public void OnResetTrail()
        {
        }

        public void OnAnimCycleEnd()
        {
        }

        public void OnActiveHint()
        {
        }

        public void ShowArrow(global::UnityEngine.Vector3 start, global::UnityEngine.Vector3 end, float curve)
        {
        }

        public void ShowClick(global::UnityEngine.Vector3 pos)
        {
        }

        public void HideTutorial()
        {
        }
    }
}
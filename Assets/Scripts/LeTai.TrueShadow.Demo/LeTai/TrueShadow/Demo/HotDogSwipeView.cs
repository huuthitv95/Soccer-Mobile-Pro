namespace LeTai.TrueShadow.Demo
{
    public class HotDogSwipeView : global::LeTai.SwipeView.LeftRightSwipeView<global::LeTai.TrueShadow.Demo.HotDogSprite>
    {
        public global::UnityEngine.Sprite[] hotdogs;
        public global::UnityEngine.Sprite[] notHotdogs;
        public global::LeTai.TrueShadow.Demo.GradientSlider goodnessSlider;
        private float goodness;
        protected override void Start()
        {
        }

        private void Update()
        {
        }

        private void AddGoodness(float amount)
        {
        }

        private void OnSwipeToDirection(global::LeTai.SwipeView.SwipeDirection direction)
        {
        }

        private global::System.Collections.Generic.IEnumerable<global::LeTai.TrueShadow.Demo.HotDogSprite> RandomSprites()
        {
            return null;
        }
    }
}
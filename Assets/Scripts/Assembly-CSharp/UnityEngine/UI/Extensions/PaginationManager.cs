namespace UnityEngine.UI.Extensions
{
    public class PaginationManager : global::UnityEngine.UI.ToggleGroup
    {
        private global::System.Collections.Generic.List<global::UnityEngine.UI.Toggle> m_PaginationChildren;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Extensions.ScrollSnapBase scrollSnap;
        private bool isAClick;
        public int CurrentPage => 0;

        protected PaginationManager()
        {
        }

        protected override void Start()
        {
        }

        public void Init()
        {
        }

        public void GoToScreen(int pageNo)
        {
        }

        private void ToggleClick(global::UnityEngine.UI.Toggle target)
        {
        }

        private void ToggleClick(bool toggle)
        {
        }

        private void ToggleClick(int target)
        {
        }

        private void SetToggleGraphics(int pageNo)
        {
        }

        private void OnPageChangeEnd(int pageNo)
        {
        }
    }
}
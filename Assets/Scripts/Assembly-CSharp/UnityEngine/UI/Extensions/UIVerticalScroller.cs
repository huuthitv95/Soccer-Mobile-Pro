namespace UnityEngine.UI.Extensions
{
    public class UIVerticalScroller : global::UnityEngine.MonoBehaviour
    {
        public global::UnityEngine.RectTransform _scrollingPanel;
        public global::UnityEngine.GameObject[] _arrayOfElements;
        public global::UnityEngine.RectTransform _center;
        public int StartingIndex;
        public global::UnityEngine.GameObject ScrollUpButton;
        public global::UnityEngine.GameObject ScrollDownButton;
        public global::UnityEngine.Events.UnityEvent<int> ButtonClicked;
        private float[] distReposition;
        private float[] distance;
        private int minElementsNum;
        private int elementLength;
        private float deltaY;
        private string result;
        public UIVerticalScroller()
        {
        }

        public UIVerticalScroller(global::UnityEngine.RectTransform scrollingPanel, global::UnityEngine.GameObject[] arrayOfElements, global::UnityEngine.RectTransform center)
        {
        }

        public void Awake()
        {
        }

        public void Start()
        {
        }

        private void AddListener(global::UnityEngine.GameObject button, int index)
        {
        }

        private void DoSomething(int index)
        {
        }

        public void Update()
        {
        }

        private void ScrollingElements(float position)
        {
        }

        public string GetResults()
        {
            return null;
        }

        public void SnapToElement(int element)
        {
        }

        public void ScrollUp()
        {
        }

        public void ScrollDown()
        {
        }
    }
}
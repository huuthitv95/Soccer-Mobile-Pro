namespace UnityEngine.UI.Extensions
{
    public class ExampleSelectable : global::UnityEngine.MonoBehaviour, global::UnityEngine.UI.Extensions.IBoxSelectable
    {
        private bool _selected;
        private bool _preSelected;
        private global::UnityEngine.SpriteRenderer spriteRenderer;
        private global::UnityEngine.UI.Image image;
        private global::UnityEngine.UI.Text text;
        public bool selected
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool preSelected
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        global::UnityEngine.Transform global::UnityEngine.UI.Extensions.IBoxSelectable.transform => null;

        private void Start()
        {
        }

        private void Update()
        {
        }
    }
}
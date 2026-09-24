namespace UnityEngine.UI.Extensions
{
    public class ShineEffector : global::UnityEngine.MonoBehaviour
    {
        public global::UnityEngine.UI.Extensions.ShineEffect effector;
        [global::UnityEngine.SerializeField]
        [global::UnityEngine.HideInInspector]
        private global::UnityEngine.GameObject effectRoot;
        public float yOffset;
        public float width;
        private global::UnityEngine.RectTransform effectorRect;
        public float YOffset
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        private void OnEnable()
        {
        }

        private void OnValidate()
        {
        }

        private void ChangeVal(float value)
        {
        }

        private void OnDestroy()
        {
        }
    }
}
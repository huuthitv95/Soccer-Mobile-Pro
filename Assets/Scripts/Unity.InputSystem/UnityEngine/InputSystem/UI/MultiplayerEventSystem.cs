namespace UnityEngine.InputSystem.UI
{
    public class MultiplayerEventSystem : global::UnityEngine.EventSystems.EventSystem
    {
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.GameObject m_PlayerRoot;
        public global::UnityEngine.GameObject playerRoot
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        private void InitializePlayerRoot()
        {
        }

        protected override void Update()
        {
        }
    }
}
namespace UnityEngine.UI.Extensions
{
    public class CooldownButton : global::UnityEngine.MonoBehaviour, global::UnityEngine.EventSystems.IPointerDownHandler, global::UnityEngine.EventSystems.IEventSystemHandler
    {
        [global::System.Serializable]
        public class CooldownButtonEvent : global::UnityEngine.Events.UnityEvent<global::UnityEngine.EventSystems.PointerEventData.InputButton>
        {
        }

        [global::UnityEngine.SerializeField]
        private float cooldownTimeout;
        [global::UnityEngine.SerializeField]
        private float cooldownSpeed;
        [global::UnityEngine.UI.Extensions.ReadOnly]
        [global::UnityEngine.SerializeField]
        private bool cooldownActive;
        [global::UnityEngine.UI.Extensions.ReadOnly]
        [global::UnityEngine.SerializeField]
        private bool cooldownInEffect;
        [global::UnityEngine.SerializeField]
        [global::UnityEngine.UI.Extensions.ReadOnly]
        private float cooldownTimeElapsed;
        [global::UnityEngine.UI.Extensions.ReadOnly]
        [global::UnityEngine.SerializeField]
        private float cooldownTimeRemaining;
        [global::UnityEngine.SerializeField]
        [global::UnityEngine.UI.Extensions.ReadOnly]
        private int cooldownPercentRemaining;
        [global::UnityEngine.SerializeField]
        [global::UnityEngine.UI.Extensions.ReadOnly]
        private int cooldownPercentComplete;
        private global::UnityEngine.EventSystems.PointerEventData buttonSource;
        public global::UnityEngine.UI.Extensions.CooldownButton.CooldownButtonEvent OnCooldownStart;
        public global::UnityEngine.UI.Extensions.CooldownButton.CooldownButtonEvent OnButtonClickDuringCooldown;
        public global::UnityEngine.UI.Extensions.CooldownButton.CooldownButtonEvent OnCoolDownFinish;
        public float CooldownTimeout
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float CooldownSpeed
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public bool CooldownInEffect => false;

        public bool CooldownActive
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public float CooldownTimeElapsed
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public float CooldownTimeRemaining => 0f;
        public int CooldownPercentRemaining => 0;
        public int CooldownPercentComplete => 0;

        private void Update()
        {
        }

        public void PauseCooldown()
        {
        }

        public void RestartCooldown()
        {
        }

        public void StopCooldown()
        {
        }

        public void CancelCooldown()
        {
        }

        void global::UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }
    }
}
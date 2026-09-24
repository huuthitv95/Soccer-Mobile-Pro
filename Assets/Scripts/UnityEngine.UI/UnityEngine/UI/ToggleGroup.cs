namespace UnityEngine.UI
{
    [global::UnityEngine.DisallowMultipleComponent]
    public class ToggleGroup : global::UnityEngine.EventSystems.UIBehaviour
    {
        [global::UnityEngine.SerializeField]
        private bool m_AllowSwitchOff;
        protected global::System.Collections.Generic.List<global::UnityEngine.UI.Toggle> m_Toggles;
        public bool allowSwitchOff
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        protected ToggleGroup()
        {
        }

        protected override void Start()
        {
        }

        protected override void OnEnable()
        {
        }

        private void ValidateToggleIsInGroup(global::UnityEngine.UI.Toggle toggle)
        {
        }

        public void NotifyToggleOn(global::UnityEngine.UI.Toggle toggle, bool sendCallback = true)
        {
        }

        public void UnregisterToggle(global::UnityEngine.UI.Toggle toggle)
        {
        }

        public void RegisterToggle(global::UnityEngine.UI.Toggle toggle)
        {
        }

        public void EnsureValidState()
        {
        }

        public bool AnyTogglesOn()
        {
            return false;
        }

        public global::System.Collections.Generic.IEnumerable<global::UnityEngine.UI.Toggle> ActiveToggles()
        {
            return null;
        }

        public global::UnityEngine.UI.Toggle GetFirstActiveToggle()
        {
            return null;
        }

        public void SetAllTogglesOff(bool sendCallback = true)
        {
        }
    }
}
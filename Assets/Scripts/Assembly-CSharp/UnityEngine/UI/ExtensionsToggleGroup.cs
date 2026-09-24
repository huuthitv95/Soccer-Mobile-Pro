namespace UnityEngine.UI
{
    [global::UnityEngine.DisallowMultipleComponent]
    public class ExtensionsToggleGroup : global::UnityEngine.EventSystems.UIBehaviour
    {
        [global::System.Serializable]
        public class ToggleGroupEvent : global::UnityEngine.Events.UnityEvent<bool>
        {
        }

        [global::UnityEngine.SerializeField]
        private bool m_AllowSwitchOff;
        private global::System.Collections.Generic.List<global::UnityEngine.UI.ExtensionsToggle> m_Toggles;
        public global::UnityEngine.UI.ExtensionsToggleGroup.ToggleGroupEvent onToggleGroupChanged;
        public global::UnityEngine.UI.ExtensionsToggleGroup.ToggleGroupEvent onToggleGroupToggleChanged;
        public bool AllowSwitchOff
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.ExtensionsToggle SelectedToggle { get; private set; }

        protected ExtensionsToggleGroup()
        {
        }

        private void ValidateToggleIsInGroup(global::UnityEngine.UI.ExtensionsToggle toggle)
        {
        }

        public void NotifyToggleOn(global::UnityEngine.UI.ExtensionsToggle toggle)
        {
        }

        public void UnregisterToggle(global::UnityEngine.UI.ExtensionsToggle toggle)
        {
        }

        private void NotifyToggleChanged(bool isOn)
        {
        }

        public void RegisterToggle(global::UnityEngine.UI.ExtensionsToggle toggle)
        {
        }

        public bool AnyTogglesOn()
        {
            return false;
        }

        public global::System.Collections.Generic.IEnumerable<global::UnityEngine.UI.ExtensionsToggle> ActiveToggles()
        {
            return null;
        }

        public void SetAllTogglesOff()
        {
        }

        public void HasTheGroupToggle(bool value)
        {
        }

        public void HasAToggleFlipped(bool value)
        {
        }
    }
}
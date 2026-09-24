namespace UnityEngine.InputSystem.Controls
{
    public class KeyControl : global::UnityEngine.InputSystem.Controls.ButtonControl
    {
        private int m_ScanCode;
        public global::UnityEngine.InputSystem.Key keyCode { get; set; }
        public int scanCode => 0;

        protected override void RefreshConfiguration()
        {
        }
    }
}
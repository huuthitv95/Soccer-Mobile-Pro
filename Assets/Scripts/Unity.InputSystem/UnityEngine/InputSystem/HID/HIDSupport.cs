namespace UnityEngine.InputSystem.HID
{
    public static class HIDSupport
    {
        public struct HIDPageUsage
        {
            public global::UnityEngine.InputSystem.HID.HID.UsagePage page;
            public int usage;
            public HIDPageUsage(global::UnityEngine.InputSystem.HID.HID.UsagePage page, int usage)
            {
                this.page = global::UnityEngine.InputSystem.HID.HID.UsagePage.Undefined;
                this.usage = 0;
            }

            public HIDPageUsage(global::UnityEngine.InputSystem.HID.HID.GenericDesktop usage)
            {
                page = global::UnityEngine.InputSystem.HID.HID.UsagePage.Undefined;
                this.usage = 0;
            }
        }

        private static global::UnityEngine.InputSystem.HID.HIDSupport.HIDPageUsage[] s_SupportedHIDUsages;
        public static global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<global::UnityEngine.InputSystem.HID.HIDSupport.HIDPageUsage> supportedHIDUsages
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        internal static void Initialize()
        {
        }
    }
}
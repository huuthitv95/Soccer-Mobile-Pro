namespace UnityEngine.InputSystem.Layouts
{
    internal struct InputDeviceBuilder : global::System.IDisposable
    {
        [global::System.Runtime.InteropServices.StructLayout((global::System.Runtime.InteropServices.LayoutKind)0, Size = 1)]
        internal struct RefInstance : global::System.IDisposable
        {
            public void Dispose()
            {
            }
        }

        private global::UnityEngine.InputSystem.InputDevice m_Device;
        private global::UnityEngine.InputSystem.Layouts.InputControlLayout.CacheRefInstance m_LayoutCacheRef;
        private global::System.Collections.Generic.Dictionary<string, global::UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem> m_ChildControlOverrides;
        private global::System.Collections.Generic.List<uint> m_StateOffsetToControlMap;
        private global::System.Text.StringBuilder m_StringBuilder;
        private const uint kSizeForControlUsingStateFromOtherControl = uint.MaxValue;
        private static global::UnityEngine.InputSystem.Layouts.InputDeviceBuilder s_Instance;
        private static int s_InstanceRef;
        internal static ref global::UnityEngine.InputSystem.Layouts.InputDeviceBuilder instance
        {
            get
            {
                throw null;
            }
        }

        public void Setup(global::UnityEngine.InputSystem.Utilities.InternedString layout, global::UnityEngine.InputSystem.Utilities.InternedString variants, global::UnityEngine.InputSystem.Layouts.InputDeviceDescription deviceDescription = default(global::UnityEngine.InputSystem.Layouts.InputDeviceDescription))
        {
        }

        public global::UnityEngine.InputSystem.InputDevice Finish()
        {
            return null;
        }

        public void Dispose()
        {
        }

        private void Reset()
        {
        }

        private global::UnityEngine.InputSystem.InputControl InstantiateLayout(global::UnityEngine.InputSystem.Utilities.InternedString layout, global::UnityEngine.InputSystem.Utilities.InternedString variants, global::UnityEngine.InputSystem.Utilities.InternedString name, global::UnityEngine.InputSystem.InputControl parent)
        {
            return null;
        }

        private global::UnityEngine.InputSystem.InputControl InstantiateLayout(global::UnityEngine.InputSystem.Layouts.InputControlLayout layout, global::UnityEngine.InputSystem.Utilities.InternedString variants, global::UnityEngine.InputSystem.Utilities.InternedString name, global::UnityEngine.InputSystem.InputControl parent)
        {
            return null;
        }

        private void AddChildControls(global::UnityEngine.InputSystem.Layouts.InputControlLayout layout, global::UnityEngine.InputSystem.Utilities.InternedString variants, global::UnityEngine.InputSystem.InputControl parent, ref bool haveChildrenUsingStateFromOtherControls)
        {
        }

        private global::UnityEngine.InputSystem.InputControl AddChildControl(global::UnityEngine.InputSystem.Layouts.InputControlLayout layout, global::UnityEngine.InputSystem.Utilities.InternedString variants, global::UnityEngine.InputSystem.InputControl parent, ref bool haveChildrenUsingStateFromOtherControls, global::UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem controlItem, int childIndex, string nameOverride = null)
        {
            return null;
        }

        private void InsertChildControlOverride(global::UnityEngine.InputSystem.InputControl parent, ref global::UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem controlItem)
        {
        }

        private string ChildControlOverridePath(global::UnityEngine.InputSystem.InputControl parent, global::UnityEngine.InputSystem.Utilities.InternedString controlName)
        {
            return null;
        }

        private void AddChildControlIfMissing(global::UnityEngine.InputSystem.Layouts.InputControlLayout layout, global::UnityEngine.InputSystem.Utilities.InternedString variants, global::UnityEngine.InputSystem.InputControl parent, ref bool haveChildrenUsingStateFromOtherControls, ref global::UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem controlItem)
        {
        }

        private global::UnityEngine.InputSystem.InputControl InsertChildControl(global::UnityEngine.InputSystem.Layouts.InputControlLayout layout, global::UnityEngine.InputSystem.Utilities.InternedString variant, global::UnityEngine.InputSystem.InputControl parent, ref bool haveChildrenUsingStateFromOtherControls, ref global::UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem controlItem)
        {
            return null;
        }

        private static void ApplyUseStateFrom(global::UnityEngine.InputSystem.InputControl parent, ref global::UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem controlItem, global::UnityEngine.InputSystem.Layouts.InputControlLayout layout)
        {
        }

        private static void ShiftChildIndicesInHierarchyOneUp(global::UnityEngine.InputSystem.InputDevice device, int startIndex, global::UnityEngine.InputSystem.InputControl exceptControl)
        {
        }

        private void SetDisplayName(global::UnityEngine.InputSystem.InputControl control, string longDisplayNameFromLayout, string shortDisplayNameFromLayout, bool shortName)
        {
        }

        private static void AddParentDisplayNameRecursive(global::UnityEngine.InputSystem.InputControl control, global::System.Text.StringBuilder stringBuilder, bool shortName)
        {
        }

        private static void AddProcessors(global::UnityEngine.InputSystem.InputControl control, ref global::UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem controlItem, string layoutName)
        {
        }

        private static void SetFormat(global::UnityEngine.InputSystem.InputControl control, global::UnityEngine.InputSystem.Layouts.InputControlLayout.ControlItem controlItem)
        {
        }

        private static global::UnityEngine.InputSystem.Layouts.InputControlLayout FindOrLoadLayout(string name)
        {
            return null;
        }

        private static void ComputeStateLayout(global::UnityEngine.InputSystem.InputControl control)
        {
        }

        private void FinalizeControlHierarchy()
        {
        }

        private void FinalizeControlHierarchyRecursive(global::UnityEngine.InputSystem.InputControl control, int controlIndex, global::UnityEngine.InputSystem.InputControl[] allControls, bool noisy, bool dontReset, ref int controlIndiciesNextFreeIndex)
        {
        }

        private void InsertControlBitRangeNode(ref global::UnityEngine.InputSystem.InputDevice.ControlBitRangeNode parent, global::UnityEngine.InputSystem.InputControl control, ref int controlIndiciesNextFreeIndex, ushort startOffset)
        {
        }

        private ushort GetBestMidPoint(global::UnityEngine.InputSystem.InputDevice.ControlBitRangeNode parent, ushort startOffset)
        {
            return 0;
        }

        private void AddControlToNode(global::UnityEngine.InputSystem.InputControl control, ref int controlIndiciesNextFreeIndex, int nodeIndex)
        {
        }

        private void AddChildren(ref global::UnityEngine.InputSystem.InputDevice.ControlBitRangeNode parent, global::UnityEngine.InputSystem.InputDevice.ControlBitRangeNode left, global::UnityEngine.InputSystem.InputDevice.ControlBitRangeNode right)
        {
        }

        private ushort GetControlIndex(global::UnityEngine.InputSystem.InputControl control)
        {
            return 0;
        }

        internal static global::UnityEngine.InputSystem.Layouts.InputDeviceBuilder.RefInstance Ref()
        {
            return default;
        }
    }
}
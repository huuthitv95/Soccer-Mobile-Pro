namespace UnityEngine.InputSystem
{
    public static class InputActionRebindingExtensions
    {
        internal struct Parameter
        {
            public object instance;
            public global::System.Reflection.FieldInfo field;
            public int bindingIndex;
        }

        private struct ParameterEnumerable : global::System.Collections.Generic.IEnumerable<global::UnityEngine.InputSystem.InputActionRebindingExtensions.Parameter>, global::System.Collections.IEnumerable
        {
            private global::UnityEngine.InputSystem.InputActionState m_State;
            private global::UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride m_Parameter;
            private int m_MapIndex;
            public ParameterEnumerable(global::UnityEngine.InputSystem.InputActionState state, global::UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride parameter, int mapIndex = -1)
            {
                m_State = null;
                m_Parameter = default;
                m_MapIndex = 0;
            }

            public global::UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterEnumerator GetEnumerator()
            {
                return default;
            }

            global::System.Collections.Generic.IEnumerator<global::UnityEngine.InputSystem.InputActionRebindingExtensions.Parameter> global::System.Collections.Generic.IEnumerable<global::UnityEngine.InputSystem.InputActionRebindingExtensions.Parameter>.GetEnumerator()
            {
                return null;
            }

            global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
            {
                return null;
            }
        }

        private struct ParameterEnumerator : global::System.Collections.Generic.IEnumerator<global::UnityEngine.InputSystem.InputActionRebindingExtensions.Parameter>, global::System.Collections.IEnumerator, global::System.IDisposable
        {
            private global::UnityEngine.InputSystem.InputActionState m_State;
            private int m_MapIndex;
            private int m_BindingCurrentIndex;
            private int m_BindingEndIndex;
            private int m_InteractionCurrentIndex;
            private int m_InteractionEndIndex;
            private int m_ProcessorCurrentIndex;
            private int m_ProcessorEndIndex;
            private global::UnityEngine.InputSystem.InputBinding m_BindingMask;
            private global::System.Type m_ObjectType;
            private string m_ParameterName;
            private bool m_MayBeInteraction;
            private bool m_MayBeProcessor;
            private bool m_MayBeComposite;
            private bool m_CurrentBindingIsComposite;
            private object m_CurrentObject;
            private global::System.Reflection.FieldInfo m_CurrentParameter;
            public global::UnityEngine.InputSystem.InputActionRebindingExtensions.Parameter Current => default;

            object global::System.Collections.IEnumerator.Current => null;

            public ParameterEnumerator(global::UnityEngine.InputSystem.InputActionState state, global::UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride parameter, int mapIndex = -1)
            {
                m_State = null;
                m_MapIndex = 0;
                m_BindingCurrentIndex = 0;
                m_BindingEndIndex = 0;
                m_InteractionCurrentIndex = 0;
                m_InteractionEndIndex = 0;
                m_ProcessorCurrentIndex = 0;
                m_ProcessorEndIndex = 0;
                m_BindingMask = default;
                m_ObjectType = null;
                m_ParameterName = null;
                m_MayBeInteraction = false;
                m_MayBeProcessor = false;
                m_MayBeComposite = false;
                m_CurrentBindingIsComposite = false;
                m_CurrentObject = null;
                m_CurrentParameter = null;
            }

            private bool MoveToNextBinding()
            {
                return false;
            }

            private bool MoveToNextInteraction()
            {
                return false;
            }

            private bool MoveToNextProcessor()
            {
                return false;
            }

            private bool FindParameter(object instance)
            {
                return false;
            }

            public bool MoveNext()
            {
                return false;
            }

            public void Reset()
            {
            }

            public void Dispose()
            {
            }
        }

        internal struct ParameterOverride
        {
            public string objectRegistrationName;
            public string parameter;
            public global::UnityEngine.InputSystem.InputBinding bindingMask;
            public global::UnityEngine.InputSystem.Utilities.PrimitiveValue value;
            public global::System.Type objectType => null;

            public ParameterOverride(string parameterName, global::UnityEngine.InputSystem.InputBinding bindingMask, global::UnityEngine.InputSystem.Utilities.PrimitiveValue value = default(global::UnityEngine.InputSystem.Utilities.PrimitiveValue))
            {
                objectRegistrationName = null;
                parameter = null;
                this.bindingMask = default;
                this.value = default;
            }

            public ParameterOverride(string objectRegistrationName, string parameterName, global::UnityEngine.InputSystem.InputBinding bindingMask, global::UnityEngine.InputSystem.Utilities.PrimitiveValue value = default(global::UnityEngine.InputSystem.Utilities.PrimitiveValue))
            {
                this.objectRegistrationName = null;
                parameter = null;
                this.bindingMask = default;
                this.value = default;
            }

            public static global::UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride? Find(global::UnityEngine.InputSystem.InputActionMap actionMap, ref global::UnityEngine.InputSystem.InputBinding binding, string parameterName, string objectRegistrationName)
            {
                return null;
            }

            private static global::UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride? Find(global::UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride[] overrides, int overrideCount, ref global::UnityEngine.InputSystem.InputBinding binding, string parameterName, string objectRegistrationName)
            {
                return null;
            }

            private static global::UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride? PickMoreSpecificOne(global::UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride? first, global::UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride? second)
            {
                return null;
            }
        }

        public sealed class RebindingOperation : global::System.IDisposable
        {
            [global::System.Flags]
            private enum Flags
            {
                Started = 1,
                Completed = 2,
                Canceled = 4,
                OnEventHooked = 8,
                OnAfterUpdateHooked = 0x10,
                DontIgnoreNoisyControls = 0x40,
                DontGeneralizePathOfSelectedControl = 0x80,
                AddNewBinding = 0x100,
                SuppressMatchingEvents = 0x200
            }

            public const float kDefaultMagnitudeThreshold = 0.2f;
            private global::UnityEngine.InputSystem.InputAction m_ActionToRebind;
            private global::UnityEngine.InputSystem.InputBinding? m_BindingMask;
            private global::System.Type m_ControlType;
            private global::UnityEngine.InputSystem.Utilities.InternedString m_ExpectedLayout;
            private int m_IncludePathCount;
            private string[] m_IncludePaths;
            private int m_ExcludePathCount;
            private string[] m_ExcludePaths;
            private int m_TargetBindingIndex;
            private string m_BindingGroupForNewBinding;
            private string m_CancelBinding;
            private float m_MagnitudeThreshold;
            private float[] m_Scores;
            private float[] m_Magnitudes;
            private double m_LastMatchTime;
            private double m_StartTime;
            private float m_Timeout;
            private float m_WaitSecondsAfterMatch;
            private global::UnityEngine.InputSystem.InputControlList<global::UnityEngine.InputSystem.InputControl> m_Candidates;
            private global::System.Action<global::UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation> m_OnComplete;
            private global::System.Action<global::UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation> m_OnCancel;
            private global::System.Action<global::UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation> m_OnPotentialMatch;
            private global::System.Func<global::UnityEngine.InputSystem.InputControl, string> m_OnGeneratePath;
            private global::System.Func<global::UnityEngine.InputSystem.InputControl, global::UnityEngine.InputSystem.LowLevel.InputEventPtr, float> m_OnComputeScore;
            private global::System.Action<global::UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation, string> m_OnApplyBinding;
            private global::System.Action<global::UnityEngine.InputSystem.LowLevel.InputEventPtr, global::UnityEngine.InputSystem.InputDevice> m_OnEventDelegate;
            private global::System.Action m_OnAfterUpdateDelegate;
            private global::UnityEngine.InputSystem.Layouts.InputControlLayout.Cache m_LayoutCache;
            private global::System.Text.StringBuilder m_PathBuilder;
            private global::UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation.Flags m_Flags;
            private global::System.Collections.Generic.Dictionary<global::UnityEngine.InputSystem.InputControl, float> m_StartingActuations;
            public global::UnityEngine.InputSystem.InputAction action => null;
            public global::UnityEngine.InputSystem.InputBinding? bindingMask => null;
            public global::UnityEngine.InputSystem.InputControlList<global::UnityEngine.InputSystem.InputControl> candidates => default;
            public global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<float> scores => default;
            public global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<float> magnitudes => default;
            public global::UnityEngine.InputSystem.InputControl selectedControl => null;
            public bool started => false;
            public bool completed => false;
            public bool canceled => false;
            public double startTime => 0.0;
            public float timeout => 0f;
            public string expectedControlType => null;

            public global::UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithAction(global::UnityEngine.InputSystem.InputAction action)
            {
                return null;
            }

            public global::UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithMatchingEventsBeingSuppressed(bool value = true)
            {
                return null;
            }

            public global::UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithCancelingThrough(string binding)
            {
                return null;
            }

            public global::UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithCancelingThrough(global::UnityEngine.InputSystem.InputControl control)
            {
                return null;
            }

            public global::UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithExpectedControlType(string layoutName)
            {
                return null;
            }

            public global::UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithExpectedControlType(global::System.Type type)
            {
                return null;
            }

            public global::UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithExpectedControlType<TControl>()
                where TControl : global::UnityEngine.InputSystem.InputControl
            {
                return null;
            }

            public global::UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithTargetBinding(int bindingIndex)
            {
                return null;
            }

            public global::UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithBindingMask(global::UnityEngine.InputSystem.InputBinding? bindingMask)
            {
                return null;
            }

            public global::UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithBindingGroup(string group)
            {
                return null;
            }

            public global::UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithoutGeneralizingPathOfSelectedControl()
            {
                return null;
            }

            public global::UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithRebindAddingNewBinding(string group = null)
            {
                return null;
            }

            public global::UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithMagnitudeHavingToBeGreaterThan(float magnitude)
            {
                return null;
            }

            public global::UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithoutIgnoringNoisyControls()
            {
                return null;
            }

            public global::UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithControlsHavingToMatchPath(string path)
            {
                return null;
            }

            public global::UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithControlsExcluding(string path)
            {
                return null;
            }

            public global::UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation WithTimeout(float timeInSeconds)
            {
                return null;
            }

            public global::UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation OnComplete(global::System.Action<global::UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation> callback)
            {
                return null;
            }

            public global::UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation OnCancel(global::System.Action<global::UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation> callback)
            {
                return null;
            }

            public global::UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation OnPotentialMatch(global::System.Action<global::UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation> callback)
            {
                return null;
            }

            public global::UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation OnGeneratePath(global::System.Func<global::UnityEngine.InputSystem.InputControl, string> callback)
            {
                return null;
            }

            public global::UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation OnComputeScore(global::System.Func<global::UnityEngine.InputSystem.InputControl, global::UnityEngine.InputSystem.LowLevel.InputEventPtr, float> callback)
            {
                return null;
            }

            public global::UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation OnApplyBinding(global::System.Action<global::UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation, string> callback)
            {
                return null;
            }

            public global::UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation OnMatchWaitForAnother(float seconds)
            {
                return null;
            }

            public global::UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation Start()
            {
                return null;
            }

            public void Cancel()
            {
            }

            public void Complete()
            {
            }

            public void AddCandidate(global::UnityEngine.InputSystem.InputControl control, float score, float magnitude = -1f)
            {
            }

            public void RemoveCandidate(global::UnityEngine.InputSystem.InputControl control)
            {
            }

            public void Dispose()
            {
            }

            ~RebindingOperation()
            {
            }

            public global::UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation Reset()
            {
                return null;
            }

            private void HookOnEvent()
            {
            }

            private void UnhookOnEvent()
            {
            }

            private void OnEvent(global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, global::UnityEngine.InputSystem.InputDevice device)
            {
            }

            private void SortCandidatesByScore()
            {
            }

            private static bool HavePathMatch(global::UnityEngine.InputSystem.InputControl control, string[] paths, int pathCount)
            {
                return false;
            }

            private void HookOnAfterUpdate()
            {
            }

            private void UnhookOnAfterUpdate()
            {
            }

            private void OnAfterUpdate()
            {
            }

            private void OnComplete()
            {
            }

            private void OnCancel()
            {
            }

            private void ResetAfterMatchCompleted()
            {
            }

            private void ThrowIfRebindInProgress()
            {
            }

            private string GeneratePathForControl(global::UnityEngine.InputSystem.InputControl control)
            {
                return null;
            }
        }

        internal class DeferBindingResolutionWrapper : global::System.IDisposable
        {
            public void Acquire()
            {
            }

            public void Dispose()
            {
            }
        }

        private static global::UnityEngine.InputSystem.InputActionRebindingExtensions.DeferBindingResolutionWrapper s_DeferBindingResolutionWrapper;
        public static global::UnityEngine.InputSystem.Utilities.PrimitiveValue? GetParameterValue(this global::UnityEngine.InputSystem.InputAction action, string name, global::UnityEngine.InputSystem.InputBinding bindingMask = default(global::UnityEngine.InputSystem.InputBinding))
        {
            return null;
        }

        private static global::UnityEngine.InputSystem.Utilities.PrimitiveValue? GetParameterValue(this global::UnityEngine.InputSystem.InputAction action, global::UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride parameterOverride)
        {
            return null;
        }

        public static global::UnityEngine.InputSystem.Utilities.PrimitiveValue? GetParameterValue(this global::UnityEngine.InputSystem.InputAction action, string name, int bindingIndex)
        {
            return null;
        }

        public static TValue? GetParameterValue<TObject, TValue>(this global::UnityEngine.InputSystem.InputAction action, global::System.Linq.Expressions.Expression<global::System.Func<TObject, TValue>> expr, global::UnityEngine.InputSystem.InputBinding bindingMask = default(global::UnityEngine.InputSystem.InputBinding))
            where TValue : struct
        {
            return null;
        }

        public static void ApplyParameterOverride<TObject, TValue>(this global::UnityEngine.InputSystem.InputAction action, global::System.Linq.Expressions.Expression<global::System.Func<TObject, TValue>> expr, TValue value, global::UnityEngine.InputSystem.InputBinding bindingMask = default(global::UnityEngine.InputSystem.InputBinding))
            where TValue : struct
        {
        }

        public static void ApplyParameterOverride<TObject, TValue>(this global::UnityEngine.InputSystem.InputActionMap actionMap, global::System.Linq.Expressions.Expression<global::System.Func<TObject, TValue>> expr, TValue value, global::UnityEngine.InputSystem.InputBinding bindingMask = default(global::UnityEngine.InputSystem.InputBinding))
            where TValue : struct
        {
        }

        public static void ApplyParameterOverride<TObject, TValue>(this global::UnityEngine.InputSystem.InputActionAsset asset, global::System.Linq.Expressions.Expression<global::System.Func<TObject, TValue>> expr, TValue value, global::UnityEngine.InputSystem.InputBinding bindingMask = default(global::UnityEngine.InputSystem.InputBinding))
            where TValue : struct
        {
        }

        private static global::UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride ExtractParameterOverride<TObject, TValue>(global::System.Linq.Expressions.Expression<global::System.Func<TObject, TValue>> expr, global::UnityEngine.InputSystem.InputBinding bindingMask = default(global::UnityEngine.InputSystem.InputBinding), global::UnityEngine.InputSystem.Utilities.PrimitiveValue value = default(global::UnityEngine.InputSystem.Utilities.PrimitiveValue))
        {
            return default;
        }

        public static void ApplyParameterOverride(this global::UnityEngine.InputSystem.InputActionMap actionMap, string name, global::UnityEngine.InputSystem.Utilities.PrimitiveValue value, global::UnityEngine.InputSystem.InputBinding bindingMask = default(global::UnityEngine.InputSystem.InputBinding))
        {
        }

        public static void ApplyParameterOverride(this global::UnityEngine.InputSystem.InputActionAsset asset, string name, global::UnityEngine.InputSystem.Utilities.PrimitiveValue value, global::UnityEngine.InputSystem.InputBinding bindingMask = default(global::UnityEngine.InputSystem.InputBinding))
        {
        }

        public static void ApplyParameterOverride(this global::UnityEngine.InputSystem.InputAction action, string name, global::UnityEngine.InputSystem.Utilities.PrimitiveValue value, global::UnityEngine.InputSystem.InputBinding bindingMask = default(global::UnityEngine.InputSystem.InputBinding))
        {
        }

        public static void ApplyParameterOverride(this global::UnityEngine.InputSystem.InputAction action, string name, global::UnityEngine.InputSystem.Utilities.PrimitiveValue value, int bindingIndex)
        {
        }

        private static void ApplyParameterOverride(global::UnityEngine.InputSystem.InputActionState state, int mapIndex, ref global::UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride[] parameterOverrides, ref int parameterOverridesCount, global::UnityEngine.InputSystem.InputActionRebindingExtensions.ParameterOverride parameterOverride)
        {
        }

        public static int GetBindingIndex(this global::UnityEngine.InputSystem.InputAction action, global::UnityEngine.InputSystem.InputBinding bindingMask)
        {
            return 0;
        }

        public static int GetBindingIndex(this global::UnityEngine.InputSystem.InputActionMap actionMap, global::UnityEngine.InputSystem.InputBinding bindingMask)
        {
            return 0;
        }

        public static int GetBindingIndex(this global::UnityEngine.InputSystem.InputAction action, string group = null, string path = null)
        {
            return 0;
        }

        public static global::UnityEngine.InputSystem.InputBinding? GetBindingForControl(this global::UnityEngine.InputSystem.InputAction action, global::UnityEngine.InputSystem.InputControl control)
        {
            return null;
        }

        public static int GetBindingIndexForControl(this global::UnityEngine.InputSystem.InputAction action, global::UnityEngine.InputSystem.InputControl control)
        {
            return 0;
        }

        public static string GetBindingDisplayString(this global::UnityEngine.InputSystem.InputAction action, global::UnityEngine.InputSystem.InputBinding.DisplayStringOptions options = (global::UnityEngine.InputSystem.InputBinding.DisplayStringOptions)0, string group = null)
        {
            return null;
        }

        public static string GetBindingDisplayString(this global::UnityEngine.InputSystem.InputAction action, global::UnityEngine.InputSystem.InputBinding bindingMask, global::UnityEngine.InputSystem.InputBinding.DisplayStringOptions options = (global::UnityEngine.InputSystem.InputBinding.DisplayStringOptions)0)
        {
            return null;
        }

        public static string GetBindingDisplayString(this global::UnityEngine.InputSystem.InputAction action, int bindingIndex, global::UnityEngine.InputSystem.InputBinding.DisplayStringOptions options = (global::UnityEngine.InputSystem.InputBinding.DisplayStringOptions)0)
        {
            return null;
        }

        public static string GetBindingDisplayString(this global::UnityEngine.InputSystem.InputAction action, int bindingIndex, out string deviceLayoutName, out string controlPath, global::UnityEngine.InputSystem.InputBinding.DisplayStringOptions options = (global::UnityEngine.InputSystem.InputBinding.DisplayStringOptions)0)
        {
            deviceLayoutName = null;
            controlPath = null;
            return null;
        }

        public static void ApplyBindingOverride(this global::UnityEngine.InputSystem.InputAction action, string newPath, string group = null, string path = null)
        {
        }

        public static void ApplyBindingOverride(this global::UnityEngine.InputSystem.InputAction action, global::UnityEngine.InputSystem.InputBinding bindingOverride)
        {
        }

        public static void ApplyBindingOverride(this global::UnityEngine.InputSystem.InputAction action, int bindingIndex, global::UnityEngine.InputSystem.InputBinding bindingOverride)
        {
        }

        public static void ApplyBindingOverride(this global::UnityEngine.InputSystem.InputAction action, int bindingIndex, string path)
        {
        }

        public static int ApplyBindingOverride(this global::UnityEngine.InputSystem.InputActionMap actionMap, global::UnityEngine.InputSystem.InputBinding bindingOverride)
        {
            return 0;
        }

        public static void ApplyBindingOverride(this global::UnityEngine.InputSystem.InputActionMap actionMap, int bindingIndex, global::UnityEngine.InputSystem.InputBinding bindingOverride)
        {
        }

        public static void RemoveBindingOverride(this global::UnityEngine.InputSystem.InputAction action, int bindingIndex)
        {
        }

        public static void RemoveBindingOverride(this global::UnityEngine.InputSystem.InputAction action, global::UnityEngine.InputSystem.InputBinding bindingMask)
        {
        }

        private static void RemoveBindingOverride(this global::UnityEngine.InputSystem.InputActionMap actionMap, global::UnityEngine.InputSystem.InputBinding bindingMask)
        {
        }

        public static void RemoveAllBindingOverrides(this global::UnityEngine.InputSystem.IInputActionCollection2 actions)
        {
        }

        public static void RemoveAllBindingOverrides(this global::UnityEngine.InputSystem.InputAction action)
        {
        }

        public static void ApplyBindingOverrides(this global::UnityEngine.InputSystem.InputActionMap actionMap, global::System.Collections.Generic.IEnumerable<global::UnityEngine.InputSystem.InputBinding> overrides)
        {
        }

        public static void RemoveBindingOverrides(this global::UnityEngine.InputSystem.InputActionMap actionMap, global::System.Collections.Generic.IEnumerable<global::UnityEngine.InputSystem.InputBinding> overrides)
        {
        }

        public static int ApplyBindingOverridesOnMatchingControls(this global::UnityEngine.InputSystem.InputAction action, global::UnityEngine.InputSystem.InputControl control)
        {
            return 0;
        }

        public static int ApplyBindingOverridesOnMatchingControls(this global::UnityEngine.InputSystem.InputActionMap actionMap, global::UnityEngine.InputSystem.InputControl control)
        {
            return 0;
        }

        public static string SaveBindingOverridesAsJson(this global::UnityEngine.InputSystem.IInputActionCollection2 actions)
        {
            return null;
        }

        public static string SaveBindingOverridesAsJson(this global::UnityEngine.InputSystem.InputAction action)
        {
            return null;
        }

        private static void AddBindingOverrideJsonTo(this global::UnityEngine.InputSystem.IInputActionCollection2 actions, global::UnityEngine.InputSystem.InputBinding binding, global::System.Collections.Generic.List<global::UnityEngine.InputSystem.InputActionMap.BindingOverrideJson> list, global::UnityEngine.InputSystem.InputAction action = null)
        {
        }

        public static void LoadBindingOverridesFromJson(this global::UnityEngine.InputSystem.IInputActionCollection2 actions, string json, bool removeExisting = true)
        {
        }

        public static void LoadBindingOverridesFromJson(this global::UnityEngine.InputSystem.InputAction action, string json, bool removeExisting = true)
        {
        }

        private static void LoadBindingOverridesFromJsonInternal(this global::UnityEngine.InputSystem.IInputActionCollection2 actions, string json)
        {
        }

        public static global::UnityEngine.InputSystem.InputActionRebindingExtensions.RebindingOperation PerformInteractiveRebinding(this global::UnityEngine.InputSystem.InputAction action, int bindingIndex = -1)
        {
            return null;
        }

        internal static global::UnityEngine.InputSystem.InputActionRebindingExtensions.DeferBindingResolutionWrapper DeferBindingResolution()
        {
            return null;
        }
    }
}
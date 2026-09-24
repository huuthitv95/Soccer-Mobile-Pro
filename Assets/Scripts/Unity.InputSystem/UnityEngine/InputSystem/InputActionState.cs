namespace UnityEngine.InputSystem
{
    internal class InputActionState : global::UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor, global::System.ICloneable, global::System.IDisposable
    {
        [global::System.Runtime.InteropServices.StructLayout((global::System.Runtime.InteropServices.LayoutKind)2, Pack = 1, Size = 48)]
        internal struct InteractionState
        {
            [global::System.Flags]
            private enum Flags
            {
                TimerRunning = 1
            }

            [global::System.Runtime.InteropServices.FieldOffset(0)]
            private ushort m_TriggerControlIndex;
            [global::System.Runtime.InteropServices.FieldOffset(2)]
            private byte m_Phase;
            [global::System.Runtime.InteropServices.FieldOffset(3)]
            private byte m_Flags;
            [global::System.Runtime.InteropServices.FieldOffset(4)]
            private float m_TimerDuration;
            [global::System.Runtime.InteropServices.FieldOffset(8)]
            private double m_StartTime;
            [global::System.Runtime.InteropServices.FieldOffset(16)]
            private double m_TimerStartTime;
            [global::System.Runtime.InteropServices.FieldOffset(24)]
            private double m_PerformedTime;
            [global::System.Runtime.InteropServices.FieldOffset(32)]
            private float m_TotalTimeoutCompletionTimeDone;
            [global::System.Runtime.InteropServices.FieldOffset(36)]
            private float m_TotalTimeoutCompletionTimeRemaining;
            [global::System.Runtime.InteropServices.FieldOffset(40)]
            private long m_TimerMonitorIndex;
            public int triggerControlIndex
            {
                get
                {
                    return 0;
                }

                set
                {
                }
            }

            public double startTime
            {
                get
                {
                    return 0.0;
                }

                set
                {
                }
            }

            public double performedTime
            {
                get
                {
                    return 0.0;
                }

                set
                {
                }
            }

            public double timerStartTime
            {
                get
                {
                    return 0.0;
                }

                set
                {
                }
            }

            public float timerDuration
            {
                get
                {
                    return 0f;
                }

                set
                {
                }
            }

            public float totalTimeoutCompletionDone
            {
                get
                {
                    return 0f;
                }

                set
                {
                }
            }

            public float totalTimeoutCompletionTimeRemaining
            {
                get
                {
                    return 0f;
                }

                set
                {
                }
            }

            public long timerMonitorIndex
            {
                get
                {
                    return 0L;
                }

                set
                {
                }
            }

            public bool isTimerRunning
            {
                get
                {
                    return false;
                }

                set
                {
                }
            }

            public global::UnityEngine.InputSystem.InputActionPhase phase
            {
                get
                {
                    return global::UnityEngine.InputSystem.InputActionPhase.Disabled;
                }

                set
                {
                }
            }
        }

        [global::System.Runtime.InteropServices.StructLayout((global::System.Runtime.InteropServices.LayoutKind)2, Pack = 1, Size = 32)]
        internal struct BindingState
        {
            [global::System.Flags]
            public enum Flags
            {
                ChainsWithNext = 1,
                EndOfChain = 2,
                Composite = 4,
                PartOfComposite = 8,
                InitialStateCheckPending = 0x10,
                WantsInitialStateCheck = 0x20
            }

            [global::System.Runtime.InteropServices.FieldOffset(0)]
            private byte m_ControlCount;
            [global::System.Runtime.InteropServices.FieldOffset(1)]
            private byte m_InteractionCount;
            [global::System.Runtime.InteropServices.FieldOffset(2)]
            private byte m_ProcessorCount;
            [global::System.Runtime.InteropServices.FieldOffset(3)]
            private byte m_MapIndex;
            [global::System.Runtime.InteropServices.FieldOffset(4)]
            private byte m_Flags;
            [global::System.Runtime.InteropServices.FieldOffset(5)]
            private byte m_PartIndex;
            [global::System.Runtime.InteropServices.FieldOffset(6)]
            private ushort m_ActionIndex;
            [global::System.Runtime.InteropServices.FieldOffset(8)]
            private ushort m_CompositeOrCompositeBindingIndex;
            [global::System.Runtime.InteropServices.FieldOffset(10)]
            private ushort m_ProcessorStartIndex;
            [global::System.Runtime.InteropServices.FieldOffset(12)]
            private ushort m_InteractionStartIndex;
            [global::System.Runtime.InteropServices.FieldOffset(14)]
            private ushort m_ControlStartIndex;
            [global::System.Runtime.InteropServices.FieldOffset(16)]
            private double m_PressTime;
            [global::System.Runtime.InteropServices.FieldOffset(24)]
            private int m_TriggerEventIdForComposite;
            [global::System.Runtime.InteropServices.FieldOffset(28)]
            private int __padding;
            public int controlStartIndex
            {
                get
                {
                    return 0;
                }

                set
                {
                }
            }

            public int controlCount
            {
                get
                {
                    return 0;
                }

                set
                {
                }
            }

            public int interactionStartIndex
            {
                get
                {
                    return 0;
                }

                set
                {
                }
            }

            public int interactionCount
            {
                get
                {
                    return 0;
                }

                set
                {
                }
            }

            public int processorStartIndex
            {
                get
                {
                    return 0;
                }

                set
                {
                }
            }

            public int processorCount
            {
                get
                {
                    return 0;
                }

                set
                {
                }
            }

            public int actionIndex
            {
                get
                {
                    return 0;
                }

                set
                {
                }
            }

            public int mapIndex
            {
                get
                {
                    return 0;
                }

                set
                {
                }
            }

            public int compositeOrCompositeBindingIndex
            {
                get
                {
                    return 0;
                }

                set
                {
                }
            }

            public int triggerEventIdForComposite
            {
                get
                {
                    return 0;
                }

                set
                {
                }
            }

            public double pressTime
            {
                get
                {
                    return 0.0;
                }

                set
                {
                }
            }

            public global::UnityEngine.InputSystem.InputActionState.BindingState.Flags flags
            {
                get
                {
                    return (global::UnityEngine.InputSystem.InputActionState.BindingState.Flags)0;
                }

                set
                {
                }
            }

            public bool chainsWithNext
            {
                get
                {
                    return false;
                }

                set
                {
                }
            }

            public bool isEndOfChain
            {
                get
                {
                    return false;
                }

                set
                {
                }
            }

            public bool isPartOfChain => false;

            public bool isComposite
            {
                get
                {
                    return false;
                }

                set
                {
                }
            }

            public bool isPartOfComposite
            {
                get
                {
                    return false;
                }

                set
                {
                }
            }

            public bool initialStateCheckPending
            {
                get
                {
                    return false;
                }

                set
                {
                }
            }

            public bool wantsInitialStateCheck
            {
                get
                {
                    return false;
                }

                set
                {
                }
            }

            public int partIndex
            {
                get
                {
                    return 0;
                }

                set
                {
                }
            }
        }

        [global::System.Runtime.InteropServices.StructLayout((global::System.Runtime.InteropServices.LayoutKind)2, Pack = 1, Size = 56)]
        public struct TriggerState
        {
            [global::System.Flags]
            public enum Flags
            {
                HaveMagnitude = 1,
                PassThrough = 2,
                MayNeedConflictResolution = 4,
                HasMultipleConcurrentActuations = 8,
                InProcessing = 0x10,
                Button = 0x20,
                Pressed = 0x40
            }

            public const int kMaxNumMaps = 255;
            public const int kMaxNumControls = 65535;
            public const int kMaxNumBindings = 65535;
            [global::System.Runtime.InteropServices.FieldOffset(0)]
            private byte m_Phase;
            [global::System.Runtime.InteropServices.FieldOffset(1)]
            private byte m_Flags;
            [global::System.Runtime.InteropServices.FieldOffset(2)]
            private byte m_MapIndex;
            [global::System.Runtime.InteropServices.FieldOffset(4)]
            private ushort m_ControlIndex;
            [global::System.Runtime.InteropServices.FieldOffset(8)]
            private double m_Time;
            [global::System.Runtime.InteropServices.FieldOffset(16)]
            private double m_StartTime;
            [global::System.Runtime.InteropServices.FieldOffset(24)]
            private ushort m_BindingIndex;
            [global::System.Runtime.InteropServices.FieldOffset(26)]
            private ushort m_InteractionIndex;
            [global::System.Runtime.InteropServices.FieldOffset(28)]
            private float m_Magnitude;
            [global::System.Runtime.InteropServices.FieldOffset(32)]
            private uint m_LastPerformedInUpdate;
            [global::System.Runtime.InteropServices.FieldOffset(36)]
            private uint m_LastCanceledInUpdate;
            [global::System.Runtime.InteropServices.FieldOffset(40)]
            private uint m_PressedInUpdate;
            [global::System.Runtime.InteropServices.FieldOffset(44)]
            private uint m_ReleasedInUpdate;
            [global::System.Runtime.InteropServices.FieldOffset(48)]
            private uint m_LastCompletedInUpdate;
            public global::UnityEngine.InputSystem.InputActionPhase phase
            {
                get
                {
                    return global::UnityEngine.InputSystem.InputActionPhase.Disabled;
                }

                set
                {
                }
            }

            public bool isDisabled => false;
            public bool isWaiting => false;
            public bool isStarted => false;
            public bool isPerformed => false;
            public bool isCanceled => false;

            public double time
            {
                get
                {
                    return 0.0;
                }

                set
                {
                }
            }

            public double startTime
            {
                get
                {
                    return 0.0;
                }

                set
                {
                }
            }

            public float magnitude
            {
                get
                {
                    return 0f;
                }

                set
                {
                }
            }

            public bool haveMagnitude => false;

            public int mapIndex
            {
                get
                {
                    return 0;
                }

                set
                {
                }
            }

            public int controlIndex
            {
                get
                {
                    return 0;
                }

                set
                {
                }
            }

            public int bindingIndex
            {
                get
                {
                    return 0;
                }

                set
                {
                }
            }

            public int interactionIndex
            {
                get
                {
                    return 0;
                }

                set
                {
                }
            }

            public uint lastPerformedInUpdate
            {
                get
                {
                    return 0u;
                }

                set
                {
                }
            }

            public uint lastCompletedInUpdate
            {
                get
                {
                    return 0u;
                }

                set
                {
                }
            }

            public uint lastCanceledInUpdate
            {
                get
                {
                    return 0u;
                }

                set
                {
                }
            }

            public uint pressedInUpdate
            {
                get
                {
                    return 0u;
                }

                set
                {
                }
            }

            public uint releasedInUpdate
            {
                get
                {
                    return 0u;
                }

                set
                {
                }
            }

            public bool isPassThrough
            {
                get
                {
                    return false;
                }

                set
                {
                }
            }

            public bool isButton
            {
                get
                {
                    return false;
                }

                set
                {
                }
            }

            public bool isPressed
            {
                get
                {
                    return false;
                }

                set
                {
                }
            }

            public bool mayNeedConflictResolution
            {
                get
                {
                    return false;
                }

                set
                {
                }
            }

            public bool hasMultipleConcurrentActuations
            {
                get
                {
                    return false;
                }

                set
                {
                }
            }

            public bool inProcessing
            {
                get
                {
                    return false;
                }

                set
                {
                }
            }

            public global::UnityEngine.InputSystem.InputActionState.TriggerState.Flags flags
            {
                get
                {
                    return (global::UnityEngine.InputSystem.InputActionState.TriggerState.Flags)0;
                }

                set
                {
                }
            }
        }

        public struct ActionMapIndices
        {
            public int actionStartIndex;
            public int actionCount;
            public int controlStartIndex;
            public int controlCount;
            public int bindingStartIndex;
            public int bindingCount;
            public int interactionStartIndex;
            public int interactionCount;
            public int processorStartIndex;
            public int processorCount;
            public int compositeStartIndex;
            public int compositeCount;
        }

        public struct UnmanagedMemory : global::System.IDisposable
        {
            public unsafe void* basePtr;
            public int mapCount;
            public int actionCount;
            public int interactionCount;
            public int bindingCount;
            public int controlCount;
            public int compositeCount;
            public unsafe global::UnityEngine.InputSystem.InputActionState.TriggerState* actionStates;
            public unsafe global::UnityEngine.InputSystem.InputActionState.BindingState* bindingStates;
            public unsafe global::UnityEngine.InputSystem.InputActionState.InteractionState* interactionStates;
            public unsafe float* controlMagnitudes;
            public unsafe float* compositeMagnitudes;
            public unsafe int* enabledControls;
            public unsafe ushort* actionBindingIndicesAndCounts;
            public unsafe ushort* actionBindingIndices;
            public unsafe int* controlIndexToBindingIndex;
            public unsafe ushort* controlGroupingAndComplexity;
            public bool controlGroupingInitialized;
            public unsafe global::UnityEngine.InputSystem.InputActionState.ActionMapIndices* mapIndices;
            public bool isAllocated => false;
            public int sizeInBytes => 0;

            public void Allocate(int mapCount, int actionCount, int bindingCount, int controlCount, int interactionCount, int compositeCount)
            {
            }

            public void Dispose()
            {
            }

            public void CopyDataFrom(global::UnityEngine.InputSystem.InputActionState.UnmanagedMemory memory)
            {
            }

            public global::UnityEngine.InputSystem.InputActionState.UnmanagedMemory Clone()
            {
                return default;
            }
        }

        internal struct GlobalState
        {
            internal global::UnityEngine.InputSystem.Utilities.InlinedArray<global::System.Runtime.InteropServices.GCHandle> globalList;
            internal global::UnityEngine.InputSystem.Utilities.CallbackArray<global::System.Action<object, global::UnityEngine.InputSystem.InputActionChange>> onActionChange;
            internal global::UnityEngine.InputSystem.Utilities.CallbackArray<global::System.Action<object>> onActionControlsChanged;
        }

        public const int kInvalidIndex = -1;
        public global::UnityEngine.InputSystem.InputActionMap[] maps;
        public global::UnityEngine.InputSystem.InputControl[] controls;
        public global::UnityEngine.InputSystem.IInputInteraction[] interactions;
        public global::UnityEngine.InputSystem.InputProcessor[] processors;
        public global::UnityEngine.InputSystem.InputBindingComposite[] composites;
        public int totalProcessorCount;
        public global::UnityEngine.InputSystem.InputActionState.UnmanagedMemory memory;
        private bool m_OnBeforeUpdateHooked;
        private bool m_OnAfterUpdateHooked;
        private bool m_InProcessControlStateChange;
        private global::UnityEngine.InputSystem.LowLevel.InputEventPtr m_CurrentlyProcessingThisEvent;
        private global::System.Action m_OnBeforeUpdateDelegate;
        private global::System.Action m_OnAfterUpdateDelegate;
        internal static global::UnityEngine.InputSystem.InputActionState.GlobalState s_GlobalState;
        public int totalCompositeCount => 0;
        public int totalMapCount => 0;
        public int totalActionCount => 0;
        public int totalBindingCount => 0;
        public int totalInteractionCount => 0;
        public int totalControlCount => 0;
        public unsafe global::UnityEngine.InputSystem.InputActionState.ActionMapIndices* mapIndices => null;
        public unsafe global::UnityEngine.InputSystem.InputActionState.TriggerState* actionStates => null;
        public unsafe global::UnityEngine.InputSystem.InputActionState.BindingState* bindingStates => null;
        public unsafe global::UnityEngine.InputSystem.InputActionState.InteractionState* interactionStates => null;
        public unsafe int* controlIndexToBindingIndex => null;
        public unsafe ushort* controlGroupingAndComplexity => null;
        public unsafe float* controlMagnitudes => null;
        public unsafe uint* enabledControls => null;
        public bool isProcessingControlStateChange => false;

        public void Initialize(global::UnityEngine.InputSystem.InputBindingResolver resolver)
        {
        }

        private void ComputeControlGroupingIfNecessary()
        {
        }

        public void ClaimDataFrom(global::UnityEngine.InputSystem.InputBindingResolver resolver)
        {
        }

        ~InputActionState()
        {
        }

        public void Dispose()
        {
        }

        private void Destroy(bool isFinalizing = false)
        {
        }

        public global::UnityEngine.InputSystem.InputActionState Clone()
        {
            return null;
        }

        object global::System.ICloneable.Clone()
        {
            return null;
        }

        private bool IsUsingDevice(global::UnityEngine.InputSystem.InputDevice device)
        {
            return false;
        }

        private bool CanUseDevice(global::UnityEngine.InputSystem.InputDevice device)
        {
            return false;
        }

        public bool HasEnabledActions()
        {
            return false;
        }

        private void FinishBindingCompositeSetups()
        {
        }

        internal void PrepareForBindingReResolution(bool needFullResolve, ref global::UnityEngine.InputSystem.InputControlList<global::UnityEngine.InputSystem.InputControl> activeControls, ref bool hasEnabledActions)
        {
        }

        public void FinishBindingResolution(bool hasEnabledActions, global::UnityEngine.InputSystem.InputActionState.UnmanagedMemory oldMemory, global::UnityEngine.InputSystem.InputControlList<global::UnityEngine.InputSystem.InputControl> activeControls, bool isFullResolve)
        {
        }

        private void RestoreActionStatesAfterReResolvingBindings(global::UnityEngine.InputSystem.InputActionState.UnmanagedMemory oldState, global::UnityEngine.InputSystem.InputControlList<global::UnityEngine.InputSystem.InputControl> activeControls, bool isFullResolve)
        {
        }

        private bool IsActiveControl(int bindingIndex, int controlIndex)
        {
            return false;
        }

        private int FindControlIndexOnBinding(int bindingIndex, global::UnityEngine.InputSystem.InputControl control)
        {
            return 0;
        }

        private void ResetActionStatesDrivenBy(global::UnityEngine.InputSystem.InputDevice device)
        {
        }

        private bool IsActionBoundToControlFromDevice(global::UnityEngine.InputSystem.InputDevice device, int actionIndex)
        {
            return false;
        }

        public void ResetActionState(int actionIndex, global::UnityEngine.InputSystem.InputActionPhase toPhase = global::UnityEngine.InputSystem.InputActionPhase.Waiting, bool hardReset = false)
        {
        }

        public ref global::UnityEngine.InputSystem.InputActionState.TriggerState FetchActionState(global::UnityEngine.InputSystem.InputAction action)
        {
            throw null;
        }

        public global::UnityEngine.InputSystem.InputActionState.ActionMapIndices FetchMapIndices(global::UnityEngine.InputSystem.InputActionMap map)
        {
            return default;
        }

        public void EnableAllActions(global::UnityEngine.InputSystem.InputActionMap map)
        {
        }

        private void EnableControls(global::UnityEngine.InputSystem.InputActionMap map)
        {
        }

        public void EnableSingleAction(global::UnityEngine.InputSystem.InputAction action)
        {
        }

        private void EnableControls(global::UnityEngine.InputSystem.InputAction action)
        {
        }

        public void DisableAllActions(global::UnityEngine.InputSystem.InputActionMap map)
        {
        }

        public void DisableControls(global::UnityEngine.InputSystem.InputActionMap map)
        {
        }

        public void DisableSingleAction(global::UnityEngine.InputSystem.InputAction action)
        {
        }

        private void DisableControls(global::UnityEngine.InputSystem.InputAction action)
        {
        }

        private void EnableControls(int mapIndex, int controlStartIndex, int numControls)
        {
        }

        private void DisableControls(int mapIndex, int controlStartIndex, int numControls)
        {
        }

        public void SetInitialStateCheckPending(int actionIndex, bool value = true)
        {
        }

        private unsafe void SetInitialStateCheckPending(global::UnityEngine.InputSystem.InputActionState.BindingState* bindingStatePtr, bool value)
        {
        }

        private bool IsControlEnabled(int controlIndex)
        {
            return false;
        }

        private void SetControlEnabled(int controlIndex, bool state)
        {
        }

        private void HookOnBeforeUpdate()
        {
        }

        private void UnhookOnBeforeUpdate()
        {
        }

        private void OnBeforeInitialUpdate()
        {
        }

        void global::UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyControlStateChanged(global::UnityEngine.InputSystem.InputControl control, double time, global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr, long mapControlAndBindingIndex)
        {
        }

        void global::UnityEngine.InputSystem.LowLevel.IInputStateChangeMonitor.NotifyTimerExpired(global::UnityEngine.InputSystem.InputControl control, double time, long mapControlAndBindingIndex, int interactionIndex)
        {
        }

        private long ToCombinedMapAndControlAndBindingIndex(int mapIndex, int controlIndex, int bindingIndex)
        {
            return 0L;
        }

        private void SplitUpMapAndControlAndBindingIndex(long mapControlAndBindingIndex, out int mapIndex, out int controlIndex, out int bindingIndex)
        {
            mapIndex = default;
            controlIndex = default;
            bindingIndex = default;
        }

        internal static int GetComplexityFromMonitorIndex(long mapControlAndBindingIndex)
        {
            return 0;
        }

        private void ProcessControlStateChange(int mapIndex, int controlIndex, int bindingIndex, double time, global::UnityEngine.InputSystem.LowLevel.InputEventPtr eventPtr)
        {
        }

        private unsafe void ProcessButtonState(ref global::UnityEngine.InputSystem.InputActionState.TriggerState trigger, int actionIndex, global::UnityEngine.InputSystem.InputActionState.BindingState* bindingStatePtr)
        {
        }

        private unsafe static bool ShouldIgnoreInputOnCompositeBinding(global::UnityEngine.InputSystem.InputActionState.BindingState* binding, global::UnityEngine.InputSystem.LowLevel.InputEvent* eventPtr)
        {
            return false;
        }

        private bool IsConflictingInput(ref global::UnityEngine.InputSystem.InputActionState.TriggerState trigger, int actionIndex)
        {
            return false;
        }

        private ushort GetActionBindingStartIndexAndCount(int actionIndex, out ushort bindingCount)
        {
            bindingCount = default;
            return 0;
        }

        private void ProcessDefaultInteraction(ref global::UnityEngine.InputSystem.InputActionState.TriggerState trigger, int actionIndex)
        {
        }

        private void ProcessInteractions(ref global::UnityEngine.InputSystem.InputActionState.TriggerState trigger, int interactionStartIndex, int interactionCount)
        {
        }

        private void ProcessTimeout(double time, int mapIndex, int controlIndex, int bindingIndex, int interactionIndex)
        {
        }

        internal void SetTotalTimeoutCompletionTime(float seconds, ref global::UnityEngine.InputSystem.InputActionState.TriggerState trigger)
        {
        }

        internal void StartTimeout(float seconds, ref global::UnityEngine.InputSystem.InputActionState.TriggerState trigger)
        {
        }

        private void StopTimeout(int interactionIndex)
        {
        }

        internal void ChangePhaseOfInteraction(global::UnityEngine.InputSystem.InputActionPhase newPhase, ref global::UnityEngine.InputSystem.InputActionState.TriggerState trigger, global::UnityEngine.InputSystem.InputActionPhase phaseAfterPerformed = global::UnityEngine.InputSystem.InputActionPhase.Waiting, global::UnityEngine.InputSystem.InputActionPhase phaseAfterCanceled = global::UnityEngine.InputSystem.InputActionPhase.Waiting, bool processNextInteractionOnCancel = true)
        {
        }

        private bool ChangePhaseOfAction(global::UnityEngine.InputSystem.InputActionPhase newPhase, ref global::UnityEngine.InputSystem.InputActionState.TriggerState trigger, global::UnityEngine.InputSystem.InputActionPhase phaseAfterPerformedOrCanceled = global::UnityEngine.InputSystem.InputActionPhase.Waiting)
        {
            return false;
        }

        private unsafe void ChangePhaseOfActionInternal(int actionIndex, global::UnityEngine.InputSystem.InputActionState.TriggerState* actionState, global::UnityEngine.InputSystem.InputActionPhase newPhase, ref global::UnityEngine.InputSystem.InputActionState.TriggerState trigger, bool isDisablingAction = false)
        {
        }

        private void CallActionListeners(int actionIndex, global::UnityEngine.InputSystem.InputActionMap actionMap, global::UnityEngine.InputSystem.InputActionPhase phase, ref global::UnityEngine.InputSystem.Utilities.CallbackArray<global::System.Action<global::UnityEngine.InputSystem.InputAction.CallbackContext>> listeners, string callbackName)
        {
        }

        private object GetActionOrNoneString(ref global::UnityEngine.InputSystem.InputActionState.TriggerState trigger)
        {
            return null;
        }

        internal global::UnityEngine.InputSystem.InputAction GetActionOrNull(int bindingIndex)
        {
            return null;
        }

        internal global::UnityEngine.InputSystem.InputAction GetActionOrNull(ref global::UnityEngine.InputSystem.InputActionState.TriggerState trigger)
        {
            return null;
        }

        internal global::UnityEngine.InputSystem.InputControl GetControl(ref global::UnityEngine.InputSystem.InputActionState.TriggerState trigger)
        {
            return null;
        }

        private global::UnityEngine.InputSystem.IInputInteraction GetInteractionOrNull(ref global::UnityEngine.InputSystem.InputActionState.TriggerState trigger)
        {
            return null;
        }

        internal int GetBindingIndexInMap(int bindingIndex)
        {
            return 0;
        }

        internal int GetBindingIndexInState(int mapIndex, int bindingIndexInMap)
        {
            return 0;
        }

        internal ref global::UnityEngine.InputSystem.InputActionState.BindingState GetBindingState(int bindingIndex)
        {
            throw null;
        }

        internal ref global::UnityEngine.InputSystem.InputBinding GetBinding(int bindingIndex)
        {
            throw null;
        }

        internal global::UnityEngine.InputSystem.InputActionMap GetActionMap(int bindingIndex)
        {
            return null;
        }

        private void ResetInteractionStateAndCancelIfNecessary(int mapIndex, int bindingIndex, int interactionIndex, global::UnityEngine.InputSystem.InputActionPhase phaseAfterCanceled)
        {
        }

        private void ResetInteractionState(int interactionIndex)
        {
        }

        internal int GetValueSizeInBytes(int bindingIndex, int controlIndex)
        {
            return 0;
        }

        internal global::System.Type GetValueType(int bindingIndex, int controlIndex)
        {
            return null;
        }

        internal static bool IsActuated(ref global::UnityEngine.InputSystem.InputActionState.TriggerState trigger, float threshold = 0f)
        {
            return false;
        }

        internal unsafe void ReadValue(int bindingIndex, int controlIndex, void* buffer, int bufferSize, bool ignoreComposites = false)
        {
        }

        internal TValue ReadValue<TValue>(int bindingIndex, int controlIndex, bool ignoreComposites = false)
            where TValue : struct
        {
            return default;
        }

        internal TValue ApplyProcessors<TValue>(int bindingIndex, TValue value, global::UnityEngine.InputSystem.InputControl<TValue> controlOfType = null)
            where TValue : struct
        {
            return default;
        }

        public float EvaluateCompositePartMagnitude(int bindingIndex, int partNumber)
        {
            return 0f;
        }

        internal double GetCompositePartPressTime(int bindingIndex, int partNumber)
        {
            return 0.0;
        }

        internal unsafe TValue ReadCompositePartValue<TValue, TComparer>(int bindingIndex, int partNumber, bool* buttonValuePtr, out int controlIndex, TComparer comparer = default(TComparer))
            where TValue : struct where TComparer : global::System.Collections.Generic.IComparer<TValue>
        {
            controlIndex = default;
            return default;
        }

        internal unsafe bool ReadCompositePartValue(int bindingIndex, int partNumber, void* buffer, int bufferSize)
        {
            return false;
        }

        internal object ReadCompositePartValueAsObject(int bindingIndex, int partNumber)
        {
            return null;
        }

        internal object ReadValueAsObject(int bindingIndex, int controlIndex, bool ignoreComposites = false)
        {
            return null;
        }

        internal bool ReadValueAsButton(int bindingIndex, int controlIndex)
        {
            return false;
        }

        internal static global::UnityEngine.InputSystem.Utilities.ISavedState SaveAndResetState()
        {
            return null;
        }

        private void AddToGlobalList()
        {
        }

        private void RemoveMapFromGlobalList()
        {
        }

        private static void CompactGlobalList()
        {
        }

        internal void NotifyListenersOfActionChange(global::UnityEngine.InputSystem.InputActionChange change)
        {
        }

        internal static void NotifyListenersOfActionChange(global::UnityEngine.InputSystem.InputActionChange change, object actionOrMapOrAsset)
        {
        }

        private static void ResetGlobals()
        {
        }

        internal static int FindAllEnabledActions(global::System.Collections.Generic.List<global::UnityEngine.InputSystem.InputAction> result)
        {
            return 0;
        }

        internal static void OnDeviceChange(global::UnityEngine.InputSystem.InputDevice device, global::UnityEngine.InputSystem.InputDeviceChange change)
        {
        }

        internal static void DeferredResolutionOfBindings()
        {
        }

        internal static void DisableAllActions()
        {
        }

        internal static void DestroyAllActionMapStates()
        {
        }
    }
}
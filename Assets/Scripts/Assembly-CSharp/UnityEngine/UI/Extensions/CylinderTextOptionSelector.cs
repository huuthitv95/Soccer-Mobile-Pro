namespace UnityEngine.UI.Extensions
{
    public class CylinderTextOptionSelector : global::UnityEngine.EventSystems.UIBehaviour, global::UnityEngine.EventSystems.IPointerDownHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IInitializePotentialDragHandler, global::UnityEngine.EventSystems.IBeginDragHandler, global::UnityEngine.EventSystems.IDragHandler, global::UnityEngine.EventSystems.IEndDragHandler, global::UnityEngine.EventSystems.IPointerUpHandler, global::UnityEngine.EventSystems.IScrollHandler
    {
        [global::System.Serializable]
        public class OptionChangedEvent : global::UnityEngine.Events.UnityEvent<string, int>
        {
        }

        private const float MinDeltaTime = 0.0001f;
        private const float MinShortDragDistance = 1f;
        private const float ShortFlickVelocityInSteps = 0.5f;
        private const float MaxVelocityInSteps = 14f;
        private const float ScrollImpulseMultiplier = 6f;
        private const int InvalidPointerId = int.MinValue;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Extensions.CylinderTextRoller _roller;
        [global::UnityEngine.SerializeField]
        private string[] _options;
        [global::UnityEngine.SerializeField]
        private bool _loop;
        [global::UnityEngine.SerializeField]
        private int _defaultOptionIndex;
        [global::UnityEngine.SerializeField]
        private float _dragSensitivity;
        [global::UnityEngine.SerializeField]
        private float _scrollSensitivity;
        [global::UnityEngine.SerializeField]
        private float _velocityMultiplier;
        [global::UnityEngine.SerializeField]
        private float _decelerationRate;
        [global::UnityEngine.SerializeField]
        private float _snapStrength;
        [global::UnityEngine.SerializeField]
        private float _snapDamping;
        [global::UnityEngine.SerializeField]
        private float _boundaryOverdragInSteps;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Extensions.CylinderTextOptionSelector.OptionChangedEvent _onValueChanged;
        private global::UnityEngine.RectTransform _rectTransform;
        private global::UnityEngine.UI.Extensions.CylinderTextRoller _subscribedRoller;
        private global::UnityEngine.Vector2 _dragStartPointerLocalPosition;
        private float _dragStartScrollOffset;
        private float _velocity;
        private bool _dragging;
        private int _dragPointerId;
        private bool _hasPressedPointer;
        private int _pressedPointerId;
        private global::UnityEngine.Vector2 _pressedPointerLocalPosition;
        private global::UnityEngine.Vector2 _latestPressedPointerLocalPosition;
        private float _pressedScrollOffset;
        private float _pressedTime;
        private global::UnityEngine.Camera _pressedEventCamera;
        private bool _initialized;
        private bool _suppressValueChangedEvent;
        private float? _scrollTarget;
        private bool _inMotion;
        private int _latestCenterIndex;
        private string _latestCenterValue;
        private int _lastFiredCenterIndex;
        private int? _minOptionIndex;
        private int? _maxOptionIndex;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action m_OnInput;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action m_OnInputFinished;
        public global::UnityEngine.UI.Extensions.CylinderTextOptionSelector.OptionChangedEvent OnValueChanged => null;
        public int CurrentIndex => 0;
        public string CurrentValue => null;

        public event global::System.Action OnInput
        {
            [global::System.Runtime.CompilerServices.CompilerGenerated]
            add
            {
            }

            [global::System.Runtime.CompilerServices.CompilerGenerated]
            remove
            {
            }
        }

        public event global::System.Action OnInputFinished
        {
            [global::System.Runtime.CompilerServices.CompilerGenerated]
            add
            {
            }

            [global::System.Runtime.CompilerServices.CompilerGenerated]
            remove
            {
            }
        }

        protected override void Awake()
        {
        }

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        private void Update()
        {
        }

        public void SetDefaultOption(int optionIndex)
        {
        }

        public void ScrollToOption(int optionIndex)
        {
        }

        public void SetOptionIndexBounds(int minOptionIndex, int maxOptionIndex)
        {
        }

        public void ClearOptionIndexBounds()
        {
        }

        public void FinishDrag()
        {
        }

        private void FinishMotionAtOffset(float targetOffset)
        {
        }

        public void SetLoop(bool loop)
        {
        }

        public void SetOptions(string[] options, int defaultOptionIndex = 0)
        {
        }

        public void RegisterOptionColorProvider(global::System.Func<int, global::UnityEngine.Color?> optionColorProvider)
        {
        }

        public void UnregisterOptionColorProvider()
        {
        }

        public void OnPointerDown(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public void OnInitializePotentialDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        private void TrackPressedPointer(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public void OnBeginDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public void OnDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public void OnEndDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public void OnPointerUp(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        private void StartDrag(int pointerId, global::UnityEngine.Vector2 localPointerPosition, float scrollOffset)
        {
        }

        private bool IsActiveDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
            return false;
        }

        private bool IsPressedPointer(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
            return false;
        }

        private void TryFinishShortDrag(global::UnityEngine.Vector2 localPointerPosition)
        {
        }

        private void SetShortFlickTarget()
        {
        }

        private void ClearPressedPointer()
        {
        }

        private bool TryGetLocalPointerPosition(global::UnityEngine.EventSystems.PointerEventData eventData, out global::UnityEngine.Vector2 localPointerPosition)
        {
            localPointerPosition = default;
            return false;
        }

        private bool IsActivePointerStillPressed()
        {
            return false;
        }

        private bool RefreshPressedPointerPosition()
        {
            return false;
        }

        private void TryUpdateLatestPressedPointerPosition(global::UnityEngine.Vector2 screenPosition)
        {
        }

        private void UpdateDragPosition(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        private void UpdateDragPosition(global::UnityEngine.EventSystems.PointerEventData eventData, float velocitySampleDuration)
        {
        }

        private void UpdateDragPosition(global::UnityEngine.Vector2 localCursor, float velocitySampleDuration)
        {
        }

        public void OnScroll(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        private void CacheReferences()
        {
        }

        private int NormalizeOptionIndex(int optionIndex)
        {
            return 0;
        }

        private int ClampOptionIndex(int optionIndex)
        {
            return 0;
        }

        private bool HasOptionIndexBounds()
        {
            return false;
        }

        private float ClampOffset(float offset, float stepSize)
        {
            return 0f;
        }

        private float ClampOffsetWithOverdragResistance(float offset, float stepSize)
        {
            return 0f;
        }

        private float ClampOffsetWithOverdragLimit(float offset, float stepSize, out bool hitOverdragLimit)
        {
            hitOverdragLimit = default;
            return 0f;
        }

        private float GetBoundaryOverdragLimit(float stepSize)
        {
            return 0f;
        }

        private void ApplyOptionIndexBounds()
        {
        }

        private float GetSnappedOffset(float offset, float stepSize)
        {
            return 0f;
        }

        private void FireValueChangedAtOffset(float offset)
        {
        }

        private bool HasReachedSnapTarget(float currentOffset, float nextOffset, float targetOffset, float stepSize)
        {
            return false;
        }

        private float ClampVelocity(float velocity, float stepSize)
        {
            return 0f;
        }

        private float GetDragAxisDelta(global::UnityEngine.Vector2 pointerDelta)
        {
            return 0f;
        }

        private float GetScrollAxisDelta(global::UnityEngine.Vector2 scrollDelta)
        {
            return 0f;
        }

        private void HandleCenterItemChanged(string value, int index)
        {
        }

        private void FireIfChanged()
        {
        }

        private void FireValueChanged(string value, int index)
        {
        }

        private void SynchronizeLatestCenterItem()
        {
        }

        private void InitializeRoller(bool notifyExternalListeners = true)
        {
        }

        private void RefreshRollerSubscription()
        {
        }

        private void ReleaseRollerSubscription()
        {
        }
    }
}
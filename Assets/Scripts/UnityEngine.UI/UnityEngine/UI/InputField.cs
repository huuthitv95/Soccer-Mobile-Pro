namespace UnityEngine.UI
{
    public class InputField : global::UnityEngine.UI.Selectable, global::UnityEngine.EventSystems.IUpdateSelectedHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IBeginDragHandler, global::UnityEngine.EventSystems.IDragHandler, global::UnityEngine.EventSystems.IEndDragHandler, global::UnityEngine.EventSystems.IPointerClickHandler, global::UnityEngine.EventSystems.ISubmitHandler, global::UnityEngine.UI.ICanvasElement, global::UnityEngine.UI.ILayoutElement
    {
        public enum ContentType
        {
            Standard = 0,
            Autocorrected = 1,
            IntegerNumber = 2,
            DecimalNumber = 3,
            Alphanumeric = 4,
            Name = 5,
            EmailAddress = 6,
            Password = 7,
            Pin = 8,
            Custom = 9
        }

        public enum InputType
        {
            Standard = 0,
            AutoCorrect = 1,
            Password = 2
        }

        public enum CharacterValidation
        {
            None = 0,
            Integer = 1,
            Decimal = 2,
            Alphanumeric = 3,
            Name = 4,
            EmailAddress = 5
        }

        public enum LineType
        {
            SingleLine = 0,
            MultiLineSubmit = 1,
            MultiLineNewline = 2
        }

        public delegate char OnValidateInput(string text, int charIndex, char addedChar);
        [global::System.Serializable]
        public class SubmitEvent : global::UnityEngine.Events.UnityEvent<string>
        {
        }

        [global::System.Serializable]
        public class OnChangeEvent : global::UnityEngine.Events.UnityEvent<string>
        {
        }

        protected enum EditState
        {
            Continue = 0,
            Finish = 1
        }

        protected global::UnityEngine.TouchScreenKeyboard m_Keyboard;
        private static readonly char[] kSeparators;
        private static bool s_IsQuestDeviceEvaluated;
        private static bool s_IsQuestDevice;
        [global::UnityEngine.SerializeField]
        protected global::UnityEngine.UI.Text m_TextComponent;
        [global::UnityEngine.SerializeField]
        protected global::UnityEngine.UI.Graphic m_Placeholder;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.InputField.ContentType m_ContentType;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.InputField.InputType m_InputType;
        [global::UnityEngine.SerializeField]
        private char m_AsteriskChar;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.TouchScreenKeyboardType m_KeyboardType;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.InputField.LineType m_LineType;
        [global::UnityEngine.SerializeField]
        private bool m_HideMobileInput;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.InputField.CharacterValidation m_CharacterValidation;
        [global::UnityEngine.SerializeField]
        private int m_CharacterLimit;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.InputField.SubmitEvent m_OnEndEdit;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.InputField.OnChangeEvent m_OnValueChanged;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.InputField.OnValidateInput m_OnValidateInput;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Color m_CaretColor;
        [global::UnityEngine.SerializeField]
        private bool m_CustomCaretColor;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Color m_SelectionColor;
        [global::UnityEngine.SerializeField]
        protected string m_Text;
        [global::UnityEngine.SerializeField]
        private float m_CaretBlinkRate;
        [global::UnityEngine.SerializeField]
        private int m_CaretWidth;
        [global::UnityEngine.SerializeField]
        private bool m_ReadOnly;
        [global::UnityEngine.SerializeField]
        private bool m_ShouldActivateOnSelect;
        protected int m_CaretPosition;
        protected int m_CaretSelectPosition;
        private global::UnityEngine.RectTransform caretRectTrans;
        protected global::UnityEngine.UIVertex[] m_CursorVerts;
        private global::UnityEngine.TextGenerator m_InputTextCache;
        private global::UnityEngine.CanvasRenderer m_CachedInputRenderer;
        private bool m_PreventFontCallback;
        [global::System.NonSerialized]
        protected global::UnityEngine.Mesh m_Mesh;
        private bool m_AllowInput;
        private bool m_ShouldActivateNextUpdate;
        private bool m_UpdateDrag;
        private bool m_DragPositionOutOfBounds;
        private const float kHScrollSpeed = 0.05f;
        private const float kVScrollSpeed = 0.1f;
        protected bool m_CaretVisible;
        private global::UnityEngine.Coroutine m_BlinkCoroutine;
        private float m_BlinkStartTime;
        protected int m_DrawStart;
        protected int m_DrawEnd;
        private global::UnityEngine.Coroutine m_DragCoroutine;
        private string m_OriginalText;
        private bool m_WasCanceled;
        private bool m_HasDoneFocusTransition;
        private global::UnityEngine.WaitForSecondsRealtime m_WaitForSecondsRealtime;
        private bool m_TouchKeyboardAllowsInPlaceEditing;
        private bool m_IsCompositionActive;
        private const string kEmailSpecialCharacters = "!#$%&'*+-/=?^_`{|}~";
        private const string kOculusQuestDeviceModel = "Oculus Quest";
        private global::UnityEngine.Event m_ProcessingEvent;
        private const int k_MaxTextLength = 16382;
        private global::UnityEngine.EventSystems.BaseInput input => null;
        private string compositionString => null;
        protected global::UnityEngine.Mesh mesh => null;
        protected global::UnityEngine.TextGenerator cachedInputTextGenerator => null;

        public bool shouldHideMobileInput
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public virtual bool shouldActivateOnSelect
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public string text
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public bool isFocused => false;

        public float caretBlinkRate
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public int caretWidth
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.Text textComponent
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.Graphic placeholder
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.Color caretColor
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public bool customCaretColor
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public global::UnityEngine.Color selectionColor
        {
            get
            {
                return default;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.InputField.SubmitEvent onEndEdit
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        [global::System.Obsolete]
        public global::UnityEngine.UI.InputField.OnChangeEvent onValueChange
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.InputField.OnChangeEvent onValueChanged
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.InputField.OnValidateInput onValidateInput
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public int characterLimit
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.InputField.ContentType contentType
        {
            get
            {
                return global::UnityEngine.UI.InputField.ContentType.Standard;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.InputField.LineType lineType
        {
            get
            {
                return global::UnityEngine.UI.InputField.LineType.SingleLine;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.InputField.InputType inputType
        {
            get
            {
                return global::UnityEngine.UI.InputField.InputType.Standard;
            }

            set
            {
            }
        }

        public global::UnityEngine.TouchScreenKeyboard touchScreenKeyboard => null;

        public global::UnityEngine.TouchScreenKeyboardType keyboardType
        {
            get
            {
                return global::UnityEngine.TouchScreenKeyboardType.Default;
            }

            set
            {
            }
        }

        public global::UnityEngine.UI.InputField.CharacterValidation characterValidation
        {
            get
            {
                return global::UnityEngine.UI.InputField.CharacterValidation.None;
            }

            set
            {
            }
        }

        public bool readOnly
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool multiLine => false;

        public char asteriskChar
        {
            get
            {
                return '\0';
            }

            set
            {
            }
        }

        public bool wasCanceled => false;

        protected int caretPositionInternal
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        protected int caretSelectPositionInternal
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        private bool hasSelection => false;

        public int caretPosition
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public int selectionAnchorPosition
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public int selectionFocusPosition
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        private static string clipboard
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public virtual float minWidth => 0f;
        public virtual float preferredWidth => 0f;
        public virtual float flexibleWidth => 0f;
        public virtual float minHeight => 0f;
        public virtual float preferredHeight => 0f;
        public virtual float flexibleHeight => 0f;
        public virtual int layoutPriority => 0;

        global::UnityEngine.Transform global::UnityEngine.UI.ICanvasElement.transform => null;

        protected InputField()
        {
        }

        public void SetTextWithoutNotify(string input)
        {
        }

        private void SetText(string value, bool sendCallback = true)
        {
        }

        protected void ClampPos(ref int pos)
        {
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

        protected override void OnDestroy()
        {
        }

        private global::System.Collections.IEnumerator CaretBlink()
        {
            return null;
        }

        private void SetCaretVisible()
        {
        }

        private void SetCaretActive()
        {
        }

        private void UpdateCaretMaterial()
        {
        }

        protected void OnFocus()
        {
        }

        protected void SelectAll()
        {
        }

        public void MoveTextEnd(bool shift)
        {
        }

        public void MoveTextStart(bool shift)
        {
        }

        private bool TouchScreenKeyboardShouldBeUsed()
        {
            return false;
        }

        private bool InPlaceEditing()
        {
            return false;
        }

        private bool InPlaceEditingChanged()
        {
            return false;
        }

        private void UpdateCaretFromKeyboard()
        {
        }

        protected virtual void LateUpdate()
        {
        }

        [global::System.Obsolete]
        public global::UnityEngine.Vector2 ScreenToLocal(global::UnityEngine.Vector2 screen)
        {
            return default;
        }

        private int GetUnclampedCharacterLineFromPosition(global::UnityEngine.Vector2 pos, global::UnityEngine.TextGenerator generator)
        {
            return 0;
        }

        protected int GetCharacterIndexFromPosition(global::UnityEngine.Vector2 pos)
        {
            return 0;
        }

        private bool MayDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
            return false;
        }

        public virtual void OnBeginDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public virtual void OnDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        private global::System.Collections.IEnumerator MouseDragOutsideRect(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
            return null;
        }

        public virtual void OnEndDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public override void OnPointerDown(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        protected global::UnityEngine.UI.InputField.EditState KeyPressed(global::UnityEngine.Event evt)
        {
            return global::UnityEngine.UI.InputField.EditState.Continue;
        }

        private bool IsValidChar(char c)
        {
            return false;
        }

        public void ProcessEvent(global::UnityEngine.Event e)
        {
        }

        public virtual void OnUpdateSelected(global::UnityEngine.EventSystems.BaseEventData eventData)
        {
        }

        private string GetSelectedString()
        {
            return null;
        }

        private int FindtNextWordBegin()
        {
            return 0;
        }

        private void MoveRight(bool shift, bool ctrl)
        {
        }

        private int FindtPrevWordBegin()
        {
            return 0;
        }

        private void MoveLeft(bool shift, bool ctrl)
        {
        }

        private int DetermineCharacterLine(int charPos, global::UnityEngine.TextGenerator generator)
        {
            return 0;
        }

        private int LineUpCharacterPosition(int originalPos, bool goToFirstChar)
        {
            return 0;
        }

        private int LineDownCharacterPosition(int originalPos, bool goToLastChar)
        {
            return 0;
        }

        private void MoveDown(bool shift)
        {
        }

        private void MoveDown(bool shift, bool goToLastChar)
        {
        }

        private void MoveUp(bool shift)
        {
        }

        private void MoveUp(bool shift, bool goToFirstChar)
        {
        }

        private void Delete()
        {
        }

        private void ForwardSpace()
        {
        }

        private void Backspace()
        {
        }

        private void Insert(char c)
        {
        }

        private void UpdateTouchKeyboardFromEditChanges()
        {
        }

        private void SendOnValueChangedAndUpdateLabel()
        {
        }

        private void SendOnValueChanged()
        {
        }

        protected void SendOnSubmit()
        {
        }

        protected virtual void Append(string input)
        {
        }

        protected virtual void Append(char input)
        {
        }

        protected void UpdateLabel()
        {
        }

        private bool IsSelectionVisible()
        {
            return false;
        }

        private static int GetLineStartPosition(global::UnityEngine.TextGenerator gen, int line)
        {
            return 0;
        }

        private static int GetLineEndPosition(global::UnityEngine.TextGenerator gen, int line)
        {
            return 0;
        }

        private void SetDrawRangeToContainCaretPosition(int caretPos)
        {
        }

        public void ForceLabelUpdate()
        {
        }

        private void MarkGeometryAsDirty()
        {
        }

        public virtual void Rebuild(global::UnityEngine.UI.CanvasUpdate update)
        {
        }

        public virtual void LayoutComplete()
        {
        }

        public virtual void GraphicUpdateComplete()
        {
        }

        private void UpdateGeometry()
        {
        }

        private void AssignPositioningIfNeeded()
        {
        }

        private void OnFillVBO(global::UnityEngine.Mesh vbo)
        {
        }

        private void GenerateCaret(global::UnityEngine.UI.VertexHelper vbo, global::UnityEngine.Vector2 roundingOffset)
        {
        }

        private void CreateCursorVerts()
        {
        }

        private void GenerateHighlight(global::UnityEngine.UI.VertexHelper vbo, global::UnityEngine.Vector2 roundingOffset)
        {
        }

        protected char Validate(string text, int pos, char ch)
        {
            return '\0';
        }

        public void ActivateInputField()
        {
        }

        private void ActivateInputFieldInternal()
        {
        }

        public override void OnSelect(global::UnityEngine.EventSystems.BaseEventData eventData)
        {
        }

        public virtual void OnPointerClick(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        public void DeactivateInputField()
        {
        }

        public override void OnDeselect(global::UnityEngine.EventSystems.BaseEventData eventData)
        {
        }

        public virtual void OnSubmit(global::UnityEngine.EventSystems.BaseEventData eventData)
        {
        }

        private void EnforceContentType()
        {
        }

        private void EnforceTextHOverflow()
        {
        }

        private void SetToCustomIfContentTypeIsNot(params global::UnityEngine.UI.InputField.ContentType[] allowedContentTypes)
        {
        }

        private void SetToCustom()
        {
        }

        protected override void DoStateTransition(global::UnityEngine.UI.Selectable.SelectionState state, bool instant)
        {
        }

        public virtual void CalculateLayoutInputHorizontal()
        {
        }

        public virtual void CalculateLayoutInputVertical()
        {
        }
    }
}
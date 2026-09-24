namespace TMPro
{
    public class TMP_InputField : global::UnityEngine.UI.Selectable, global::UnityEngine.EventSystems.IUpdateSelectedHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IBeginDragHandler, global::UnityEngine.EventSystems.IDragHandler, global::UnityEngine.EventSystems.IEndDragHandler, global::UnityEngine.EventSystems.IPointerClickHandler, global::UnityEngine.EventSystems.ISubmitHandler, global::UnityEngine.UI.ICanvasElement, global::UnityEngine.UI.ILayoutElement, global::UnityEngine.EventSystems.IScrollHandler
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
            Digit = 1,
            Integer = 2,
            Decimal = 3,
            Alphanumeric = 4,
            Name = 5,
            Regex = 6,
            EmailAddress = 7,
            CustomValidator = 8
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

        [global::System.Serializable]
        public class SelectionEvent : global::UnityEngine.Events.UnityEvent<string>
        {
        }

        [global::System.Serializable]
        public class TextSelectionEvent : global::UnityEngine.Events.UnityEvent<string, int, int>
        {
        }

        [global::System.Serializable]
        public class TouchScreenKeyboardEvent : global::UnityEngine.Events.UnityEvent<global::UnityEngine.TouchScreenKeyboard.Status>
        {
        }

        protected enum EditState
        {
            Continue = 0,
            Finish = 1
        }

        protected global::UnityEngine.TouchScreenKeyboard m_SoftKeyboard;
        private static readonly char[] kSeparators;
        protected global::UnityEngine.RectTransform m_RectTransform;
        [global::UnityEngine.SerializeField]
        protected global::UnityEngine.RectTransform m_TextViewport;
        protected global::UnityEngine.UI.RectMask2D m_TextComponentRectMask;
        protected global::UnityEngine.UI.RectMask2D m_TextViewportRectMask;
        private global::UnityEngine.Rect m_CachedViewportRect;
        [global::UnityEngine.SerializeField]
        protected global::TMPro.TMP_Text m_TextComponent;
        protected global::UnityEngine.RectTransform m_TextComponentRectTransform;
        [global::UnityEngine.SerializeField]
        protected global::UnityEngine.UI.Graphic m_Placeholder;
        [global::UnityEngine.SerializeField]
        protected global::UnityEngine.UI.Scrollbar m_VerticalScrollbar;
        [global::UnityEngine.SerializeField]
        protected global::TMPro.TMP_ScrollbarEventHandler m_VerticalScrollbarEventHandler;
        private bool m_IsDrivenByLayoutComponents;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.LayoutGroup m_LayoutGroup;
        private global::UnityEngine.EventSystems.IScrollHandler m_IScrollHandlerParent;
        private float m_ScrollPosition;
        [global::UnityEngine.SerializeField]
        protected float m_ScrollSensitivity;
        [global::UnityEngine.SerializeField]
        private global::TMPro.TMP_InputField.ContentType m_ContentType;
        [global::UnityEngine.SerializeField]
        private global::TMPro.TMP_InputField.InputType m_InputType;
        [global::UnityEngine.SerializeField]
        private char m_AsteriskChar;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.TouchScreenKeyboardType m_KeyboardType;
        [global::UnityEngine.SerializeField]
        private global::TMPro.TMP_InputField.LineType m_LineType;
        [global::UnityEngine.SerializeField]
        private bool m_HideMobileInput;
        [global::UnityEngine.SerializeField]
        private bool m_HideSoftKeyboard;
        [global::UnityEngine.SerializeField]
        private global::TMPro.TMP_InputField.CharacterValidation m_CharacterValidation;
        [global::UnityEngine.SerializeField]
        private string m_RegexValue;
        [global::UnityEngine.SerializeField]
        private float m_GlobalPointSize;
        [global::UnityEngine.SerializeField]
        private int m_CharacterLimit;
        [global::UnityEngine.SerializeField]
        private global::TMPro.TMP_InputField.SubmitEvent m_OnEndEdit;
        [global::UnityEngine.SerializeField]
        private global::TMPro.TMP_InputField.SubmitEvent m_OnSubmit;
        [global::UnityEngine.SerializeField]
        private global::TMPro.TMP_InputField.SelectionEvent m_OnSelect;
        [global::UnityEngine.SerializeField]
        private global::TMPro.TMP_InputField.SelectionEvent m_OnDeselect;
        [global::UnityEngine.SerializeField]
        private global::TMPro.TMP_InputField.TextSelectionEvent m_OnTextSelection;
        [global::UnityEngine.SerializeField]
        private global::TMPro.TMP_InputField.TextSelectionEvent m_OnEndTextSelection;
        [global::UnityEngine.SerializeField]
        private global::TMPro.TMP_InputField.OnChangeEvent m_OnValueChanged;
        [global::UnityEngine.SerializeField]
        private global::TMPro.TMP_InputField.TouchScreenKeyboardEvent m_OnTouchScreenKeyboardStatusChanged;
        [global::UnityEngine.SerializeField]
        private global::TMPro.TMP_InputField.OnValidateInput m_OnValidateInput;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Color m_CaretColor;
        [global::UnityEngine.SerializeField]
        private bool m_CustomCaretColor;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Color m_SelectionColor;
        [global::UnityEngine.SerializeField]
        [global::UnityEngine.TextArea]
        protected string m_Text;
        [global::UnityEngine.SerializeField]
        private float m_CaretBlinkRate;
        [global::UnityEngine.SerializeField]
        private int m_CaretWidth;
        [global::UnityEngine.SerializeField]
        private bool m_ReadOnly;
        [global::UnityEngine.SerializeField]
        private bool m_RichText;
        protected int m_StringPosition;
        protected int m_StringSelectPosition;
        protected int m_CaretPosition;
        protected int m_CaretSelectPosition;
        private global::UnityEngine.RectTransform caretRectTrans;
        protected global::UnityEngine.UIVertex[] m_CursorVerts;
        private global::UnityEngine.CanvasRenderer m_CachedInputRenderer;
        private global::UnityEngine.Vector2 m_LastPosition;
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
        private global::UnityEngine.Coroutine m_DragCoroutine;
        private string m_OriginalText;
        private bool m_WasCanceled;
        private bool m_HasDoneFocusTransition;
        private global::UnityEngine.WaitForSecondsRealtime m_WaitForSecondsRealtime;
        private bool m_PreventCallback;
        private bool m_TouchKeyboardAllowsInPlaceEditing;
        private bool m_IsTextComponentUpdateRequired;
        private bool m_isLastKeyBackspace;
        private float m_PointerDownClickStartTime;
        private float m_KeyDownStartTime;
        private float m_DoubleClickDelay;
        private const string kEmailSpecialCharacters = "!#$%&'*+-/=?^_`{|}~";
        private bool m_IsCompositionActive;
        private bool m_ShouldUpdateIMEWindowPosition;
        private int m_PreviousIMEInsertionLine;
        [global::UnityEngine.SerializeField]
        protected global::TMPro.TMP_FontAsset m_GlobalFontAsset;
        [global::UnityEngine.SerializeField]
        protected bool m_OnFocusSelectAll;
        protected bool m_isSelectAll;
        [global::UnityEngine.SerializeField]
        protected bool m_ResetOnDeActivation;
        private bool m_SelectionStillActive;
        private bool m_ReleaseSelection;
        private global::UnityEngine.GameObject m_PreviouslySelectedObject;
        [global::UnityEngine.SerializeField]
        private bool m_RestoreOriginalTextOnEscape;
        [global::UnityEngine.SerializeField]
        protected bool m_isRichTextEditingAllowed;
        [global::UnityEngine.SerializeField]
        protected int m_LineLimit;
        [global::UnityEngine.SerializeField]
        protected global::TMPro.TMP_InputValidator m_InputValidator;
        private bool m_isSelected;
        private bool m_IsStringPositionDirty;
        private bool m_IsCaretPositionDirty;
        private bool m_forceRectTransformAdjustment;
        private global::UnityEngine.Event m_ProcessingEvent;
        private global::UnityEngine.EventSystems.BaseInput inputSystem => null;
        private string compositionString => null;
        private int compositionLength => 0;
        protected global::UnityEngine.Mesh mesh => null;

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

        public bool shouldHideSoftKeyboard
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

        public global::UnityEngine.RectTransform textViewport
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::TMPro.TMP_Text textComponent
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

        public global::UnityEngine.UI.Scrollbar verticalScrollbar
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public float scrollSensitivity
        {
            get
            {
                return 0f;
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

        public global::TMPro.TMP_InputField.SubmitEvent onEndEdit
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::TMPro.TMP_InputField.SubmitEvent onSubmit
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::TMPro.TMP_InputField.SelectionEvent onSelect
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::TMPro.TMP_InputField.SelectionEvent onDeselect
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::TMPro.TMP_InputField.TextSelectionEvent onTextSelection
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::TMPro.TMP_InputField.TextSelectionEvent onEndTextSelection
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::TMPro.TMP_InputField.OnChangeEvent onValueChanged
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::TMPro.TMP_InputField.TouchScreenKeyboardEvent onTouchScreenKeyboardStatusChanged
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public global::TMPro.TMP_InputField.OnValidateInput onValidateInput
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

        public float pointSize
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public global::TMPro.TMP_FontAsset fontAsset
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public bool onFocusSelectAll
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool resetOnDeActivation
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool restoreOriginalTextOnEscape
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool isRichTextEditingAllowed
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public global::TMPro.TMP_InputField.ContentType contentType
        {
            get
            {
                return global::TMPro.TMP_InputField.ContentType.Standard;
            }

            set
            {
            }
        }

        public global::TMPro.TMP_InputField.LineType lineType
        {
            get
            {
                return global::TMPro.TMP_InputField.LineType.SingleLine;
            }

            set
            {
            }
        }

        public int lineLimit
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public global::TMPro.TMP_InputField.InputType inputType
        {
            get
            {
                return global::TMPro.TMP_InputField.InputType.Standard;
            }

            set
            {
            }
        }

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

        public global::TMPro.TMP_InputField.CharacterValidation characterValidation
        {
            get
            {
                return global::TMPro.TMP_InputField.CharacterValidation.None;
            }

            set
            {
            }
        }

        public global::TMPro.TMP_InputValidator inputValidator
        {
            get
            {
                return null;
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

        public bool richText
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

        protected int stringPositionInternal
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

        protected int stringSelectPositionInternal
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

        public int stringPosition
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public int selectionStringAnchorPosition
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public int selectionStringFocusPosition
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

        protected TMP_InputField()
        {
        }

        private bool isKeyboardUsingEvents()
        {
            return false;
        }

        public void SetTextWithoutNotify(string input)
        {
        }

        private void SetText(string value, bool sendCallback = true)
        {
        }

        protected void ClampStringPos(ref int pos)
        {
        }

        protected void ClampCaretPos(ref int pos)
        {
        }

        protected override void OnEnable()
        {
        }

        protected override void OnDisable()
        {
        }

        private void ON_TEXT_CHANGED(global::UnityEngine.Object obj)
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

        public void MoveToEndOfLine(bool shift, bool ctrl)
        {
        }

        public void MoveToStartOfLine(bool shift, bool ctrl)
        {
        }

        private bool InPlaceEditing()
        {
            return false;
        }

        private void UpdateStringPositionFromKeyboard()
        {
        }

        protected virtual void LateUpdate()
        {
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

        protected global::TMPro.TMP_InputField.EditState KeyPressed(global::UnityEngine.Event evt)
        {
            return global::TMPro.TMP_InputField.EditState.Continue;
        }

        protected virtual bool IsValidChar(char c)
        {
            return false;
        }

        public void ProcessEvent(global::UnityEngine.Event e)
        {
        }

        public virtual void OnUpdateSelected(global::UnityEngine.EventSystems.BaseEventData eventData)
        {
        }

        public virtual void OnScroll(global::UnityEngine.EventSystems.PointerEventData eventData)
        {
        }

        private float GetScrollPositionRelativeToViewport()
        {
            return 0f;
        }

        private string GetSelectedString()
        {
            return null;
        }

        private int FindNextWordBegin()
        {
            return 0;
        }

        private void MoveRight(bool shift, bool ctrl)
        {
        }

        private int FindPrevWordBegin()
        {
            return 0;
        }

        private void MoveLeft(bool shift, bool ctrl)
        {
        }

        private int LineUpCharacterPosition(int originalPos, bool goToFirstChar)
        {
            return 0;
        }

        private int LineDownCharacterPosition(int originalPos, bool goToLastChar)
        {
            return 0;
        }

        private int PageUpCharacterPosition(int originalPos, bool goToFirstChar)
        {
            return 0;
        }

        private int PageDownCharacterPosition(int originalPos, bool goToLastChar)
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

        private void MovePageUp(bool shift)
        {
        }

        private void MovePageUp(bool shift, bool goToFirstChar)
        {
        }

        private void MovePageDown(bool shift)
        {
        }

        private void MovePageDown(bool shift, bool goToLastChar)
        {
        }

        private void Delete()
        {
        }

        private void DeleteKey()
        {
        }

        private void Backspace()
        {
        }

        protected virtual void Append(string input)
        {
        }

        protected virtual void Append(char input)
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

        protected void SendOnEndEdit()
        {
        }

        protected void SendOnSubmit()
        {
        }

        protected void SendOnFocus()
        {
        }

        protected void SendOnFocusLost()
        {
        }

        protected void SendOnTextSelection()
        {
        }

        protected void SendOnEndTextSelection()
        {
        }

        protected void SendTouchScreenKeyboardStatusChanged()
        {
        }

        protected void UpdateLabel()
        {
        }

        private void UpdateScrollbar()
        {
        }

        private void OnScrollbarValueChange(float value)
        {
        }

        private void UpdateMaskRegions()
        {
        }

        private void AdjustTextPositionRelativeToViewport(float relativePosition)
        {
        }

        private int GetCaretPositionFromStringIndex(int stringIndex)
        {
            return 0;
        }

        private int GetMinCaretPositionFromStringIndex(int stringIndex)
        {
            return 0;
        }

        private int GetMaxCaretPositionFromStringIndex(int stringIndex)
        {
            return 0;
        }

        private int GetStringIndexFromCaretPosition(int caretPosition)
        {
            return 0;
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

        private void GenerateHightlight(global::UnityEngine.UI.VertexHelper vbo, global::UnityEngine.Vector2 roundingOffset)
        {
        }

        private void AdjustRectTransformRelativeToViewport(global::UnityEngine.Vector2 startPosition, float height, bool isCharVisible)
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

        public void OnControlClick()
        {
        }

        public void ReleaseSelection()
        {
        }

        public void DeactivateInputField(bool clearSelection = false)
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

        private void SetTextComponentWrapMode()
        {
        }

        private void SetTextComponentRichTextMode()
        {
        }

        private void SetToCustomIfContentTypeIsNot(params global::TMPro.TMP_InputField.ContentType[] allowedContentTypes)
        {
        }

        private void SetToCustom()
        {
        }

        private void SetToCustom(global::TMPro.TMP_InputField.CharacterValidation characterValidation)
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

        public void SetGlobalPointSize(float pointSize)
        {
        }

        public void SetGlobalFontAsset(global::TMPro.TMP_FontAsset fontAsset)
        {
        }
    }
}
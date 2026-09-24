namespace UnityEngine.InputSystem
{
    [global::UnityEngine.InputSystem.Layouts.InputControlLayout]
    public class Keyboard : global::UnityEngine.InputSystem.InputDevice, global::UnityEngine.InputSystem.LowLevel.ITextInputReceiver
    {
        public const int KeyCount = 110;
        private global::UnityEngine.InputSystem.Utilities.InlinedArray<global::System.Action<char>> m_TextInputListeners;
        private string m_KeyboardLayoutName;
        private global::UnityEngine.InputSystem.Controls.KeyControl[] m_Keys;
        private global::UnityEngine.InputSystem.Utilities.InlinedArray<global::System.Action<global::UnityEngine.InputSystem.LowLevel.IMECompositionString>> m_ImeCompositionListeners;
        public string keyboardLayout
        {
            get
            {
                return null;
            }

            protected set
            {
            }
        }

        public global::UnityEngine.InputSystem.Controls.AnyKeyControl anyKey { get; protected set; }
        public global::UnityEngine.InputSystem.Controls.KeyControl spaceKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl enterKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl tabKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl backquoteKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl quoteKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl semicolonKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl commaKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl periodKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl slashKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl backslashKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl leftBracketKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl rightBracketKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl minusKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl equalsKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl aKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl bKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl cKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl dKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl eKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl fKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl gKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl hKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl iKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl jKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl kKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl lKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl mKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl nKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl oKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl pKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl qKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl rKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl sKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl tKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl uKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl vKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl wKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl xKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl yKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl zKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl digit1Key => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl digit2Key => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl digit3Key => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl digit4Key => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl digit5Key => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl digit6Key => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl digit7Key => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl digit8Key => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl digit9Key => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl digit0Key => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl leftShiftKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl rightShiftKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl leftAltKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl rightAltKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl leftCtrlKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl rightCtrlKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl leftMetaKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl rightMetaKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl leftWindowsKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl rightWindowsKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl leftAppleKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl rightAppleKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl leftCommandKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl rightCommandKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl contextMenuKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl escapeKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl leftArrowKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl rightArrowKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl upArrowKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl downArrowKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl backspaceKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl pageDownKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl pageUpKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl homeKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl endKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl insertKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl deleteKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl capsLockKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl scrollLockKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl numLockKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl printScreenKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl pauseKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl numpadEnterKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl numpadDivideKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl numpadMultiplyKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl numpadMinusKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl numpadPlusKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl numpadPeriodKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl numpadEqualsKey => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl numpad0Key => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl numpad1Key => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl numpad2Key => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl numpad3Key => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl numpad4Key => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl numpad5Key => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl numpad6Key => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl numpad7Key => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl numpad8Key => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl numpad9Key => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl f1Key => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl f2Key => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl f3Key => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl f4Key => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl f5Key => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl f6Key => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl f7Key => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl f8Key => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl f9Key => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl f10Key => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl f11Key => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl f12Key => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl oem1Key => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl oem2Key => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl oem3Key => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl oem4Key => null;
        public global::UnityEngine.InputSystem.Controls.KeyControl oem5Key => null;
        public global::UnityEngine.InputSystem.Controls.ButtonControl shiftKey { get; protected set; }
        public global::UnityEngine.InputSystem.Controls.ButtonControl ctrlKey { get; protected set; }
        public global::UnityEngine.InputSystem.Controls.ButtonControl altKey { get; protected set; }
        public global::UnityEngine.InputSystem.Controls.ButtonControl imeSelected { get; protected set; }

        // C# has no syntax for parameterized property 'Item'.
        public global::UnityEngine.InputSystem.Controls.KeyControl this[global::UnityEngine.InputSystem.Key key]
        {
            get
            {
                return null;
            }
        }

        public global::UnityEngine.InputSystem.Utilities.ReadOnlyArray<global::UnityEngine.InputSystem.Controls.KeyControl> allKeys => default;
        public static global::UnityEngine.InputSystem.Keyboard current { get; private set; }

        protected global::UnityEngine.InputSystem.Controls.KeyControl[] keys
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public event global::System.Action<char> onTextInput
        {
            add
            {
            }

            remove
            {
            }
        }

        public event global::System.Action<global::UnityEngine.InputSystem.LowLevel.IMECompositionString> onIMECompositionChange
        {
            add
            {
            }

            remove
            {
            }
        }

        public void SetIMEEnabled(bool enabled)
        {
        }

        public void SetIMECursorPosition(global::UnityEngine.Vector2 position)
        {
        }

        public override void MakeCurrent()
        {
        }

        protected override void OnRemoved()
        {
        }

        protected override void FinishSetup()
        {
        }

        protected override void RefreshConfiguration()
        {
        }

        public void OnTextInput(char character)
        {
        }

        public global::UnityEngine.InputSystem.Controls.KeyControl FindKeyOnCurrentKeyboardLayout(string displayName)
        {
            return null;
        }

        public void OnIMECompositionChanged(global::UnityEngine.InputSystem.LowLevel.IMECompositionString compositionString)
        {
        }
    }
}
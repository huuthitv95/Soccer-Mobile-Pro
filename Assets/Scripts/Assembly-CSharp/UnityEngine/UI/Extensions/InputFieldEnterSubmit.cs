namespace UnityEngine.UI.Extensions
{
    public class InputFieldEnterSubmit : global::UnityEngine.MonoBehaviour
    {
        [global::System.Serializable]
        public class EnterSubmitEvent : global::UnityEngine.Events.UnityEvent<string>
        {
        }

        public global::UnityEngine.UI.Extensions.InputFieldEnterSubmit.EnterSubmitEvent EnterSubmit;
        private global::UnityEngine.UI.InputField _input;
        private void Awake()
        {
        }

        public void OnEndEdit(string txt)
        {
        }
    }
}
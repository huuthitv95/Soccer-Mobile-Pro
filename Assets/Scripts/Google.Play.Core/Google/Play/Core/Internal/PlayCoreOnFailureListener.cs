namespace Google.Play.Core.Internal
{
    public class PlayCoreOnFailureListener : global::UnityEngine.AndroidJavaProxy
    {
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action<string, int> m_OnTaskFailed;
        public event global::System.Action<string, int> OnTaskFailed
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

        public PlayCoreOnFailureListener() : base((string)null)
        {
        }

        public void onFailure(global::UnityEngine.AndroidJavaObject exception)
        {
        }
    }
}
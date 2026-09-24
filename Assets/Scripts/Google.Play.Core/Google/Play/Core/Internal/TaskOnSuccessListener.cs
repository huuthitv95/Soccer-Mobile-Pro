namespace Google.Play.Core.Internal
{
    public class TaskOnSuccessListener<TAndroidJava> : global::UnityEngine.AndroidJavaProxy
    {
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action<TAndroidJava> m_OnTaskSucceeded;
        public event global::System.Action<TAndroidJava> OnTaskSucceeded
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

        public TaskOnSuccessListener() : base((string)null)
        {
        }

        public void onSuccess(TAndroidJava result)
        {
        }
    }
}
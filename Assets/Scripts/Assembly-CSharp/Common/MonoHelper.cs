namespace Common
{
    public class MonoHelper : MonoSingleton<global::Common.MonoHelper>
    {
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::Common.MonoUpdaterEvent m_UpdateEvent;
        private static int _mainThreadId;
        private static global::System.Collections.Generic.List<global::System.Func<bool>> mainThreadTasks;
        private static global::System.Collections.Generic.List<global::System.Func<bool>> executeTasks;
        private static bool _hasNewEvent;
        private event global::Common.MonoUpdaterEvent UpdateEvent
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

        private void Start()
        {
        }

        public static void AddUpdateListener(global::Common.MonoUpdaterEvent listener)
        {
        }

        public static void RemoveUpdateListener(global::Common.MonoUpdaterEvent listener)
        {
        }

        public static void AddTaskToMainThread(global::System.Action task)
        {
        }

        public static void RunTaskInMainThread(global::System.Action task)
        {
        }

        public static void AddTaskToMainThread(global::System.Func<bool> task)
        {
        }

        protected override void Initial()
        {
        }

        private void OnUpdate()
        {
        }

        public new static global::UnityEngine.Coroutine StartCoroutine(global::System.Collections.IEnumerator routine)
        {
            return null;
        }

        public new static void StopCoroutine(global::UnityEngine.Coroutine routine)
        {
        }

        public static global::System.Collections.IEnumerator delaySetActive(global::UnityEngine.GameObject go, float time, bool enable)
        {
            return null;
        }

        public static global::System.Collections.IEnumerator delayAction(float time, global::System.Action action)
        {
            return null;
        }
    }
}
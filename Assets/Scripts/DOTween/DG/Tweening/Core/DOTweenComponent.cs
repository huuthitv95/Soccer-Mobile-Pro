namespace DG.Tweening.Core
{
    public class DOTweenComponent : global::UnityEngine.MonoBehaviour, global::DG.Tweening.IDOTweenInit
    {
        public int inspectorUpdater;
        private float _unscaledTime;
        private float _unscaledDeltaTime;
        private bool _paused;
        private float _pausedTime;
        private bool _duplicateToDestroy;
        private void Awake()
        {
        }

        private void Start()
        {
        }

        private void Update()
        {
        }

        private void LateUpdate()
        {
        }

        private void FixedUpdate()
        {
        }

        private void OnDrawGizmos()
        {
        }

        private void OnDestroy()
        {
        }

        public void OnApplicationPause(bool pauseStatus)
        {
        }

        public global::DG.Tweening.IDOTweenInit SetCapacity(int tweenersCapacity, int sequencesCapacity)
        {
            return null;
        }

        internal global::System.Collections.IEnumerator WaitForCompletion(global::DG.Tweening.Tween t)
        {
            return null;
        }

        internal global::System.Collections.IEnumerator WaitForRewind(global::DG.Tweening.Tween t)
        {
            return null;
        }

        internal global::System.Collections.IEnumerator WaitForKill(global::DG.Tweening.Tween t)
        {
            return null;
        }

        internal global::System.Collections.IEnumerator WaitForElapsedLoops(global::DG.Tweening.Tween t, int elapsedLoops)
        {
            return null;
        }

        internal global::System.Collections.IEnumerator WaitForPosition(global::DG.Tweening.Tween t, float position)
        {
            return null;
        }

        internal global::System.Collections.IEnumerator WaitForStart(global::DG.Tweening.Tween t)
        {
            return null;
        }

        internal static void Create()
        {
        }

        internal static void DestroyInstance()
        {
        }
    }
}
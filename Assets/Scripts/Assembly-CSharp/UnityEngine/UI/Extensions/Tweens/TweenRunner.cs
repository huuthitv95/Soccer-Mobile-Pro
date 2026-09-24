namespace UnityEngine.UI.Extensions.Tweens
{
    internal class TweenRunner<T>
        where T : struct, global::UnityEngine.UI.Extensions.Tweens.ITweenValue
    {
        protected global::UnityEngine.MonoBehaviour m_CoroutineContainer;
        protected global::System.Collections.IEnumerator m_Tween;
        private static global::System.Collections.IEnumerator Start(T tweenInfo)
        {
            return null;
        }

        public void Init(global::UnityEngine.MonoBehaviour coroutineContainer)
        {
        }

        public void StartTween(T info)
        {
        }
    }
}
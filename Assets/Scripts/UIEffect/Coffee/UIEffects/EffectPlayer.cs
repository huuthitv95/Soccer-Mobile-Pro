namespace Coffee.UIEffects
{
    [global::System.Serializable]
    public class EffectPlayer
    {
        public bool play;
        public float initialPlayDelay;
        public float duration;
        public bool loop;
        public float loopDelay;
        public global::UnityEngine.AnimatorUpdateMode updateMode;
        private static global::System.Collections.Generic.List<global::System.Action> s_UpdateActions;
        private float _time;
        private global::System.Action<float> _callback;
        public void OnEnable(global::System.Action<float> callback = null)
        {
        }

        public void OnDisable()
        {
        }

        public void Play(bool reset, global::System.Action<float> callback = null)
        {
        }

        public void Stop(bool reset)
        {
        }

        private void OnWillRenderCanvases()
        {
        }
    }
}
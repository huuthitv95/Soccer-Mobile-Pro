namespace Coffee.UIEffects
{
    [global::System.Serializable]
    public class ParameterTexture
    {
        private global::UnityEngine.Texture2D _texture;
        private bool _needUpload;
        private int _propertyId;
        private readonly string _propertyName;
        private readonly int _channels;
        private readonly int _instanceLimit;
        private readonly byte[] _data;
        private readonly global::System.Collections.Generic.Stack<int> _stack;
        private static global::System.Collections.Generic.List<global::System.Action> updates;
        public ParameterTexture(int channels, int instanceLimit, string propertyName)
        {
        }

        public void Register(global::Coffee.UIEffects.IParameterTexture target)
        {
        }

        public void Unregister(global::Coffee.UIEffects.IParameterTexture target)
        {
        }

        public void SetData(global::Coffee.UIEffects.IParameterTexture target, int channelId, byte value)
        {
        }

        public void SetData(global::Coffee.UIEffects.IParameterTexture target, int channelId, float value)
        {
        }

        public void RegisterMaterial(global::UnityEngine.Material mat)
        {
        }

        public float GetNormalizedIndex(global::Coffee.UIEffects.IParameterTexture target)
        {
            return 0f;
        }

        private void Initialize()
        {
        }

        private void UpdateParameterTexture()
        {
        }
    }
}
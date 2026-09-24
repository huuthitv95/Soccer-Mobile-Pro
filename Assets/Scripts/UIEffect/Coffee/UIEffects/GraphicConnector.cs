namespace Coffee.UIEffects
{
    public class GraphicConnector
    {
        private static readonly global::System.Collections.Generic.List<global::Coffee.UIEffects.GraphicConnector> s_Connectors;
        private static readonly global::System.Collections.Generic.Dictionary<global::System.Type, global::Coffee.UIEffects.GraphicConnector> s_ConnectorMap;
        private static readonly global::Coffee.UIEffects.GraphicConnector s_EmptyConnector;
        protected virtual int priority => 0;
        public virtual global::UnityEngine.AdditionalCanvasShaderChannels extraChannel => global::UnityEngine.AdditionalCanvasShaderChannels.None;

        private static void Init()
        {
        }

        protected static void AddConnector(global::Coffee.UIEffects.GraphicConnector connector)
        {
        }

        public static global::Coffee.UIEffects.GraphicConnector FindConnector(global::UnityEngine.UI.Graphic graphic)
        {
            return null;
        }

        protected virtual bool IsValid(global::UnityEngine.UI.Graphic graphic)
        {
            return false;
        }

        public virtual global::UnityEngine.Shader FindShader(string shaderName)
        {
            return null;
        }

        public virtual void OnEnable(global::UnityEngine.UI.Graphic graphic)
        {
        }

        public virtual void OnDisable(global::UnityEngine.UI.Graphic graphic)
        {
        }

        public virtual void SetVerticesDirty(global::UnityEngine.UI.Graphic graphic)
        {
        }

        public virtual void SetMaterialDirty(global::UnityEngine.UI.Graphic graphic)
        {
        }

        public virtual void GetPositionFactor(global::Coffee.UIEffects.EffectArea area, int index, global::UnityEngine.Rect rect, global::UnityEngine.Vector2 position, out float x, out float y)
        {
            x = default;
            y = default;
        }

        public virtual bool IsText(global::UnityEngine.UI.Graphic graphic)
        {
            return false;
        }

        public virtual void SetExtraChannel(ref global::UnityEngine.UIVertex vertex, global::UnityEngine.Vector2 value)
        {
        }

        public virtual void GetNormalizedFactor(global::Coffee.UIEffects.EffectArea area, int index, global::Coffee.UIEffects.Matrix2x3 matrix, global::UnityEngine.Vector2 position, out global::UnityEngine.Vector2 normalizedPos)
        {
            normalizedPos = default;
        }
    }
}
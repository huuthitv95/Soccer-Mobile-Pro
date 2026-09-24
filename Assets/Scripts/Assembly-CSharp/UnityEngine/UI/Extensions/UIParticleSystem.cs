namespace UnityEngine.UI.Extensions
{
    public class UIParticleSystem : global::UnityEngine.UI.MaskableGraphic
    {
        public bool fixedTime;
        private global::UnityEngine.Transform _transform;
        private global::UnityEngine.ParticleSystem pSystem;
        private global::UnityEngine.ParticleSystem.Particle[] particles;
        private global::UnityEngine.UIVertex[] _quad;
        private global::UnityEngine.Vector4 imageUV;
        private global::UnityEngine.ParticleSystem.TextureSheetAnimationModule textureSheetAnimation;
        private int textureSheetAnimationFrames;
        private global::UnityEngine.Vector2 textureSheetAnimationFrameSize;
        private global::UnityEngine.ParticleSystemRenderer pRenderer;
        private global::UnityEngine.Material currentMaterial;
        private global::UnityEngine.Texture currentTexture;
        private global::UnityEngine.ParticleSystem.MainModule mainModule;
        public override global::UnityEngine.Texture mainTexture => null;

        protected bool Initialize()
        {
            return false;
        }

        protected override void Awake()
        {
        }

        protected override void OnPopulateMesh(global::UnityEngine.UI.VertexHelper vh)
        {
        }

        private void Update()
        {
        }

        private void LateUpdate()
        {
        }
    }
}
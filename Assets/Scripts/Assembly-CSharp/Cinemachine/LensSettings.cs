namespace Cinemachine
{
    [global::System.Serializable]
    public struct LensSettings
    {
        public static global::Cinemachine.LensSettings Default;
        public float FieldOfView;
        public float OrthographicSize;
        public float NearClipPlane;
        public float FarClipPlane;
        public float Dutch;
        internal bool Orthographic { get; set; }
        internal float Aspect { get; set; }

        public static global::Cinemachine.LensSettings FromCamera(global::UnityEngine.Camera fromCamera)
        {
            return default;
        }

        public LensSettings(float fov, float orthographicSize, float nearClip, float farClip, float dutch, bool ortho, float aspect)
        {
            FieldOfView = 0f;
            OrthographicSize = 0f;
            NearClipPlane = 0f;
            FarClipPlane = 0f;
            Dutch = 0f;
            Orthographic = false;
            Aspect = 0f;
        }

        public static global::Cinemachine.LensSettings Lerp(global::Cinemachine.LensSettings lensA, global::Cinemachine.LensSettings lensB, float t)
        {
            return default;
        }

        public void Validate()
        {
        }
    }
}
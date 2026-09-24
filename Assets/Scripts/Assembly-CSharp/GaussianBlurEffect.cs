public class GaussianBlurEffect : IScreenEffect
{
    public bool initialized;
    private static global::UnityEngine.Material material;
    private int sampleCount;
    public sbyte Order { get; private set; }
    public ScreenEffects.EffectType EffectType => ScreenEffects.EffectType.None;
    public bool Enable { get; set; }
    public global::UnityEngine.RenderTexture target { get; private set; }

    public global::UnityEngine.RenderTexture Process(global::UnityEngine.RenderTexture source, global::UnityEngine.RenderTexture destination)
    {
        return null;
    }

    public GaussianBlurEffect(int downsample, int sampleCount = 1, sbyte order = 0, bool enable = false)
    {
    }

    public void DrawBlurEffect(global::UnityEngine.Camera camera)
    {
    }
}
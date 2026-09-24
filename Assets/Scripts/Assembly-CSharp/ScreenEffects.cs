public class ScreenEffects : global::UnityEngine.MonoBehaviour
{
    public enum EffectType
    {
        None = 0,
        GaussianBlur = 1
    }

    private global::System.Collections.Generic.List<IScreenEffect> effects;
    public void AddEffect(IScreenEffect effect)
    {
    }

    public void RemoveEffect(IScreenEffect effect)
    {
    }

    private void OnRenderImage(global::UnityEngine.RenderTexture source, global::UnityEngine.RenderTexture destination)
    {
    }
}
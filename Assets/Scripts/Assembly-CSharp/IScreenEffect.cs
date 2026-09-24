public interface IScreenEffect
{
	sbyte Order { get; }

	ScreenEffects.EffectType EffectType { get; }

	bool Enable { get; set; }

	global::UnityEngine.RenderTexture Process(global::UnityEngine.RenderTexture source, global::UnityEngine.RenderTexture destination);
}

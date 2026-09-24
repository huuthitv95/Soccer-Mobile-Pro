public class Tween_WindowClose : WindowTweenBase
{
	[global::UnityEngine.SerializeField]
	private global::UnityEngine.CanvasGroup root;

	[global::UnityEngine.SerializeField]
	private bool isCloseTween;

	protected override bool IsCloseTween => false;

	public override global::DG.Tweening.Sequence CreateSequence()
	{
		return null;
	}
}

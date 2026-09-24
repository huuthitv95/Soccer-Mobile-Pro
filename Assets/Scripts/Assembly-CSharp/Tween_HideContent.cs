public class Tween_HideContent : WindowTweenBase
{
	[global::UnityEngine.SerializeField]
	private global::UnityEngine.GameObject content;

	[global::UnityEngine.SerializeField]
	private bool isCloseTween;

	protected override bool IsCloseTween => false;

	public override global::DG.Tweening.Sequence CreateSequence()
	{
		return null;
	}
}

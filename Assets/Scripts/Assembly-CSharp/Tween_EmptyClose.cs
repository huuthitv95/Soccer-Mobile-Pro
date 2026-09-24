public class Tween_EmptyClose : WindowTweenBase
{
	[global::UnityEngine.SerializeField]
	private bool isCloseTween;

	protected override bool IsCloseTween => false;

	public override global::DG.Tweening.Sequence CreateSequence()
	{
		return null;
	}
}

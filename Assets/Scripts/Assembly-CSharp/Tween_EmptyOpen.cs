public class Tween_EmptyOpen : WindowTweenBase
{
	[global::UnityEngine.SerializeField]
	private bool isOpenTween;

	protected override bool IsOpenTween => false;

	public override global::DG.Tweening.Sequence CreateSequence()
	{
		return null;
	}
}

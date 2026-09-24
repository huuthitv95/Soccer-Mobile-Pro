public class Tween_WindowOpen : WindowTweenBase
{
	[global::UnityEngine.SerializeField]
	private global::UnityEngine.GameObject content;

	[global::UnityEngine.SerializeField]
	private global::UnityEngine.UI.MaskableGraphic maskBG;

	[global::UnityEngine.SerializeField]
	private global::UnityEngine.UI.Image whiteMask;

	[global::UnityEngine.SerializeField]
	private bool isOpenTween;

	protected override bool IsOpenTween => false;

	public override global::DG.Tweening.Sequence CreateSequence()
	{
		return null;
	}
}

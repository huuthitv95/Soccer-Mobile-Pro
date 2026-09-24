public class Tween_ShowContent : WindowTweenBase
{
	[global::UnityEngine.SerializeField]
	private global::UnityEngine.Color maskStartColor;

	[global::UnityEngine.SerializeField]
	private global::UnityEngine.Color maskEndColor;

	[global::UnityEngine.SerializeField]
	private global::UnityEngine.UI.Image mask;

	[global::UnityEngine.SerializeField]
	private global::UnityEngine.GameObject content;

	[global::UnityEngine.SerializeField]
	private bool isOpenTween;

	[global::UnityEngine.SerializeField]
	private bool generateMask;

	[global::UnityEngine.SerializeField]
	private global::UnityEngine.Vector2 maskOffset;

	protected override bool IsOpenTween => false;

	public override global::DG.Tweening.Sequence CreateSequence()
	{
		return null;
	}
}

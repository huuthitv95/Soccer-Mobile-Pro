public class TransferClothTimeline : TimelinePlayable
{
	[global::UnityEngine.SerializeField]
	private global::UnityEngine.GameObject playerNode;

	[global::UnityEngine.SerializeField]
	private global::UnityEngine.Playables.PlayableDirector playableDirector;

	[global::UnityEngine.SerializeField]
	private global::UnityEngine.Renderer jerseyRenderer;

	protected override global::UnityEngine.Playables.PlayableDirector Director => null;

	public global::UnityEngine.GameObject PlayerNode => null;

	public global::UnityEngine.Renderer JerseyRenderer => null;

	public bool BindPlayerTrack(global::UnityEngine.Animator animator)
	{
		return false;
	}
}

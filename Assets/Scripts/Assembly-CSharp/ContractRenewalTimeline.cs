public class ContractRenewalTimeline : TimelinePlayable
{
	[global::UnityEngine.SerializeField]
	private global::UnityEngine.GameObject playerNode;

	[global::UnityEngine.SerializeField]
	private global::UnityEngine.Playables.PlayableDirector contractRenewalTimeline;

	[global::UnityEngine.SerializeField]
	public global::UnityEngine.GameObject pen;

	[global::UnityEngine.SerializeField]
	public global::UnityEngine.GameObject placeHolderPlayer;

	protected override global::UnityEngine.Playables.PlayableDirector Director => null;

	public global::UnityEngine.GameObject PlayerNode => null;

	public bool BindPlayerTrack(global::UnityEngine.Animator animator)
	{
		return false;
	}
}

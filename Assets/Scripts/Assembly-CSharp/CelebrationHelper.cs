public class CelebrationHelper
{
	public class OptionalInfo
	{
		public float rotationOffsetByPosition;

		public bool normalMirrorRule;

		public bool disableCameraMirror;

		public CelebrationHelper.MultiplayerAnimationInfo? secondStage;
	}

	public struct MultiplayerAnimationInfo
	{
		public string[] animationNames;

		public global::UnityEngine.Vector3[] posOffset;

		public global::UnityEngine.Quaternion[] RelativeRotation;

		public global::System.Func<TimelinePlayerControler, global::System.Collections.Generic.List<TimelinePlayerControler>, int, global::System.Collections.Generic.List<TimelinePlayerControler>> findMate;

		public bool needWaveAnim;

		public global::UnityEngine.Vector2 CameraOffset;

		public global::UnityEngine.Quaternion rotationOffset;

		public global::UnityEngine.Quaternion cameraRotationOffset;

		public global::UnityEngine.Vector3 basePlayerPosOffset;

		public global::UnityEngine.Quaternion basePlayerRotOffset;

		public float Fov;

		public CelebrationHelper.OptionalInfo optionalInfo;

		public bool HasBasePlayerOffset => false;

		public MultiplayerAnimationInfo(string[] animationNames, global::UnityEngine.Vector3[] posOffset, global::UnityEngine.Quaternion[] RelativeRotation, global::System.Func<TimelinePlayerControler, global::System.Collections.Generic.List<TimelinePlayerControler>, int, global::System.Collections.Generic.List<TimelinePlayerControler>> findMate, global::UnityEngine.Vector3 CameraOffset, bool needWaveAnim, global::UnityEngine.Quaternion rotationOffset, global::UnityEngine.Quaternion cameraRotationOffset, global::UnityEngine.Vector3 basePlayerPosOffset, global::UnityEngine.Quaternion basePlayerRotOffset, float fov, CelebrationHelper.OptionalInfo optionalInfo = null)
		{
			this.animationNames = null;
			this.posOffset = null;
			this.RelativeRotation = null;
			this.findMate = null;
			this.needWaveAnim = false;
			this.CameraOffset = default;
			this.rotationOffset = default;
			this.cameraRotationOffset = default;
			this.basePlayerPosOffset = default;
			this.basePlayerRotOffset = default;
			Fov = 0f;
			this.optionalInfo = null;
		}
	}

	private static global::System.Func<TimelinePlayerControler, global::System.Collections.Generic.List<TimelinePlayerControler>, int, global::System.Collections.Generic.List<TimelinePlayerControler>> findMate;

	public static CelebrationHelper.MultiplayerAnimationInfo[] TeamAnimationInfos;

	public static readonly string[] FemaleAnims;

	public CelebrationHelper.MultiplayerAnimationInfo animInfo;

	public global::System.Collections.Generic.List<CelebrationMate> mate;

	public static bool IsFemaleAnim(string anim)
	{
		return false;
	}

	public global::UnityEngine.Vector3 GetMatePosition(int idx)
	{
		return default;
	}

	public global::UnityEngine.Quaternion GetMateQuaternion(int idx)
	{
		return default;
	}

	public string GetMateAnimation(int idx)
	{
		return null;
	}

	public string getScorerAnimation()
	{
		return null;
	}

	public static CelebrationHelper Create(TimelinePlayerControler scorer, global::System.Collections.Generic.List<TimelinePlayerControler> others)
	{
		return null;
	}
}

namespace Cinemachine
{
	[global::System.Serializable]
	public sealed class CinemachineBlenderSettings : global::UnityEngine.ScriptableObject
	{
		[global::System.Serializable]
		public struct CustomBlend
		{
			public string m_From;

			public string m_To;

			public global::Cinemachine.CinemachineBlendDefinition m_Blend;
		}

		public global::Cinemachine.CinemachineBlenderSettings.CustomBlend[] m_CustomBlends;

		public const string kBlendFromAnyCameraLabel = "**ANY CAMERA**";

		public global::UnityEngine.AnimationCurve GetBlendCurveForVirtualCameras(string fromCameraName, string toCameraName, global::UnityEngine.AnimationCurve defaultCurve)
		{
			return null;
		}
	}
}

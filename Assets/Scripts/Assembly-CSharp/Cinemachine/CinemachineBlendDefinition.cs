namespace Cinemachine
{
	[global::System.Serializable]
	public struct CinemachineBlendDefinition
	{
		public enum Style
		{
			Cut = 0,
			EaseInOut = 1,
			EaseIn = 2,
			EaseOut = 3,
			HardIn = 4,
			HardOut = 5,
			Linear = 6
		}

		public global::Cinemachine.CinemachineBlendDefinition.Style m_Style;

		public float m_Time;

		public global::UnityEngine.AnimationCurve BlendCurve => null;

		public CinemachineBlendDefinition(global::Cinemachine.CinemachineBlendDefinition.Style style, float time)
		{
			m_Style = global::Cinemachine.CinemachineBlendDefinition.Style.Cut;
			m_Time = 0f;
		}
	}
}

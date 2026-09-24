namespace Coffee.UISoftMaskInternal
{
	[global::System.Serializable]
	public struct MinMax01
	{
		[global::UnityEngine.SerializeField]
		private float m_Min;

		[global::UnityEngine.SerializeField]
		private float m_Max;

		public float min
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float max
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float average => 0f;

		public MinMax01(float min, float max)
		{
			m_Min = 0f;
			m_Max = 0f;
		}

		public bool Approximately(global::Coffee.UISoftMaskInternal.MinMax01 other)
		{
			return false;
		}
	}
}

namespace UnityEngine.TextCore
{
	[global::System.Serializable]
	[global::UnityEngine.Scripting.UsedByNativeCode]
	public struct GlyphMetrics : global::System.IEquatable<global::UnityEngine.TextCore.GlyphMetrics>
	{
		[global::UnityEngine.SerializeField]
		private float m_Width;

		[global::UnityEngine.SerializeField]
		private float m_Height;

		[global::UnityEngine.SerializeField]
		private float m_HorizontalBearingX;

		[global::UnityEngine.SerializeField]
		private float m_HorizontalBearingY;

		[global::UnityEngine.SerializeField]
		private float m_HorizontalAdvance;

		public float width => 0f;

		public float height => 0f;

		public float horizontalBearingX => 0f;

		public float horizontalBearingY => 0f;

		public float horizontalAdvance => 0f;

		public GlyphMetrics(float width, float height, float bearingX, float bearingY, float advance)
		{
			m_Width = 0f;
			m_Height = 0f;
			m_HorizontalBearingX = 0f;
			m_HorizontalBearingY = 0f;
			m_HorizontalAdvance = 0f;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(global::UnityEngine.TextCore.GlyphMetrics other)
		{
			return false;
		}
	}
}

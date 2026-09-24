namespace TMPro
{
	[global::System.Serializable]
	public struct TMP_GlyphValueRecord
	{
		[global::UnityEngine.SerializeField]
		internal float m_XPlacement;

		[global::UnityEngine.SerializeField]
		internal float m_YPlacement;

		[global::UnityEngine.SerializeField]
		internal float m_XAdvance;

		[global::UnityEngine.SerializeField]
		internal float m_YAdvance;

		public float xPlacement
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float yPlacement
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float xAdvance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float yAdvance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public TMP_GlyphValueRecord(float xPlacement, float yPlacement, float xAdvance, float yAdvance)
		{
			m_XPlacement = 0f;
			m_YPlacement = 0f;
			m_XAdvance = 0f;
			m_YAdvance = 0f;
		}

		internal TMP_GlyphValueRecord(global::TMPro.GlyphValueRecord_Legacy valueRecord)
		{
			m_XPlacement = 0f;
			m_YPlacement = 0f;
			m_XAdvance = 0f;
			m_YAdvance = 0f;
		}

		internal TMP_GlyphValueRecord(global::UnityEngine.TextCore.LowLevel.GlyphValueRecord valueRecord)
		{
			m_XPlacement = 0f;
			m_YPlacement = 0f;
			m_XAdvance = 0f;
			m_YAdvance = 0f;
		}

		public static global::TMPro.TMP_GlyphValueRecord operator +(global::TMPro.TMP_GlyphValueRecord a, global::TMPro.TMP_GlyphValueRecord b)
		{
			return default;
		}
	}
}

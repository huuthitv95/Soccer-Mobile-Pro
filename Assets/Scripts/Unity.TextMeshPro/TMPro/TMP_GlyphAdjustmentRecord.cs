namespace TMPro
{
	[global::System.Serializable]
	public struct TMP_GlyphAdjustmentRecord
	{
		[global::UnityEngine.SerializeField]
		internal uint m_GlyphIndex;

		[global::UnityEngine.SerializeField]
		internal global::TMPro.TMP_GlyphValueRecord m_GlyphValueRecord;

		public uint glyphIndex
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public global::TMPro.TMP_GlyphValueRecord glyphValueRecord
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public TMP_GlyphAdjustmentRecord(uint glyphIndex, global::TMPro.TMP_GlyphValueRecord glyphValueRecord)
		{
			m_GlyphIndex = 0u;
			m_GlyphValueRecord = default;
		}

		internal TMP_GlyphAdjustmentRecord(global::UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord adjustmentRecord)
		{
			m_GlyphIndex = 0u;
			m_GlyphValueRecord = default;
		}
	}
}

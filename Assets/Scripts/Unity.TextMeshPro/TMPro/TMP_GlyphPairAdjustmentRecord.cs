namespace TMPro
{
	[global::System.Serializable]
	public class TMP_GlyphPairAdjustmentRecord
	{
		[global::UnityEngine.SerializeField]
		internal global::TMPro.TMP_GlyphAdjustmentRecord m_FirstAdjustmentRecord;

		[global::UnityEngine.SerializeField]
		internal global::TMPro.TMP_GlyphAdjustmentRecord m_SecondAdjustmentRecord;

		[global::UnityEngine.SerializeField]
		internal global::TMPro.FontFeatureLookupFlags m_FeatureLookupFlags;

		public global::TMPro.TMP_GlyphAdjustmentRecord firstAdjustmentRecord
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public global::TMPro.TMP_GlyphAdjustmentRecord secondAdjustmentRecord
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public global::TMPro.FontFeatureLookupFlags featureLookupFlags
		{
			get
			{
				return global::TMPro.FontFeatureLookupFlags.None;
			}
			set
			{
			}
		}

		public TMP_GlyphPairAdjustmentRecord(global::TMPro.TMP_GlyphAdjustmentRecord firstAdjustmentRecord, global::TMPro.TMP_GlyphAdjustmentRecord secondAdjustmentRecord)
		{
		}

		internal TMP_GlyphPairAdjustmentRecord(global::UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord glyphPairAdjustmentRecord)
		{
		}
	}
}

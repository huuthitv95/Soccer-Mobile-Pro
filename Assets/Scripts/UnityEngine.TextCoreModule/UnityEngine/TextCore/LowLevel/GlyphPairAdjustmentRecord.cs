namespace UnityEngine.TextCore.LowLevel
{
	[global::System.Serializable]
	[global::UnityEngine.Scripting.UsedByNativeCode]
	public struct GlyphPairAdjustmentRecord
	{
		[global::UnityEngine.SerializeField]
		private global::UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord m_FirstAdjustmentRecord;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord m_SecondAdjustmentRecord;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.TextCore.LowLevel.FontFeatureLookupFlags m_FeatureLookupFlags;

		public global::UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord firstAdjustmentRecord => default;

		public global::UnityEngine.TextCore.LowLevel.GlyphAdjustmentRecord secondAdjustmentRecord => default;
	}
}

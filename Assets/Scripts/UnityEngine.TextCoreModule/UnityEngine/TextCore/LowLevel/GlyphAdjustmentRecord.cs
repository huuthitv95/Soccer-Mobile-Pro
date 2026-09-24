namespace UnityEngine.TextCore.LowLevel
{
	[global::System.Serializable]
	[global::UnityEngine.Scripting.UsedByNativeCode]
	public struct GlyphAdjustmentRecord
	{
		[global::UnityEngine.SerializeField]
		private uint m_GlyphIndex;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.TextCore.LowLevel.GlyphValueRecord m_GlyphValueRecord;

		public uint glyphIndex => 0u;

		public global::UnityEngine.TextCore.LowLevel.GlyphValueRecord glyphValueRecord => default;
	}
}

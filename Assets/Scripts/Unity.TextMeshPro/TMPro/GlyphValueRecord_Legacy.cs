namespace TMPro
{
	[global::System.Serializable]
	public struct GlyphValueRecord_Legacy
	{
		public float xPlacement;

		public float yPlacement;

		public float xAdvance;

		public float yAdvance;

		internal GlyphValueRecord_Legacy(global::UnityEngine.TextCore.LowLevel.GlyphValueRecord valueRecord)
		{
			xPlacement = 0f;
			yPlacement = 0f;
			xAdvance = 0f;
			yAdvance = 0f;
		}

		public static global::TMPro.GlyphValueRecord_Legacy operator +(global::TMPro.GlyphValueRecord_Legacy a, global::TMPro.GlyphValueRecord_Legacy b)
		{
			return default;
		}
	}
}

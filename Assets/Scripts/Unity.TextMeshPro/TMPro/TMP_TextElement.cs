namespace TMPro
{
	[global::System.Serializable]
	public class TMP_TextElement
	{
		[global::UnityEngine.SerializeField]
		protected global::TMPro.TextElementType m_ElementType;

		[global::UnityEngine.SerializeField]
		internal uint m_Unicode;

		internal global::TMPro.TMP_Asset m_TextAsset;

		internal global::UnityEngine.TextCore.Glyph m_Glyph;

		[global::UnityEngine.SerializeField]
		internal uint m_GlyphIndex;

		[global::UnityEngine.SerializeField]
		internal float m_Scale;

		public global::TMPro.TextElementType elementType => (global::TMPro.TextElementType)0;

		public uint unicode
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		public global::TMPro.TMP_Asset textAsset
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public global::UnityEngine.TextCore.Glyph glyph
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

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

		public float scale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}
	}
}

namespace TMPro
{
	[global::System.Serializable]
	public class TMP_SpriteCharacter : global::TMPro.TMP_TextElement
	{
		[global::UnityEngine.SerializeField]
		private string m_Name;

		[global::UnityEngine.SerializeField]
		private int m_HashCode;

		public string name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int hashCode => 0;

		public TMP_SpriteCharacter()
		{
		}

		public TMP_SpriteCharacter(uint unicode, global::TMPro.TMP_SpriteGlyph glyph)
		{
		}

		public TMP_SpriteCharacter(uint unicode, global::TMPro.TMP_SpriteAsset spriteAsset, global::TMPro.TMP_SpriteGlyph glyph)
		{
		}

		internal TMP_SpriteCharacter(uint unicode, uint glyphIndex)
		{
		}
	}
}

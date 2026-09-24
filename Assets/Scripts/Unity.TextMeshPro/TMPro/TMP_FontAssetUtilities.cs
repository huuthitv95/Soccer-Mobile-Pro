namespace TMPro
{
	public class TMP_FontAssetUtilities
	{
		private static readonly global::TMPro.TMP_FontAssetUtilities s_Instance;

		private static global::System.Collections.Generic.HashSet<int> k_SearchedAssets;

		private static bool k_IsFontEngineInitialized;

		public static global::TMPro.TMP_FontAssetUtilities instance => null;

		static TMP_FontAssetUtilities()
		{
		}

		public static global::TMPro.TMP_Character GetCharacterFromFontAsset(uint unicode, global::TMPro.TMP_FontAsset sourceFontAsset, bool includeFallbacks, global::TMPro.FontStyles fontStyle, global::TMPro.FontWeight fontWeight, out bool isAlternativeTypeface)
		{
			isAlternativeTypeface = default;
			return null;
		}

		private static global::TMPro.TMP_Character GetCharacterFromFontAsset_Internal(uint unicode, global::TMPro.TMP_FontAsset sourceFontAsset, bool includeFallbacks, global::TMPro.FontStyles fontStyle, global::TMPro.FontWeight fontWeight, out bool isAlternativeTypeface)
		{
			isAlternativeTypeface = default;
			return null;
		}

		public static global::TMPro.TMP_Character GetCharacterFromFontAssets(uint unicode, global::TMPro.TMP_FontAsset sourceFontAsset, global::System.Collections.Generic.List<global::TMPro.TMP_FontAsset> fontAssets, bool includeFallbacks, global::TMPro.FontStyles fontStyle, global::TMPro.FontWeight fontWeight, out bool isAlternativeTypeface)
		{
			isAlternativeTypeface = default;
			return null;
		}

		public static global::TMPro.TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset(uint unicode, global::TMPro.TMP_SpriteAsset spriteAsset, bool includeFallbacks)
		{
			return null;
		}

		private static global::TMPro.TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(uint unicode, global::TMPro.TMP_SpriteAsset spriteAsset, bool includeFallbacks)
		{
			return null;
		}
	}
}

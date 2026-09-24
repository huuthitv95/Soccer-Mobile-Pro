namespace GoogleMobileAds.Api
{
	[global::System.Serializable]
	public class NativeTemplateTextStyle
	{
		public global::UnityEngine.Color BackgroundColor { get; set; }

		public global::UnityEngine.Color TextColor { get; set; }

		public int FontSize { get; set; }

		public global::GoogleMobileAds.Api.NativeTemplateFontStyle Style { get; set; }
	}
}

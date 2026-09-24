namespace TMPro
{
	[global::System.Serializable]
	[global::UnityEngine.ExcludeFromPreset]
	public class TMP_ColorGradient : global::UnityEngine.ScriptableObject
	{
		public global::TMPro.ColorMode colorMode;

		public global::UnityEngine.Color topLeft;

		public global::UnityEngine.Color topRight;

		public global::UnityEngine.Color bottomLeft;

		public global::UnityEngine.Color bottomRight;

		private const global::TMPro.ColorMode k_DefaultColorMode = global::TMPro.ColorMode.FourCornersGradient;

		private static readonly global::UnityEngine.Color k_DefaultColor;

		public TMP_ColorGradient()
		{
		}

		public TMP_ColorGradient(global::UnityEngine.Color color)
		{
		}

		public TMP_ColorGradient(global::UnityEngine.Color color0, global::UnityEngine.Color color1, global::UnityEngine.Color color2, global::UnityEngine.Color color3)
		{
		}
	}
}

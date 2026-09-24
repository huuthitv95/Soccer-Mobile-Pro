namespace Gadsme
{
	public sealed class GadsmePreferences : global::UnityEngine.ScriptableObject
	{
		public string gameId;

		public bool forceSandbox;

		public int maxConcurrentRequests;

		public int maxActiveAdContents;

		public float videoAdVolume;

		public float adWatermarkOffset;

		public global::UnityEngine.LayerMask interactionLayerMask;

		public global::UnityEngine.LayerMask visibilityLayerMask;

		public global::Gadsme.Tdabed9b_21 LogLevel;

		public bool showVisibilityRays;

		public bool debugRenderingEngine;

		internal static string F244;

		private static global::Gadsme.GadsmePreferences F245;

		public static global::Gadsme.GadsmePreferences P16 => get_Instance();

		public static global::Gadsme.GadsmePreferences get_Instance()
		{
			return null;
		}
	}
}

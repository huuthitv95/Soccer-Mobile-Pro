namespace Gadsme.Core.Native
{
	internal interface Tdabed9b_64
	{
		global::UnityEngine.Texture2D P45 { get; }

		event global::System.Action PageLoadedEvent;

		event global::System.Action PageErrorEvent;

		event global::System.Action PageClickVisitedEvent;

		global::UnityEngine.Texture2D get_texture();

		void Update();

		void Destroy();

		void SetUserAgent(string userAgent);

		void SetSkAdNetworkData(string skAdNetworkDataString);

		void LoadUrl(string url);

		void LoadHtml(string html);

		void SetViewable(bool viewable);

		void Click(global::UnityEngine.Vector2 point);
	}
}

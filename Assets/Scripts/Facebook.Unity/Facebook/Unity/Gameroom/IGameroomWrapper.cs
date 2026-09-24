namespace Facebook.Unity.Gameroom
{
	internal interface IGameroomWrapper
	{
		global::System.Collections.Generic.IDictionary<string, object> PipeResponse { get; set; }

		void Init(global::Facebook.Unity.Gameroom.GameroomFacebook.OnComplete completeDelegate);

		void DoLoginRequest(string appID, string permissions, string callbackID, global::Facebook.Unity.Gameroom.GameroomFacebook.OnComplete completeDelegate);

		void DoFeedShareRequest(string appId, string toId, string link, string linkName, string linkCaption, string linkDescription, string pictureLink, string mediaSource, string callbackID, global::Facebook.Unity.Gameroom.GameroomFacebook.OnComplete completeDelegate);

		void DoAppRequestRequest(string appId, string message, string actionType, string objectId, string to, string filters, string excludeIDs, string maxRecipients, string data, string title, string callbackID, global::Facebook.Unity.Gameroom.GameroomFacebook.OnComplete completeDelegate);
	}
}

namespace Facebook.Unity.Gameroom
{
	internal interface IGameroomFacebookImplementation : global::Facebook.Unity.IFacebook, global::Facebook.Unity.IFacebookResultHandler
	{
		bool HaveReceivedPipeResponse();

		string GetPipeResponse(string callbackId);
	}
}

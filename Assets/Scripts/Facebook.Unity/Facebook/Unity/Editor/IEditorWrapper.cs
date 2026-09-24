namespace Facebook.Unity.Editor
{
	internal interface IEditorWrapper
	{
		void Init();

		void ShowLoginMockDialog(global::Facebook.Unity.Utilities.Callback<global::Facebook.Unity.ResultContainer> callback, string callbackId, string permissions);

		void ShowAppRequestMockDialog(global::Facebook.Unity.Utilities.Callback<global::Facebook.Unity.ResultContainer> callback, string callbackId);

		void ShowMockShareDialog(global::Facebook.Unity.Utilities.Callback<global::Facebook.Unity.ResultContainer> callback, string subTitle, string callbackId);

		void ShowMockFriendFinderDialog(global::Facebook.Unity.Utilities.Callback<global::Facebook.Unity.ResultContainer> callback, string subTitle, string callbackId);
	}
}

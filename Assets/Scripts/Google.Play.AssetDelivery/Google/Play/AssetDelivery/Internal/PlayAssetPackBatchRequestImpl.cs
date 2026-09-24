namespace Google.Play.AssetDelivery.Internal
{
    public class PlayAssetPackBatchRequestImpl : global::Google.Play.AssetDelivery.PlayAssetPackBatchRequest
    {
        private readonly global::System.Collections.Generic.HashSet<string> _completedPackNames;
        public override event global::System.Action<global::Google.Play.AssetDelivery.PlayAssetPackBatchRequest> Completed
        {
            add
            {
            }

            remove
            {
            }
        }

        internal PlayAssetPackBatchRequestImpl(global::System.Collections.Generic.IEnumerable<global::Google.Play.AssetDelivery.Internal.PlayAssetPackRequestImpl> requests)
        {
        }

        public void OnInitializedInPlayCore()
        {
        }

        public void OnInitializationErrorOccurred(global::Google.Play.AssetDelivery.AssetDeliveryErrorCode errorCode)
        {
        }

        private void OnChildPackCompleted(global::Google.Play.AssetDelivery.PlayAssetPackRequest request)
        {
        }
    }
}
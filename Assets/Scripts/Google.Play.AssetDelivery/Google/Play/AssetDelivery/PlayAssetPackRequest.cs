namespace Google.Play.AssetDelivery
{
    public abstract class PlayAssetPackRequest : global::UnityEngine.CustomYieldInstruction
    {
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action<global::Google.Play.AssetDelivery.PlayAssetPackRequest> m_Completed;
        public float DownloadProgress { get; protected set; }
        public global::Google.Play.AssetDelivery.AssetDeliveryErrorCode Error { get; protected set; }
        public bool IsDone { get; protected set; }
        public global::Google.Play.AssetDelivery.AssetDeliveryStatus Status { get; protected set; }
        public override bool keepWaiting => false;

        public virtual event global::System.Action<global::Google.Play.AssetDelivery.PlayAssetPackRequest> Completed
        {
            [global::System.Runtime.CompilerServices.CompilerGenerated]
            add
            {
            }

            [global::System.Runtime.CompilerServices.CompilerGenerated]
            remove
            {
            }
        }

        public abstract global::Google.Play.AssetDelivery.AssetLocation GetAssetLocation(string assetPath);
        public abstract global::UnityEngine.AssetBundleCreateRequest LoadAssetBundleAsync(string assetBundlePath);
        public abstract void AttemptCancel();
        protected void InvokeCompletedEvent()
        {
        }
    }
}
namespace Google.Play.AssetDelivery
{
    public abstract class PlayAssetBundleRequest : global::UnityEngine.CustomYieldInstruction
    {
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action<global::Google.Play.AssetDelivery.PlayAssetBundleRequest> m_Completed;
        public virtual float DownloadProgress { get; protected set; }
        public virtual global::Google.Play.AssetDelivery.AssetDeliveryErrorCode Error { get; protected set; }
        public bool IsDone { get; protected set; }
        public virtual global::Google.Play.AssetDelivery.AssetDeliveryStatus Status { get; protected set; }
        public global::UnityEngine.AssetBundle AssetBundle { get; protected set; }
        public override bool keepWaiting => false;

        public virtual event global::System.Action<global::Google.Play.AssetDelivery.PlayAssetBundleRequest> Completed
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

        public abstract void AttemptCancel();
        protected void InvokeCompletedEvent()
        {
        }
    }
}
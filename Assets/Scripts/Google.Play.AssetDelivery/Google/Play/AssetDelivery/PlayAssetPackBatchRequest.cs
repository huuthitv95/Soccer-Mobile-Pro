namespace Google.Play.AssetDelivery
{
    public abstract class PlayAssetPackBatchRequest : global::UnityEngine.CustomYieldInstruction
    {
        public global::System.Collections.Generic.IDictionary<string, global::Google.Play.AssetDelivery.PlayAssetPackRequest> Requests;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action<global::Google.Play.AssetDelivery.PlayAssetPackBatchRequest> m_Completed;
        public bool IsDone { get; protected set; }
        public override bool keepWaiting => false;

        public virtual event global::System.Action<global::Google.Play.AssetDelivery.PlayAssetPackBatchRequest> Completed
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

        protected void InvokeCompletedEvent()
        {
        }
    }
}
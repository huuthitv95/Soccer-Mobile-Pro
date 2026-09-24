namespace Google.Play.AssetDelivery.Internal
{
    internal class AssetPackStateUpdateListener : global::UnityEngine.AndroidJavaProxy
    {
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action<global::Google.Play.AssetDelivery.Internal.AssetPackState> m_OnStateUpdateEvent;
        public event global::System.Action<global::Google.Play.AssetDelivery.Internal.AssetPackState> OnStateUpdateEvent
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

        public AssetPackStateUpdateListener() : base((string)null)
        {
        }

        public void onStateUpdate(global::UnityEngine.AndroidJavaObject assetPacksState)
        {
        }
    }
}
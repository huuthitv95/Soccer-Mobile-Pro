namespace Google.Play.AssetDelivery.Internal
{
    internal class AssetDeliveryUpdateHandler : global::UnityEngine.MonoBehaviour
    {
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Action<global::Google.Play.AssetDelivery.Internal.AssetPackState> m_OnStateUpdateEvent;
        private readonly global::System.Collections.Generic.HashSet<string> _stateUpdatesSinceGetPackStates;
        private bool _gettingPackStates;
        private global::Google.Play.AssetDelivery.Internal.AssetPackStateUpdateListener _stateUpdateListener;
        private global::Google.Play.AssetDelivery.Internal.AssetPackManager _assetPackManager;
        private global::Google.Play.AssetDelivery.Internal.PlayRequestRepository _requestRepository;
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

        public static global::Google.Play.AssetDelivery.Internal.AssetDeliveryUpdateHandler CreateInScene(global::Google.Play.AssetDelivery.Internal.AssetPackManager assetPackManager, global::Google.Play.AssetDelivery.Internal.PlayRequestRepository requestRepository)
        {
            return null;
        }

        private void Init(global::Google.Play.AssetDelivery.Internal.AssetPackManager assetPackManager, global::Google.Play.AssetDelivery.Internal.PlayRequestRepository requestRepository)
        {
        }

        private void Start()
        {
        }

        private void OnApplicationPause(bool isPaused)
        {
        }

        private void OnDestroy()
        {
        }

        private void ForcePackStatesUpdate()
        {
        }

        private void ProcessPackStates(global::UnityEngine.AndroidJavaObject javaPackStates)
        {
        }

        private void OnStateUpdateReceived(global::Google.Play.AssetDelivery.Internal.AssetPackState newState)
        {
        }

        private void BeginGetPackStates()
        {
        }

        private void EndGetPackStates()
        {
        }

        private void StartListeningForUpdates()
        {
        }

        private void StopListeningForUpdates()
        {
        }
    }
}
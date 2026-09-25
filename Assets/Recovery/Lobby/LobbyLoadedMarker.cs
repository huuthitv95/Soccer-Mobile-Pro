using UnityEngine;
namespace Soccer.Recovery.Lobby
{
    public sealed class LobbyLoadedMarker : MonoBehaviour
    {
        private void Awake() { LobbyRecoveryTrace.Record(LobbyRecoveryEvent.LobbyLoaded, gameObject.scene.path); }
    }
}

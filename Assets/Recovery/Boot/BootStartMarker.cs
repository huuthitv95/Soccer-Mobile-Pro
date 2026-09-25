using UnityEngine;
namespace Soccer.Recovery.Boot
{
    // Recovery-only end marker; no UI_Load, MainViewLoader, or game services.
    public sealed class BootStartMarker : MonoBehaviour
    {
        private void Awake() => BootRecoveryTrace.Record(BootRecoveryEvent.StartSceneLoaded);
    }
}

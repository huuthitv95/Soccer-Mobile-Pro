using UnityEngine;

namespace Soccer.Recovery.Lobby
{
    public sealed class LobbyRecoveryLaunchAction : MonoBehaviour
    {
        private void Awake()
        {
            var button = GetComponent<UnityEngine.UI.Button>();
            if (button != null) button.onClick.AddListener(Begin);
        }
        public void Begin()
        {
            LobbyRecoveryTrace.Record(LobbyRecoveryEvent.SessionStarted, "Launch button");
            if (LobbyRecoveryServices.Navigator == null || !LobbyRecoveryServices.Navigator.TryLoadStart())
                Debug.LogError("Lobby recovery navigator rejected Start.");
        }
    }
}

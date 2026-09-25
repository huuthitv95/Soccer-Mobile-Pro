using UnityEngine;

namespace Soccer.Recovery.Lobby
{
    public sealed class LobbyOfflineAction : MonoBehaviour
    {
        [SerializeField] private string actionId;
        [SerializeField] private string displayName;
        private void Awake()
        {
            var button = GetComponent<UnityEngine.UI.Button>();
            if (button != null) button.onClick.AddListener(Invoke);
        }
        public void Invoke()
        {
            if (LobbyRecoveryServices.Actions != null)
                LobbyRecoveryServices.Actions.OpenOfflineInformation(actionId, displayName);
        }
        public void Configure(string id, string title) { actionId = id; displayName = title; }
    }
}

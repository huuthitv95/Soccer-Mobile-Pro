using UnityEngine;
using UnityEngine.UI;

namespace Soccer.Recovery.Lobby
{
    public sealed class LobbyOfflineInteraction : MonoBehaviour, ILobbyActionSink
    {
        [SerializeField] private GameObject informationPanel;
        [SerializeField] private Text title;
        [SerializeField] private Text body;
        [SerializeField] private Button returnButton;
        private void Awake() { LobbyRecoveryServices.Register(this); }
        private void Start()
        {
            if (returnButton == null)
            {
                foreach (var button in Resources.FindObjectsOfTypeAll<Button>())
                    if (button.gameObject.scene == gameObject.scene && button.gameObject.name == "Return to Lobby")
                    { returnButton = button; break; }
            }
            if (returnButton != null) returnButton.onClick.AddListener(ReturnToLobby);
        }
        public void OpenOfflineInformation(string actionId, string displayName)
        {
            if (title != null) title.text = displayName;
            if (body != null) body.text = "Thông tin offline — chức năng chưa phục hồi.\nMục: " + actionId;
            if (informationPanel != null) informationPanel.SetActive(true);
            LobbyRecoveryTrace.Record(LobbyRecoveryEvent.MenuActionOpened, actionId);
        }
        public void ReturnToLobby()
        {
            if (informationPanel != null) informationPanel.SetActive(false);
            LobbyRecoveryTrace.Record(LobbyRecoveryEvent.MenuActionReturned);
        }
        public void Configure(GameObject panel, Text heading, Text description, Button back)
        { informationPanel = panel; title = heading; body = description; returnButton = back; }
    }
}

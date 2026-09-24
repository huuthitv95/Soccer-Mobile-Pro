// New recovery implementation. This is not reconstructed original gameplay.
using UnityEngine;
using UnityEngine.UI;

namespace Soccer.Recovery
{
    public sealed class OfflineUIController : MonoBehaviour
    {
        [SerializeField] private GameObject welcomePanel;
        [SerializeField] private GameObject teamPanel;
        [SerializeField] private Button viewTeamButton;
        [SerializeField] private Button backButton;
        [SerializeField] private Slider previewSlider;
        [SerializeField] private Text previewValue;

        public Button ViewTeamButton => viewTeamButton;
        public Button BackButton => backButton;
        public Slider PreviewSlider => previewSlider;
        public bool TeamVisible => teamPanel.activeSelf;
        public int TeamOpenCount { get; private set; }

        // Used by the editor scene builder. No game bootstrap or services are used.
        public void Configure(GameObject welcome, GameObject team, Button view, Button back, Slider slider, Text value)
        {
            welcomePanel = welcome; teamPanel = team;
            viewTeamButton = view; backButton = back; previewSlider = slider; previewValue = value;
        }

        private void OnEnable()
        {
            viewTeamButton.onClick.AddListener(ShowTeam);
            backButton.onClick.AddListener(ShowWelcome);
            previewSlider.onValueChanged.AddListener(UpdatePreview);
            ShowWelcome();
            UpdatePreview(previewSlider.value);
        }

        private void OnDisable()
        {
            viewTeamButton.onClick.RemoveListener(ShowTeam);
            backButton.onClick.RemoveListener(ShowWelcome);
            previewSlider.onValueChanged.RemoveListener(UpdatePreview);
        }

        private void ShowTeam()
        {
            TeamOpenCount++;
            welcomePanel.SetActive(false);
            teamPanel.SetActive(true);
        }

        private void ShowWelcome()
        {
            teamPanel.SetActive(false);
            welcomePanel.SetActive(true);
        }

        private void UpdatePreview(float value)
        {
            previewValue.text = Mathf.RoundToInt(value * 100) + "%";
        }
    }
}

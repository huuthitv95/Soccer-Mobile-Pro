public class GUIIngameRealTimeRating : global::UnityEngine.MonoBehaviour
{
    [global::System.Serializable]
    private class MessageAnimationController
    {
        [global::UnityEngine.SerializeField]
        private UIRectTransformPositionABAnimation msgAnim;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Text msgText;
        private float lastRating;
        private global::FLMessageSystem.FullPlayerStatisticsType currentEventType;
        private global::FLMessageSystem.FullPlayerStatisticsEvaluation currentEvaluation;
        private global::FLMessageSystem.FullPlayerStatisticsType interruptedEventType;
        private global::FLMessageSystem.FullPlayerStatisticsEvaluation interruptedEvaluation;
        private int animationVersion;
        private global::System.Collections.Generic.List<global::FLMessageSystem.FullPlayerStatisticsType> eventTypes;
        public void Hide()
        {
        }

        public void AddEvents(global::System.Collections.Generic.IEnumerable<global::FLMessageSystem.FullPlayerStatisticsType> eventTypes)
        {
        }

        public void Play(float rating)
        {
        }

        public void RecordInterruptedEvent()
        {
        }

        public void ResumeInterruptedEvent()
        {
        }

        private void PlayMessage(global::FLMessageSystem.FullPlayerStatisticsType eventType, global::FLMessageSystem.FullPlayerStatisticsEvaluation evaluation)
        {
        }
    }

    private class RatingDebugHelper
    {
        private const bool EnableDebugTools = false;
        public void Init(AISampleBase aISample, InGamePlayer player)
        {
        }

        public void RecordEvents(global::System.Collections.Generic.IEnumerable<global::FLMessageSystem.FullPlayerStatisticsType> eventTypes, FormationTool.UIPosition position)
        {
        }

        public void LogSnapshot(string ratingText)
        {
        }

        public void DrawOverlay()
        {
        }
    }

    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text realTimeRatingText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text playerName;
    [global::UnityEngine.SerializeField]
    private GUIIngameRealTimeRating.MessageAnimationController messageAnimationController;
    private AISampleBase aISample;
    private InGamePlayer player;
    private readonly GUIIngameRealTimeRating.RatingDebugHelper ratingDebugHelper;
    private global::System.Action<float> OnRatingChangedAction;
    private bool dirty;
    public void SubscribeOnRatingChanged(global::System.Action<float> action)
    {
    }

    public void Init(AISampleBase aISample, InGamePlayer player)
    {
    }

    private void OnGameOver(object message)
    {
    }

    private void OnRatingChanged(global::System.Collections.Generic.IEnumerable<global::FLMessageSystem.FullPlayerStatisticsType> eventTypes)
    {
    }

    private void Update()
    {
    }

    private void OnDisable()
    {
    }

    private void OnEnable()
    {
    }

    private void OnGUI()
    {
    }
}
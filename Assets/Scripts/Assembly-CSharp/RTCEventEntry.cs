[global::System.Serializable]
public struct RTCEventEntry
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button[] button;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Toggle toggle;
    [global::UnityEngine.SerializeField]
    private global::FL.ChampionshipRoadEventManager.EventType eventType;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.MonoBehaviour UINode;
    private RTCEventEntryController _controller;
    private RTCEventEntryController controller => null;

    private void InitController()
    {
    }

    private void ShowBtns(bool show)
    {
    }

    private void ShowRedPoint(bool show)
    {
    }

    public void CheckShow()
    {
    }

    public void CheckRedPoint()
    {
    }

    public bool IsOpen()
    {
        return false;
    }

    public void Start()
    {
    }

    private void AddClickAction(global::UnityEngine.Events.UnityAction action)
    {
    }

    public void RegisterEvent()
    {
    }

    private static void OpenEventWindow(RTCEventEntryController t_controller)
    {
    }

    public static void OpenEventWindow(global::FL.IChanllengeEventController t_controller)
    {
    }
}
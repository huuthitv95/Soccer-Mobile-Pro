public class Win_TrophyRoom : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Toggle clubLeagueTg;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Toggle clubCupTg;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Toggle nationalCupTg;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Toggle playerTg;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform list;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform progress;
    private static Win_TrophyRoom instance;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform btnBack;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform btnBackPlaceholder;
    private global::UnityEngine.Camera uiCamera;
    private bool checkScene;
    public static global::System.Action BackAction;
    private ScreenTimeTracker screenTimeTracker;
    private global::UnityEngine.Texture playerIconTexture;
    private global::System.Action OnPlayerIconChanged;
    private void OnEnable()
    {
    }

    private void Update()
    {
    }

    public static void Show()
    {
    }

    public void OnOpen(object parameter)
    {
    }

    private void UpdateList(global::System.Collections.Generic.List<string> datas, global::SL.GameData.CompetitionType type, global::UnityEngine.UI.Toggle tg)
    {
    }

    private void UpdatePlayerList(global::System.Collections.Generic.List<string> datas, global::UnityEngine.UI.Toggle tg)
    {
    }

    public void CloseWindow()
    {
    }

    public void OnDestroy()
    {
    }
}
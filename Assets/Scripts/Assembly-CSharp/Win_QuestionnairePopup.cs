public class Win_QuestionnairePopup : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnClose;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnGo;
    private string questionnaireUrl;
    private ushort logId;
    private global::System.Action onGo;
    public void Initialize(string url, ushort logId, global::System.Action onGo)
    {
    }

    private void OpenQuestionnaire()
    {
    }
}
public class Win_ConfirmNoImage : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text titleText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text subTitleText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text contentText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button confirmButton;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button closeButton;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text confirmButtonText;
    public override void OnOpen(object paramter)
    {
    }

    public void Fill(string titleId, string subTitleId, string contentId, string confirmId = "ok", global::UnityEngine.Events.UnityAction confirm = null, global::UnityEngine.Events.UnityAction close = null)
    {
    }

    public void ChangeConfimButton(global::UnityEngine.RectTransform btn)
    {
    }

    public void SetConfirmAction(global::UnityEngine.Events.UnityAction action)
    {
    }
}
public class Win_ChooseYears : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform list;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btn_next;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btn_back;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text nameText;
    private global::SL.FACupGroupsData current;
    private global::System.Action<global::SL.FACupGroupsData> OnSelect;
    public override void OnOpen(object parameter)
    {
    }

    public Win_ChooseYears Fill(global::System.Collections.Generic.List<global::SL.FACupGroupsData> datas, global::System.Action<global::SL.FACupGroupsData> OnSelect)
    {
        return null;
    }

    public override void OnClose()
    {
    }

    public void CloseWindow()
    {
    }
}
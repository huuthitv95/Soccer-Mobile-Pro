public class Win_SeasonCalendar : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text season;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text monthText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform list;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnBack;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject nextMonth;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject preMonth;
    private FixtureListData fixtureListData;
    private int month;
    private int minMonth;
    private int maxMonth;
    public override void OnOpen(object parameter)
    {
    }

    public void ShowMonth(int offset)
    {
    }

    private void UpdateList(int month)
    {
    }

    public override void OnClose()
    {
    }
}
public class Win_PlayerFilter : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform list;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject proto;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text title;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnBack;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image icon;
    private global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, int>> ageOptions;
    private global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, int>> ratingOptions;
    public override void OnOpen(object parameter)
    {
    }

    public void FillRegionFilter(global::System.Action<string> onFilter)
    {
    }

    public void FillPositionFilter(global::System.Action<GeneralScoutManager.PosScout> onFilter)
    {
    }

    public void FillAgeFilter(global::System.Action<global::System.Collections.Generic.KeyValuePair<int, int>> onFilter)
    {
    }

    public void FillRatingFilter(global::System.Action<global::System.Collections.Generic.KeyValuePair<int, int>> onFilter)
    {
    }

    private void AutoMiddle()
    {
    }
}
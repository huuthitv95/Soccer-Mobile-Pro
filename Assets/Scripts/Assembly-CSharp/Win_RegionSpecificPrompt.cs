public class Win_RegionSpecificPrompt : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject[] regionalGOs;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text titleText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text contentText;
    public void Fill(NationalData.eContinent eContinent, string title, string content)
    {
    }

    public void Fill(string nation, string title, string content)
    {
    }
}
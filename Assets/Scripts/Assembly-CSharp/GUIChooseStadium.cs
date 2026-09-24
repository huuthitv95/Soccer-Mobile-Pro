public class GUIChooseStadium : global::UnityEngine.MonoBehaviour
{
    public static string FriendlySaveKey;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text nameText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnNext;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button BtnPre;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image icon;
    private global::System.Action<int> OnSelect;
    public void Fill(global::System.Action<int> OnSelect, int current)
    {
    }

    public void Fill()
    {
    }

    private void UpdateUI(int idx, SceneSetting.StadiumInfo data)
    {
    }

    public static void SaveFriendlyStadium(int id)
    {
    }

    public static int LoadFriendlyStadium()
    {
        return 0;
    }
}
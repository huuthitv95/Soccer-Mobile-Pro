public class GUIUserPlayerBaseInfo : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text playerNameText;
    [global::UnityEngine.SerializeField]
    private GUIPlayerType playerType;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform playerPos;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image flag;
    public void Fill(string playerName, NationalData.eNation nation, global::FL.UserPlayerType userPlayerType, FormationTool.UIPosition position)
    {
    }

    public void Fill(UserPlayerData userPlayerData)
    {
    }
}
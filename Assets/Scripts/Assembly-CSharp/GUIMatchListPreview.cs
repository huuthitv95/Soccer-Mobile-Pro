public class GUIMatchListPreview : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private GUIMatchList list;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text nameText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image logoImage;
    public void Init(global::System.Collections.Generic.List<CupMatchBase> matchs, string name, EditableSpirit logoMaker, bool bo2 = false)
    {
    }

    public void Init(IMatchManager matchManager)
    {
    }
}
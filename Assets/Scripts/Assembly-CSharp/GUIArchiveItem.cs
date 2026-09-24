public class GUIArchiveItem : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button continueButton;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button createButton;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button deleteButton;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform dataContainer;
    private GUIArchiveItemStyleBase archiveItemStyle;
    private Win_Archives.ArchiveInfo archiveInfo;
    private global::UnityEngine.Events.UnityAction<object> onDel;
    private global::UnityEngine.Events.UnityAction<object> onSelect;
    public void Fill(bool hasArchive, in Win_Archives.ArchiveInfo archiveInfo, global::UnityEngine.Events.UnityAction<object> onDel, global::UnityEngine.Events.UnityAction OnCreate, global::UnityEngine.Events.UnityAction<object> onSelect)
    {
    }

    private void Updater(bool hasArchive)
    {
    }

    private void OnSelect()
    {
    }

    private void Delete()
    {
    }
}
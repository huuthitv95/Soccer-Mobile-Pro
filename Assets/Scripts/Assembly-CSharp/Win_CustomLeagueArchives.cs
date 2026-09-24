public class Win_CustomLeagueArchives : global::Common.WindowBase
{
    private class ArchiveItem
    {
        public global::UnityEngine.Transform node;
        public global::UnityEngine.Transform dataNode;
        public global::UnityEngine.Transform emptyNode;
        public global::UnityEngine.UI.Button btnDelete;
        public global::UnityEngine.UI.Button btnImport;
        public global::UnityEngine.UI.Button btnExport;
        public global::UnityEngine.UI.Button btnCreate;
        public global::UnityEngine.UI.Text name;
        public global::UnityEngine.UI.Image icon;
        public global::UnityEngine.UI.Image cupIcon;
        public global::UnityEngine.UI.Image superCupIcon;
        public global::UnityEngine.UI.Text cupName;
        public global::UnityEngine.UI.Text superCupName;
        public void Fill(global::Srv.CustomLeagueTemplate data, global::UnityEngine.Transform root, Win_CustomLeagueArchives owner)
        {
        }
    }

    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnBack;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform list;
    private int slot;
    public override void OnOpen(object parameter)
    {
    }

    private void UpdateList()
    {
    }

    private byte[] loadFileBytes(string path)
    {
        return null;
    }

    private void Export(global::Srv.CustomLeagueTemplate template)
    {
    }

    public static bool Import()
    {
        return false;
    }

    public static bool Import(string text)
    {
        return false;
    }
}
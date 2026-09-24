public class AvatarEditTabs : global::UnityEngine.MonoBehaviour
{
    public global::UnityEngine.GameObject[] panels;
    public global::UnityEngine.UI.Button[] tabButtons;
    public global::UnityEngine.GameObject[] kitExtras;
    public global::UnityEngine.UI.Text[] tabLabels;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Color selectedTab;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Color normalTab;
    private int current;
    private void Awake()
    {
    }

    public void Show(int index)
    {
    }

    private static void WakePickers(global::UnityEngine.GameObject root)
    {
    }

    private void RefreshTabLook()
    {
    }
}
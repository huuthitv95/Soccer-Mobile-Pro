[global::System.Serializable]
public class MenuUnlockManager
{
    private enum TipsPanelPosition
    {
        Left = 0,
        Right = 1
    }

    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button lockedButtonProto;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform tipsPanel;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform[] menuButtons;
    [global::UnityEngine.SerializeField]
    private byte[] maskNodeSiblingIndexs;
    [global::UnityEngine.SerializeField]
    private MenuUnlockManager.TipsPanelPosition[] tipsPanelPositions;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Vector4[] menuButtonsPanelOffset;
    private global::DG.Tweening.Sequence sequence;
    private global::UnityEngine.Vector3[] btnCorners;
    public const string MenuUnlockKey = "MenuUnlockKey";
    private void ShowTipsPanel(global::UnityEngine.RectTransform button, MenuUnlockManager.TipsPanelPosition position)
    {
    }

    public void Init()
    {
    }

    public static bool IsMenuUnlock(string key)
    {
        return false;
    }

    public static void MarkMenuUnlock(string key)
    {
    }
}
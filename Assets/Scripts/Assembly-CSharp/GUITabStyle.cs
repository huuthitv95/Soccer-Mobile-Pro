public class GUITabStyle : global::UnityEngine.MonoBehaviour
{
    public enum TabStyle
    {
        Left = 0,
        Middle = 1,
        Right = 2,
        Single = 3,
        Count = 4
    }

    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject[] tabs;
    [global::UnityEngine.SerializeField]
    private GUITabStyle.TabStyle tabStyle;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text text;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform textPosTemplate;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform textPosTemplate_selected;
    [global::UnityEngine.SerializeField]
    private bool ForceUnSelected;
    private global::UnityEngine.RectTransform targetTextRect;
    private bool isOn;
    private void UpdateTabStyles()
    {
    }

    public void SetTabStyle(GUITabStyle.TabStyle style)
    {
    }

    public void OnToggleValueChanged(bool value)
    {
    }

    private void TextResize(global::UnityEngine.RectTransform target, bool value)
    {
    }

    private void Update()
    {
    }

    private void Awake()
    {
    }

    private bool IsSelected()
    {
        return false;
    }

    private bool GetSelectedState(bool value)
    {
        return false;
    }
}
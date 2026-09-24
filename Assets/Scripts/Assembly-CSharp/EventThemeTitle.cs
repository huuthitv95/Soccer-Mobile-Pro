public class EventThemeTitle : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image bg;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text titleText;
    [global::UnityEngine.SerializeField]
    private global::UIThemes.GraphicColorTheme normalTheme;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject specialTheme;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image left;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image right;
    public void ApplyTheme(IMatchManager matchManager)
    {
    }
}
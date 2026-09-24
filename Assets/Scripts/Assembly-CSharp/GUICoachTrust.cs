public class GUICoachTrust : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image progressBar;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image levelIcon;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text levelText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text valueText;
    public void Fill(int value, int maxValue)
    {
    }

    public void Fill(global::FL.PlayerCareer playerCareer)
    {
    }
}
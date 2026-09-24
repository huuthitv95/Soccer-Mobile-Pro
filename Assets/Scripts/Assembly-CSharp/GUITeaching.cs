public class GUITeaching : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private PageView pageView;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button nextBtn;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button preBtn;
    [global::UnityEngine.SerializeField]
    private int count;
    private int currentPage;
    private global::System.Action<int> onPageChanged;
    private global::System.Action<bool, bool> btnStateChanged;
    public void Init(global::System.Action<int> onPageChanged, global::System.Action<bool, bool> btnStateChanged)
    {
    }

    private void OnPageChanged(int page)
    {
    }

    public void OnNextButtonClicked()
    {
    }

    public void OnPreButtonClicked()
    {
    }

    private void UpdateButtonState()
    {
    }
}
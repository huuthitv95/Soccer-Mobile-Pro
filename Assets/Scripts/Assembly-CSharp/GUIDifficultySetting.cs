public class GUIDifficultySetting : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform list;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button left;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button right;
    private int idx;
    private global::System.Action<int> OnValueChange;
    public int GetCurrentValue()
    {
        return 0;
    }

    public void Initialized(int startValue, global::System.Action<int> OnValueChange = null)
    {
    }

    private void UpdateList()
    {
    }

    private void Adjust(int increase)
    {
    }
}
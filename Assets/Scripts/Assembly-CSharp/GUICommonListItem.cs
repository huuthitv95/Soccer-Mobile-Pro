public class GUICommonListItem : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private string itemName;
    [global::UnityEngine.SerializeField]
    private string itemName2;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Color textNormalColor;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Color textSelectedColor;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Toggle.ToggleEvent OnSelected;
    private static global::System.Collections.Generic.Dictionary<string, global::UnityEngine.Sprite> Cache;
    public static global::UnityEngine.Sprite GetSpriteFromCache(string name)
    {
        return null;
    }

    public void Select(bool select, int idx)
    {
    }
}
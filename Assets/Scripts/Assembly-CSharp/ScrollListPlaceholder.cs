public class ScrollListPlaceholder : global::UnityEngine.MonoBehaviour
{
    private enum Direction
    {
        Horizontal = 0,
        Vertical = 1
    }

    [global::UnityEngine.SerializeField]
    private ScrollListPlaceholder.Direction scrollDirection;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform fullScreenRect;
    [global::UnityEngine.SerializeField]
    private float offsetToCenter;
    [global::UnityEngine.SerializeField]
    private float offsetToCenterWhenSquareScreen;
    private float currentOffsetToCenter => 0f;

    private void OnEnable()
    {
    }

    private void Initialize()
    {
    }
}
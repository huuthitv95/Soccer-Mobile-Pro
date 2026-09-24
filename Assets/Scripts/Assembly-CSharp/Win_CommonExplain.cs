public class Win_CommonExplain : global::Common.WindowBase, global::UnityEngine.EventSystems.IPointerClickHandler, global::UnityEngine.EventSystems.IEventSystemHandler
{
    private enum TipDirection
    {
        Right = 0,
        Left = 1,
        Up = 2,
        Down = 3
    }

    private const float ScreenPadding = 20f;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform highlight;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform descRect;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text[] descGroup;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform arrow;
    private global::UnityEngine.Events.UnityAction onClick;
    private bool force;
    public override void OnOpen(object parameter)
    {
    }

    public void Fill(string explainID, global::UnityEngine.RectTransform highlightArea, global::UnityEngine.Events.UnityAction onClick)
    {
    }

    private static global::UnityEngine.Rect GetRectInLayout(global::UnityEngine.RectTransform rectTransform, global::UnityEngine.RectTransform layoutRoot)
    {
        return default;
    }

    private static Win_CommonExplain.TipDirection GetTipDirection(global::UnityEngine.Rect layoutBounds, global::UnityEngine.Rect highlightBounds, global::UnityEngine.Vector2 descriptionSize, float arrowLength)
    {
        return Win_CommonExplain.TipDirection.Right;
    }

    private static global::UnityEngine.Vector2 GetDescriptionCenter(Win_CommonExplain.TipDirection direction, global::UnityEngine.Rect layoutBounds, global::UnityEngine.Rect highlightBounds, global::UnityEngine.Vector2 descriptionSize, float arrowLength)
    {
        return default;
    }

    private static float ClampToLayout(float value, float min, float max, float halfSize)
    {
        return 0f;
    }

    private void UpdateArrow(global::UnityEngine.RectTransform arrowRoot, global::UnityEngine.RectTransform layoutRoot, global::UnityEngine.Vector2 highlightCenter, Win_CommonExplain.TipDirection tipDirection)
    {
    }

    public void OnPointerClick(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }
}
public class GUIInGameButtonConfigurator : global::UnityEngine.MonoBehaviour, global::UnityEngine.EventSystems.IPointerDownHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IPointerUpHandler, global::UnityEngine.EventSystems.IBeginDragHandler, global::UnityEngine.EventSystems.IDragHandler, global::UnityEngine.EventSystems.IEndDragHandler
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform selectedFlag;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform warningFlag;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnSwitch;
    public IngameButtonConfiguration.IngameButtonConfig config;
    private InGameButtonConfiguratorGroup group;
    private global::UnityEngine.Vector3 offset;
    public static void UpdateIngameButtonUI(IngameButtonConfiguration.IngameButtonConfig config, global::UnityEngine.RectTransform root, bool forConfig = true, bool isDynamic = false)
    {
    }

    public void Init(IngameButtonConfiguration.IngameButtonConfig config, InGameButtonConfiguratorGroup group)
    {
    }

    public void OnSelectedChanged(GUIInGameButtonConfigurator cur)
    {
    }

    public void UpdateText(bool attack)
    {
    }

    public void SwitchWith()
    {
    }

    public void ResetUI()
    {
    }

    public void OnUpdateSize(float normalizedScaling)
    {
    }

    public void OnUpdateAlpha(float normalizedAlpha)
    {
    }

    public void OnBeginDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }

    private void DragHandler(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }

    public void ShowWarning(bool show)
    {
    }

    public bool UpdateWarningFlag(bool checkHideWarning = true)
    {
        return false;
    }

    public void OnDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }

    public void OnEndDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }

    public void OnPointerDown(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }

    public void OnPointerUp(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }
}
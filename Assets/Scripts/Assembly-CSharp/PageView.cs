public class PageView : global::UnityEngine.MonoBehaviour, global::UnityEngine.EventSystems.IBeginDragHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IEndDragHandler
{
    private global::UnityEngine.UI.ScrollRect rect;
    private float targethorizontal;
    public bool isDrag;
    private global::System.Collections.Generic.List<float> posList;
    private int currentPageIndex;
    public global::System.Action<int> OnPageChanged;
    public global::System.Action OnDrag;
    public global::System.Action OnDragEnd;
    public global::UnityEngine.RectTransform content;
    public bool loop;
    private bool stopMove;
    public float smooting;
    public float sensitivity;
    private float startTime;
    private float startDragHorizontal;
    public global::UnityEngine.Transform toggleList;
    private global::UnityEngine.GameObject firstPageClone;
    private global::UnityEngine.GameObject lastPageClone;
    private int realPageCount;
    private bool useSmooting;
    private int startIdx;
    private void Start()
    {
    }

    private void OnEnable()
    {
    }

    public void Init()
    {
    }

    private int CountActiveRealPages()
    {
        return 0;
    }

    private bool NeedRefresh()
    {
        return false;
    }

    public void RefreshIfNeeded()
    {
    }

    private int ToRealPageIndex(int internalIndex)
    {
        return 0;
    }

    private int ToInternalPageIndex(int realIndex)
    {
        return 0;
    }

    private void TryLoopJump()
    {
    }

    private void DestroyFirstAndLastPage()
    {
    }

    private void CloneFirstAndLastPage(int firstPageIndex, int lastPageIndex)
    {
    }

    private void Update()
    {
    }

    public void PageToNext()
    {
    }

    public void pageTo(int index)
    {
    }

    public void SetStartPage(int idx)
    {
    }

    private void SetPageIndex(int internalIndex)
    {
    }

    public void OnBeginDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }

    public void OnEndDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }

    public void GetIndex(int index)
    {
    }
}
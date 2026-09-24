public class GUIFormationRole : global::UnityEngine.MonoBehaviour, IFormationDragable, global::UnityEngine.EventSystems.IBeginDragHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IDragHandler, global::UnityEngine.EventSystems.IEndDragHandler
{
    public enum RoleType
    {
        Captain = 0,
        Penalty = 1,
        FreeKick = 2,
        leftCorner = 3,
        rightCorner = 4
    }

    [global::UnityEngine.SerializeField]
    protected GUIPlayer guiPlayer;
    [global::UnityEngine.SerializeField]
    protected global::UnityEngine.UI.Button btnSelect;
    [global::UnityEngine.SerializeField]
    protected global::UnityEngine.Transform dragProto;
    [global::UnityEngine.SerializeField]
    private FormationItemType itemType;
    [global::UnityEngine.SerializeField]
    public GUIFormationRole.RoleType roleType;
    [global::UnityEngine.SerializeField]
    private bool allowGK;
    public bool isLeft;
    private ClubPlayer player;
    private global::System.Action OnRoleChange;
    protected global::System.Func<GUIFormationExchanger> GetExchanger;
    protected IngameTacticsMgr.IngameTacticsData ingameTacticsData;
    protected PlayerDisciplineDatabase disciplineDatabase;
    private bool _lockOption;
    protected global::UnityEngine.Vector3 offset;
    public ClubPlayer Player
    {
        get
        {
            return null;
        }

        set
        {
        }
    }

    public FormationItemType ItemType => FormationItemType.Starter;
    public GUIPlayer GUIPlayer => null;

    global::UnityEngine.GameObject IFormationDragable.gameObject => null;

    public void LockOption(bool lockOption)
    {
    }

    public void Init(ClubPlayer clubPlayer, global::System.Action OnRoleChange, global::System.Func<GUIFormationExchanger> GetExchangerFunc, IngameTacticsMgr.IngameTacticsData ingameTacticsData = null, PlayerDisciplineDatabase playerDisciplineDatabase = null)
    {
    }

    public bool ChangePosition(IFormationDragable targetPlayer)
    {
        return false;
    }

    public void DoPlayerRestoreStamina()
    {
    }

    public void DoPlayerStateAnimation()
    {
    }

    public global::UnityEngine.RectTransform GetRectTransform()
    {
        return null;
    }

    public void OnBeginDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }

    public void OnCovered(bool covered, FormationTool.UIPosition pos)
    {
    }

    public void OnSelect()
    {
    }

    public void OnEndDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }

    public void UpdateOriginalFormationUI()
    {
    }

    public void UpdateRevisedFormationUI()
    {
    }

    void global::UnityEngine.EventSystems.IDragHandler.OnDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }

    protected void OnClick()
    {
    }
}
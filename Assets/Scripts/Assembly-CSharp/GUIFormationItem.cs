public abstract class GUIFormationItem : global::UnityEngine.MonoBehaviour, IFormationDragable, global::UnityEngine.EventSystems.IBeginDragHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IDragHandler, global::UnityEngine.EventSystems.IEndDragHandler
{
    [global::UnityEngine.SerializeField]
    protected GUIPlayer guiPlayer;
    [global::UnityEngine.SerializeField]
    protected global::UnityEngine.UI.Button btnSelect;
    [global::UnityEngine.SerializeField]
    protected global::UnityEngine.Transform dragProto;
    [global::UnityEngine.SerializeField]
    private FormationItemType itemType;
    public bool IsDisabled;
    public ClubPlayer player;
    public FormationTool.UIRole UIRole;
    protected global::System.Func<global::System.Collections.Generic.List<FormationTool.UIRole>> formation;
    protected bool isMyTeam;
    protected global::System.Action onChangeFormation;
    protected global::System.Action<GUIFormationItem> onSelectPlayer;
    protected IngameTacticsMgr.IngameTacticsData ingameTacticsData;
    protected PlayerDisciplineDatabase disciplineDatabase;
    protected bool isSelected;
    protected bool showNewPlayerTip;
    protected global::System.Func<GUIFormationExchanger> GetExchanger;
    public global::System.Func<int, global::System.Collections.Generic.List<int>> CheckMutuallyExclusivePlayers;
    private RegionalLeague masterLeague;
    protected static int SubstitutionsCounter;
    protected bool switchable;
    protected bool ShowSwitchFlag;
    protected global::UnityEngine.Vector3 offset;
    private bool _optionLocked;
    public GUIPlayer GUIPlayer => null;

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

    global::UnityEngine.GameObject IFormationDragable.gameObject => null;

    protected virtual void OnInitialize()
    {
    }

    public void Initialize(ClubPlayer player, FormationTool.UIRole pos, global::System.Func<global::System.Collections.Generic.List<FormationTool.UIRole>> formationSupplier, bool isMyTeam, global::System.Action onChangeFormation, global::System.Action<GUIFormationItem> onSelectPlayer, bool isOnOpen, global::System.Func<GUIFormationExchanger> GetExchangerFunc, IngameTacticsMgr.IngameTacticsData ingameTacticsData = null, PlayerDisciplineDatabase playerDisciplineDatabase = null)
    {
    }

    public void SetMasterLeague(RegionalLeague rl)
    {
    }

    private bool CheckRetire(ClubPlayer player)
    {
        return false;
    }

    public virtual void UpdateRevisedFormationUI()
    {
    }

    protected void UpdateNewPlayerTip()
    {
    }

    public virtual void UpdateOriginalFormationUI()
    {
    }

    protected void OnClick()
    {
    }

    public virtual void Select(bool select)
    {
    }

    public abstract void OnSelect(bool select);
    protected abstract bool CheckSwitchable();
    public bool ChangePosition(IFormationDragable target)
    {
        return false;
    }

    public virtual void OnBeginDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }

    public void LockOption(bool locked)
    {
    }

    public bool CanDrage()
    {
        return false;
    }

    public void SetVisable(bool visable)
    {
    }

    public virtual void OnBeginDrag(global::UnityEngine.EventSystems.PointerEventData eventData, bool resetPlayerDetailInfo)
    {
    }

    public virtual void OnDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }

    public virtual void OnEndDrag(global::UnityEngine.EventSystems.PointerEventData eventData)
    {
    }

    public virtual void OnCovered(bool covered, FormationTool.UIPosition pos)
    {
    }

    public void DoPlayerStateAnimation()
    {
    }

    public void DoPlayerRestoreStamina()
    {
    }

    public global::UnityEngine.RectTransform GetRectTransform()
    {
        return null;
    }
}
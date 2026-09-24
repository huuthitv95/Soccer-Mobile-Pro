public class Win_AppearanceShop : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform toggleGroup;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Toggle tgBall;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject playerModel;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Renderer ball;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform jerseyList;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Renderer homeJersey;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Renderer awayJersey;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Toggle homeJerseyToggle;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Toggle awayJerseyToggle;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform ballList;
    [global::UnityEngine.SerializeField]
    private RewardWithVideo rewardWithVideo;
    [global::UnityEngine.SerializeField]
    private GUIDragRotation guiDragRotation;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject jerseyListGameObject;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject ballListGameObject;
    private TeamsData modelTeam;
    private global::UnityEngine.Vector3 ballDefaultLocalPos;
    private global::UnityEngine.Quaternion ballDefaultLocalRot;
    private global::DG.Tweening.Sequence ballPreviewSequence;
    private bool initialized;
    private global::System.Action<int> onChangeJersey;
    private global::System.Action<int> onChangeBall;
    private bool isLockerRoom;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject btnBack;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject btnHome;
    private global::System.Collections.Generic.List<AppearanceShop.ShopItem> jerseyItems;
    private global::System.Collections.Generic.List<AppearanceShop.ShopItem> ballItems;
    private global::UnityEngine.GameObject usingJersey;
    private global::UnityEngine.GameObject usingBall;
    public override void OnOccludedByOtherWin(global::Common.WindowBase other)
    {
    }

    protected override void OnPreviousWindowClose()
    {
    }

    public override void OnOpen(object parameter)
    {
    }

    public void HideTabGroup()
    {
    }

    public override void OnClosing()
    {
    }

    private void OnEnable()
    {
    }

    private int SortCompare(AppearanceShop.ShopItem a, AppearanceShop.ShopItem b)
    {
        return 0;
    }

    public void HideBallPage()
    {
    }

    public void FillLockerRoom(TeamsData modelTeam, int currentBall, int currentJersey, global::System.Action<int> onChangeJersey, global::System.Action<int> onChangeBall)
    {
    }

    private void UpdatePageToggle(bool isJersey)
    {
    }

    private void PreviewDefaultJersey(bool home)
    {
    }

    private void UpdateBackBtn(bool showHome)
    {
    }

    public void FillShop(TeamsData modelTeam)
    {
    }

    private global::UnityEngine.GameObject GetShopItemProto(int id)
    {
        return null;
    }

    private void FillItemsList(global::UnityEngine.Transform list, global::System.Collections.Generic.List<AppearanceShop.ShopItem> shopItems, int currentId)
    {
    }

    private void RegistVideoBtn(ADButtonStateBase btn)
    {
    }

    private void ChangeUsing(ref global::UnityEngine.GameObject record, global::UnityEngine.GameObject next)
    {
    }

    private void OnPreview(GUIShopItem item)
    {
    }

    private void OnVideo(GUIShopItem item)
    {
    }

    private void PreviewJersey(int id)
    {
    }

    private void PreviewBall(int id)
    {
    }

    private void PlayBallPreviewAnimation()
    {
    }

    private void OnDestroy()
    {
    }
}
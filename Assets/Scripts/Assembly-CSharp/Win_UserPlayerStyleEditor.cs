public class Win_UserPlayerStyleEditor : global::Common.WindowBase
{
    private const int HexagramCount = 6;
    private static readonly global::UnityEngine.Color AttributeUpColor;
    private static readonly global::UnityEngine.Color AttributeDownColor;
    [global::UnityEngine.SerializeField]
    private ForwardBackwardController forwardBackwardController;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text ratingText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text[] attributeTexts;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text[] attributeNames;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text[] attributeNames2;
    [global::UnityEngine.SerializeField]
    private UIHexRadarChart radarChart;
    [global::UnityEngine.SerializeField]
    private UIABStateAnimationGroup animationGroup;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text heightLabel;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text heightText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text weightLabel;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text weightText;
    [global::UnityEngine.SerializeField]
    private GUIWheel gUIWheel;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button changePositionBtn;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image positionIcon;
    private SelectRoleSceneManager selectRoleSceneManager;
    private UserPlayerSetupData userPlayerSetupData;
    private readonly global::UnityEngine.Vector3[] contentCorners;
    private global::UnityEngine.Coroutine alignPlayerCoroutine;
    public void Fill(UserPlayerSetupData userPlayerSetupData, SelectRoleSceneManager selectRoleSceneManager)
    {
    }

    private void Back()
    {
    }

    private void Next()
    {
    }

    private void SelectTeam()
    {
    }

    private void OnSelectTeamClose(Win_ChooseTeam win)
    {
    }

    private void OnTeamSelected(Win_ChooseTeam win)
    {
    }

    private void RegisterUIEvent()
    {
    }

    private void UpdatePositionIcon()
    {
    }

    private void OnPostionChanged()
    {
    }

    private void ChangePosition()
    {
    }

    private void UpdateView(bool initial)
    {
    }

    private void InitPlayerTypeWheel()
    {
    }

    private void InitAttributeNames()
    {
    }

    private string GetAttributeValueString(int value, int ceilingValue, global::UnityEngine.Color color)
    {
        return null;
    }

    private global::UnityEngine.Color GetAttributeFeedbackColor(int value, int balancedValue)
    {
        return default;
    }

    private void OnPlayerTypeWheelChanged(int index)
    {
    }

    public void ClickOption(int index)
    {
    }

    private void InitDefaultInfo()
    {
    }

    private string GetPlayerTypeDisplayName(int index)
    {
        return null;
    }

    private void OnRectTransformDimensionsChange()
    {
    }

    private void OnDisable()
    {
    }

    private void RequestPlayerModelAlignment()
    {
    }

    private global::System.Collections.IEnumerator AlignPlayerModelNextFrame()
    {
        return null;
    }

    private void AlignPlayerModelToContentLeft()
    {
    }

    private global::UnityEngine.RectTransform GetContentRoot()
    {
        return null;
    }

    private global::UnityEngine.Camera GetUICamera()
    {
        return null;
    }
}
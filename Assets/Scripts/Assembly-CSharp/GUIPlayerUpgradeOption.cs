public class GUIPlayerUpgradeOption : global::UnityEngine.MonoBehaviour
{
    public delegate void ValueChangedHandler(global::FL.HexagramAttribute attribute, int oldValue, int newValue);
    public delegate void InputFinishedHandler(GUIPlayerUpgradeOption option, int startValue, int endValue);
    private static readonly global::UnityEngine.Color InitialValueColor;
    private static readonly global::UnityEngine.Color UpgradedValueColor;
    private const float EffectMoveDistance = 32f;
    private const float EffectFadeInDuration = 0.2f;
    private const float EffectHoldDuration = 0.28f;
    private const float EffectFadeOutDuration = 0.35f;
    [global::System.Runtime.CompilerServices.CompilerGenerated]
    private GUIPlayerUpgradeOption.ValueChangedHandler m_OnValueChanged;
    [global::System.Runtime.CompilerServices.CompilerGenerated]
    private global::System.Action<GUIPlayerUpgradeOption> m_OnInput;
    [global::System.Runtime.CompilerServices.CompilerGenerated]
    private GUIPlayerUpgradeOption.InputFinishedHandler m_OnInputFinished;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject recommendFlag;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject GameObjectCostGO;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text costText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text maxValueText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Extensions.CylinderTextOptionSelector optionSelector;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text attributeNameText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image effect;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject disableMask;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject currencyEnoughBg;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject currencyNotEnoughBg;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text pendingAttributeValueText;
    private global::FL.HexagramAttribute _attribute;
    private int _baseValue;
    private int _optionCount;
    private int _currentValue;
    private int _maxValue;
    private global::System.Func<global::FL.HexagramAttribute, int, bool> _canScrollToValue;
    private bool _isReverting;
    private bool _inputActive;
    private int _inputStartValue;
    private global::UnityEngine.RectTransform _effectRect;
    private global::UnityEngine.Vector2 _effectOrigin;
    private global::DG.Tweening.Sequence _effectSequence;
    public global::FL.HexagramAttribute Attribute => global::FL.HexagramAttribute.ShootOrDefensivesPositioning;
    public int CurrentValue => 0;
    public global::UnityEngine.RectTransform OptionSelectorRect => null;

    public event GUIPlayerUpgradeOption.ValueChangedHandler OnValueChanged
    {
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        add
        {
        }

        [global::System.Runtime.CompilerServices.CompilerGenerated]
        remove
        {
        }
    }

    public event global::System.Action<GUIPlayerUpgradeOption> OnInput
    {
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        add
        {
        }

        [global::System.Runtime.CompilerServices.CompilerGenerated]
        remove
        {
        }
    }

    public event GUIPlayerUpgradeOption.InputFinishedHandler OnInputFinished
    {
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        add
        {
        }

        [global::System.Runtime.CompilerServices.CompilerGenerated]
        remove
        {
        }
    }

    public void FinishInput()
    {
    }

    private void Awake()
    {
    }

    private void OnDisable()
    {
    }

    private void OnDestroy()
    {
    }

    public void Setup(global::FL.HexagramAttribute attribute, int baseValue, int maxValue, global::System.Func<global::FL.HexagramAttribute, int, bool> canScrollToValue)
    {
    }

    public void SetUpgradeState(int nextCost, int pendingDelta, bool hasNextPoint, bool canAffordNextPoint)
    {
    }

    public void SetMaxScrollableValue(int maxScrollableValue)
    {
    }

    public void SetRecommended(bool recommended)
    {
    }

    public void PlayUpgradeEffect()
    {
    }

    private void PrepareUpgradeEffect()
    {
    }

    private global::DG.Tweening.Tween CreateUpgradeEffectMoveTween()
    {
        return null;
    }

    private global::DG.Tweening.Sequence CreateUpgradeEffectFadeSequence()
    {
        return null;
    }

    public void SetValueDirectly(int targetValue)
    {
    }

    private global::UnityEngine.Color? GetOptionColor(int index)
    {
        return null;
    }

    private void HandleValueChanged(string optionText, int newIndex)
    {
    }

    private void HandleInput()
    {
    }

    private void HandleInputFinished()
    {
    }

    private void SynchronizeCurrentValue()
    {
    }

    private void ApplyValueChange(int newValue)
    {
    }

    private void ResetUpgradeState()
    {
    }

    private int FindMaxScrollableValue(int targetValue)
    {
        return 0;
    }

    private void KillUpgradeEffect()
    {
    }

    private void HideUpgradeEffect()
    {
    }

    private void SetUpgradeEffectAlpha(float alpha)
    {
    }
}
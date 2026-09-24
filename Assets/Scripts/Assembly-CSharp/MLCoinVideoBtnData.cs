[global::System.Serializable]
public struct MLCoinVideoBtnData
{
    [global::UnityEngine.SerializeField]
    private RewardWithVideo freeCoin;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject visibleObj;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text coinValueText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text[] coinValueTextExtensions;
    public void Init(RewardWithVideo freeCoin, global::UnityEngine.GameObject visibleObj = null)
    {
    }

    public void Updater(global::UnityEngine.Events.UnityAction onVideoComplete, RegionalLeague ml)
    {
    }

    public void GainCoinAndUpdateBtnState(RegionalLeague ml)
    {
    }

    public void CheckMoreCoinABTest()
    {
    }
}
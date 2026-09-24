public class Win_LicensedChallengeReward : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text title;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject[] manCityBg;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject[] monacoBg;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.RawImage mainJsersey;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.RawImage secondJersey;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject secondJerseyLock;
    [global::UnityEngine.SerializeField]
    private ChangeGraphicColor secondJerseyColorChanger;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject[] effects;
    private bool needShowFinishTip;
    public override void OnClosing()
    {
    }

    public override void OnOpen(object parameter)
    {
    }

    public void Fill(int mainJsersey, int secondJersey)
    {
    }

    public override void OnClose()
    {
    }
}
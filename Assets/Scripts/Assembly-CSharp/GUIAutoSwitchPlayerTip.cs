public class GUIAutoSwitchPlayerTip : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform In;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform Out;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btn;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Slider progressBar;
    [global::UnityEngine.SerializeField]
    private TestSample aimatch;
    private float value;
    private const float duration = 10f;
    private global::System.Collections.Generic.KeyValuePair<ClubPlayer, ClubPlayer> CurrentData;
    private global::System.Action<global::System.Collections.Generic.KeyValuePair<ClubPlayer, ClubPlayer>> SwitchAction;
    private global::System.Collections.Generic.KeyValuePair<ClubPlayer, ClubPlayer>? lastData;
    private void OnEnableAnim()
    {
    }

    private global::DG.Tweening.Tween OnDisableAnim(bool doSwitch)
    {
        return null;
    }

    private void Awake()
    {
    }

    private void OnEnable()
    {
    }

    public void Show(global::System.Collections.Generic.KeyValuePair<ClubPlayer, ClubPlayer> data, global::System.Action<global::System.Collections.Generic.KeyValuePair<ClubPlayer, ClubPlayer>> SwitchAction)
    {
    }

    private void Fill(global::System.Collections.Generic.KeyValuePair<ClubPlayer, ClubPlayer> data)
    {
    }

    public bool Working()
    {
        return false;
    }

    private void DoNext(bool DoSwitch)
    {
    }

    private void Update()
    {
    }
}
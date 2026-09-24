public class SocialButton : global::UnityEngine.MonoBehaviour
{
    public enum SocialType
    {
        Facebook = 0,
        Discord = 1,
        Instagram = 2
    }

    private static global::System.Collections.Generic.Dictionary<SocialButton.SocialType, string> urls;
    private static global::System.Collections.Generic.Dictionary<SocialButton.SocialType, string> archiveKeys;
    [global::UnityEngine.SerializeField]
    private SocialButton.SocialType socialType;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform rewardTransform;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform noRewardTransform;
    [global::UnityEngine.SerializeField]
    private bool _hasReward;
    private static global::System.Collections.Generic.LinkedList<SocialButton> fbBtns;
    public global::System.Action OnUpdateState;
    public bool HasReward => false;

    private void UpdateFbBtn()
    {
    }

    public void OpenURL()
    {
    }

    private void OnEnable()
    {
    }

    private void Start()
    {
    }

    private void OnDestroy()
    {
    }

    public static int GetSocialReward()
    {
        return 0;
    }

    public static int GetSocialReward(SocialButton.SocialType type)
    {
        return 0;
    }

    public static void ClearSocialReward(SocialButton.SocialType type)
    {
    }

    public static void ClearSocialReward()
    {
    }
}
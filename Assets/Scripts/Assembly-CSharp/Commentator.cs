public class Commentator : MatchListener, IFLHandler
{
    private ICommentatorControler controler;
    private static LanguageSetting.eLanguage _language;
    private global::UnityEngine.AudioSource audioSource;
    private IMatch AiMatch;
    public static LanguageSetting.eLanguage language
    {
        get
        {
            return LanguageSetting.eLanguage.EN;
        }

        set
        {
        }
    }

    public override global::System.Collections.Generic.IEnumerable<OpCode> FocusOpcode => null;

    public static void SaveLanguage()
    {
    }

    public static LanguageSetting.eLanguage LoadLanguage()
    {
        return LanguageSetting.eLanguage.EN;
    }

    public override void BeforeInit(IMatch match)
    {
    }

    public void PlayGoalComments()
    {
    }

    private global::UnityEngine.AudioClip LoadClip(string name)
    {
        return null;
    }

    private global::UnityEngine.AudioClip LoadClipNew(string name)
    {
        return null;
    }

    public override void OnMatchStart(IMatch match)
    {
    }

    public override void OnMatchCreate(IMatch match, Peripherals peripherals)
    {
    }

    private void OnCommentarySettingChange(float v)
    {
    }

    public override void HandleMessage(OpCode code, object message, IMatch match)
    {
    }

    public override void UpdateFrame(global::EngineMessages.FrameDetail frameDetail, float lerp_t, IMatch match)
    {
    }

    public void OnFLClientMessage(FLClientOpCode opCode, object content)
    {
    }

    public override void PreDestroy(IMatch match)
    {
    }
}
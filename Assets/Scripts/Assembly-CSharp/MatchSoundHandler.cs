public class MatchSoundHandler : MatchListener, ReplayHandler, IFLHandler
{
    [global::UnityEngine.SerializeField]
    private global::System.Collections.Generic.List<SLKeyValue_ListStrOpcode> keyValuePairs;
    [global::UnityEngine.SerializeField]
    private global::System.Collections.Generic.List<SLKeyValue_ListStrOpcode> sound2D;
    private Peripherals m_peripherals;
    private global::UnityEngine.AudioSource audioSource;
    private AISampleBase aiMatch;
    private bool isHomeAwayMode;
    private float lastDribbleTime;
    private bool ofensivaSoundPlaying;
    private float ofensivaDuration;
    private bool AwayOfensivaSoundPlaying;
    private float AwayOfensivaDuration;
    private global::UnityEngine.Coroutine cheerSoundCoroutine;
    private global::System.Collections.Generic.List<SoundID> drums;
    private global::System.Collections.Generic.List<SoundID> songs;
    private SoundID themeMusic;
    public override global::System.Collections.Generic.IEnumerable<OpCode> FocusOpcode => null;

    public override void OnMatchCreate(IMatch match, Peripherals peripherals)
    {
    }

    public override void HandleMessage(OpCode code, object message, IMatch match)
    {
    }

    private bool CheckConditions(OpCode code, object message)
    {
        return false;
    }

    public override void OnUpdate(IMatch match)
    {
    }

    private void StopHomeOfensivaSound()
    {
    }

    public void CheckPlayHomeOfensivaSound(IMatch match)
    {
    }

    private void StopAwayOfensivaSound()
    {
    }

    public void CheckPlayAwayOfensivaSound(IMatch match)
    {
    }

    public void OnReplayStart()
    {
    }

    public void UpdateReplayFrame(global::EngineMessages.FrameDetail frameDetail, float lerp_t, IMatch match, ReplayFrameDetailData detail)
    {
    }

    public void OnReplayEnd()
    {
    }

    public void UpdateHighlightFrame(global::EngineMessages.CompactFrameDetail frameDetail, float lerp_t, IMatch match)
    {
    }

    public void OnReplayReset()
    {
    }

    public void OnFLClientMessage(FLClientOpCode opCode, object content)
    {
    }

    private void StopMatchBGM()
    {
    }

    private void StopCheerSound()
    {
    }

    private global::System.Collections.IEnumerator PlayCheerSound()
    {
        return null;
    }

    private void PlayThemeMusic()
    {
    }

    public override void PreDestroy(IMatch match)
    {
    }
}
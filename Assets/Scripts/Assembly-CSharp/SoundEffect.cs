public class SoundEffect : global::Common.Singleton<SoundEffect>, PlaySoundHelper
{
    private global::System.Collections.Generic.List<SoundID> remoteSoundList;
    private global::System.Collections.Generic.Dictionary<SoundID, global::UnityEngine.AudioClip> allAudioClips;
    private global::UnityEngine.GameObject audioSourceObj;
    public FloatEvents OnMusicSwitchChange;
    public FloatEvents OnSoundSwitchChange;
    public FloatEvents OnCommentarySwitchChange;
    private global::UnityEngine.AudioSource bgAudioSource;
    private bool canPlayAudio;
    private global::System.Collections.Generic.List<global::UnityEngine.AudioSource> hintAudioSources;
    private global::System.Collections.Generic.HashSet<string> bgmSet;
    private global::System.Collections.Generic.HashSet<global::UnityEngine.AudioSource> otherAudioSources;
    private global::System.Text.StringBuilder debugSound;
    private global::UnityEngine.Coroutine environmentCO;
    private SoundID? environmentSfxId;
    private global::UnityEngine.AudioSource homeEnvironmentSfx;
    private global::UnityEngine.AudioSource awayEnvironmentSfx;
    private global::System.DateTime lastVibrateT;
    private global::System.Collections.Generic.Dictionary<string, SoundID> soundIdMap;
    public static global::System.Collections.Generic.Dictionary<SoundID, float> soundVolumeDictionary;
    public float MusicVolume
    {
        get
        {
            return 0f;
        }

        set
        {
        }
    }

    public bool MusicOn => false;

    public float SoundVolume
    {
        get
        {
            return 0f;
        }

        set
        {
        }
    }

    public bool SoundOn => false;

    public float CommentaryVolume
    {
        get
        {
            return 0f;
        }

        set
        {
        }
    }

    public bool CommentaryOn => false;

    public bool VibrateOn
    {
        get
        {
            return false;
        }

        set
        {
        }
    }

    public void SetPlayEnabled(bool enabled)
    {
    }

    public void Init()
    {
    }

    public global::UnityEngine.AudioClip GetAudioClip(SoundID soundID)
    {
        return null;
    }

    public void LoadGoalSound()
    {
    }

    private bool LoadClip(SoundID soundID)
    {
        return false;
    }

    private bool LoadRemoveSound(SoundID soundID)
    {
        return false;
    }

    private string SoundNameAdapter(SoundID id)
    {
        return null;
    }

    private static bool IsCheerBgm(SoundID soundId)
    {
        return false;
    }

    private void EnsureAudioSourceCreated()
    {
    }

    public global::UnityEngine.AudioSource Play(SoundID soundId, bool loop = false, bool isBg = false, bool multiple = false, float pitch = 1f, global::UnityEngine.AudioSource audioSource = null)
    {
        return null;
    }

    public void SetForcedBgLoop(SoundID soundId)
    {
    }

    public void ClearForcedBgLoop()
    {
    }

    public void OnGUI()
    {
    }

    private global::UnityEngine.AudioSource GetIdelAudioSource()
    {
        return null;
    }

    public bool IsSoundPlaying(SoundID soundid, out bool isBg)
    {
        isBg = default;
        return false;
    }

    public void SetVolume(SoundID soundid, float volume)
    {
    }

    public void Stop(SoundID soundid)
    {
    }

    private global::System.Collections.IEnumerator FadeOut(SoundID soundid, float fadeTime = 0.8f)
    {
        return null;
    }

    public void FadeOutSound(SoundID soundid, float fadeTime = 3.5f)
    {
    }

    public void StopBgMusic()
    {
    }

    public void SyncMusicVolume()
    {
    }

    public void StopSounds()
    {
    }

    public void Mute(bool param)
    {
    }

    public void OnMatchInOut(bool isOut)
    {
    }

    public void StopEnvironment()
    {
    }

    public void OnUpdate()
    {
    }

    public void Vibrate(float interval = 0.025f, long duration = 15L)
    {
    }

    public void LongVibrate(float interval = 0.025f)
    {
    }

    public void Play(string soundId, bool loop = false, bool isBg = false, global::UnityEngine.AudioSource audioSource = null)
    {
    }

    public void UpdateSoundListenerPos(global::UnityEngine.Vector3 pos)
    {
    }
}
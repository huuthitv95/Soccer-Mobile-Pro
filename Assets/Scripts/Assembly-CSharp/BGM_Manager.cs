public static class BGM_Manager
{
    private static SoundID[] bgms;
    private static int index;
    private static bool isInit;
    private static global::UnityEngine.Coroutine fadeInCo;
    private static global::UnityEngine.Coroutine loopCo;
    private static SoundID? forcedLoopBgm;
    private static float initVolume;
    private static bool canPlay;
    private static float maxVolume;
    private static float currentVolume;
    private static void StopLoopCoroutine()
    {
    }

    private static bool ApplySelectedBgm(global::UnityEngine.AudioSource audioSource, SoundID soundId, global::System.Func<SoundID, global::UnityEngine.AudioClip> clipGeter, bool loop, bool restart)
    {
        return false;
    }

    public static void SetForcedLoop(global::UnityEngine.AudioSource audioSource, SoundID soundId, global::System.Func<SoundID, global::UnityEngine.AudioClip> clipGeter)
    {
    }

    public static void ClearForcedLoop(global::UnityEngine.AudioSource audioSource, global::System.Func<SoundID, global::UnityEngine.AudioClip> clipGeter)
    {
    }

    private static void RandomNext()
    {
    }

    private static global::System.Collections.IEnumerator FadeOut(global::UnityEngine.AudioSource audioSource, float fadeTime = 0.8f)
    {
        return null;
    }

    public static void OnMatchInOut(bool isOut, global::UnityEngine.AudioSource audioSource)
    {
    }

    public static void Play(global::UnityEngine.AudioSource audioSource, global::System.Func<SoundID, global::UnityEngine.AudioClip> clipGeter)
    {
    }

    public static void SyncValumeSetting(global::UnityEngine.AudioSource audioSource)
    {
    }

    private static global::System.Collections.IEnumerator FadeIn(global::UnityEngine.AudioSource audioSource, float fadeTime = 0.8f)
    {
        return null;
    }

    private static void FadeInSound(global::UnityEngine.AudioSource audioSource, float fadeTime = 2.8f)
    {
    }

    public static void Stop(global::UnityEngine.AudioSource audioSource)
    {
    }

    public static void Mute(global::UnityEngine.AudioSource audioSource, bool mute)
    {
    }
}
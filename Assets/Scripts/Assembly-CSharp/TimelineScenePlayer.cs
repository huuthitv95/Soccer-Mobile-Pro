public static class TimelineScenePlayer
{
    public static void Play<TTimeline>(string scenePath, global::System.Action<TTimeline> setupTimeline, global::System.Action onComplete = null)
        where TTimeline : TimelinePlayable
    {
    }

    private static void PlayLoadedTimeline<TTimeline>(string scenePath, global::System.Action<TTimeline> setupTimeline, global::System.Action onComplete)
        where TTimeline : TimelinePlayable
    {
    }

    private static TTimeline FindTimeline<TTimeline>(string scenePath)
        where TTimeline : TimelinePlayable
    {
        return null;
    }

    private static void BackToMainView(global::System.Action onComplete)
    {
    }
}
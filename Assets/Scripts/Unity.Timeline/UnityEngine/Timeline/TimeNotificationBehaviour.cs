namespace UnityEngine.Timeline
{
    public class TimeNotificationBehaviour : global::UnityEngine.Playables.PlayableBehaviour
    {
        private struct NotificationEntry
        {
            public double time;
            public global::UnityEngine.Playables.INotification payload;
            public bool notificationFired;
            public global::UnityEngine.Timeline.NotificationFlags flags;
            public bool triggerInEditor => false;
            public bool prewarm => false;
            public bool triggerOnce => false;
        }

        private readonly global::System.Collections.Generic.List<global::UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry> m_Notifications;
        private double m_PreviousTime;
        private bool m_NeedSortNotifications;
        private global::UnityEngine.Playables.Playable m_TimeSource;
        public global::UnityEngine.Playables.Playable timeSource
        {
            set
            {
            }
        }

        public static global::UnityEngine.Playables.ScriptPlayable<global::UnityEngine.Timeline.TimeNotificationBehaviour> Create(global::UnityEngine.Playables.PlayableGraph graph, double duration, global::UnityEngine.Playables.DirectorWrapMode loopMode)
        {
            return default;
        }

        public void AddNotification(double time, global::UnityEngine.Playables.INotification payload, global::UnityEngine.Timeline.NotificationFlags flags = global::UnityEngine.Timeline.NotificationFlags.Retroactive)
        {
        }

        public override void OnGraphStart(global::UnityEngine.Playables.Playable playable)
        {
        }

        public override void OnBehaviourPause(global::UnityEngine.Playables.Playable playable, global::UnityEngine.Playables.FrameData info)
        {
        }

        public override void PrepareFrame(global::UnityEngine.Playables.Playable playable, global::UnityEngine.Playables.FrameData info)
        {
        }

        private void SortNotifications()
        {
        }

        private static bool CanRestoreNotification(global::UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry e, global::UnityEngine.Playables.FrameData info, double currentTime, double previousTime)
        {
            return false;
        }

        private void TriggerNotificationsInRange(double start, double end, global::UnityEngine.Playables.FrameData info, global::UnityEngine.Playables.Playable playable, bool checkState)
        {
        }

        private void SyncDurationWithExternalSource(global::UnityEngine.Playables.Playable playable)
        {
        }

        private static void Trigger_internal(global::UnityEngine.Playables.Playable playable, global::UnityEngine.Playables.PlayableOutput output, ref global::UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry e)
        {
        }

        private static void Restore_internal(ref global::UnityEngine.Timeline.TimeNotificationBehaviour.NotificationEntry e)
        {
        }
    }
}
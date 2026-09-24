namespace GooglePlayGames.Android
{
    internal class AndroidEventsClient : global::GooglePlayGames.BasicApi.Events.IEventsClient
    {
        private global::UnityEngine.AndroidJavaObject mEventsClient;
        public void FetchAllEvents(global::GooglePlayGames.BasicApi.DataSource source, global::System.Action<global::GooglePlayGames.BasicApi.ResponseStatus, global::System.Collections.Generic.List<global::GooglePlayGames.BasicApi.Events.IEvent>> callback)
        {
        }

        public void FetchEvent(global::GooglePlayGames.BasicApi.DataSource source, string eventId, global::System.Action<global::GooglePlayGames.BasicApi.ResponseStatus, global::GooglePlayGames.BasicApi.Events.IEvent> callback)
        {
        }

        public void IncrementEvent(string eventId, uint stepsToIncrement)
        {
        }

        private static global::System.Action<T1, T2> ToOnGameThread<T1, T2>(global::System.Action<T1, T2> toConvert)
        {
            return null;
        }

        private static global::GooglePlayGames.BasicApi.Events.Event CreateEvent(global::UnityEngine.AndroidJavaObject eventJava)
        {
            return null;
        }
    }
}
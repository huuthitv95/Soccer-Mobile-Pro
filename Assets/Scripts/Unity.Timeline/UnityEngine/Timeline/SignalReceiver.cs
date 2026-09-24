namespace UnityEngine.Timeline
{
    public class SignalReceiver : global::UnityEngine.MonoBehaviour, global::UnityEngine.Playables.INotificationReceiver
    {
        [global::System.Serializable]
        private class EventKeyValue
        {
            [global::UnityEngine.SerializeField]
            private global::System.Collections.Generic.List<global::UnityEngine.Timeline.SignalAsset> m_Signals;
            [global::UnityEngine.Timeline.CustomSignalEventDrawer]
            [global::UnityEngine.SerializeField]
            private global::System.Collections.Generic.List<global::UnityEngine.Events.UnityEvent> m_Events;
            public global::System.Collections.Generic.List<global::UnityEngine.Timeline.SignalAsset> signals => null;
            public global::System.Collections.Generic.List<global::UnityEngine.Events.UnityEvent> events => null;

            public bool TryGetValue(global::UnityEngine.Timeline.SignalAsset key, out global::UnityEngine.Events.UnityEvent value)
            {
                value = null;
                return false;
            }

            public void Append(global::UnityEngine.Timeline.SignalAsset key, global::UnityEngine.Events.UnityEvent value)
            {
            }

            public void Remove(int idx)
            {
            }

            public void Remove(global::UnityEngine.Timeline.SignalAsset key)
            {
            }
        }

        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Timeline.SignalReceiver.EventKeyValue m_Events;
        public void OnNotify(global::UnityEngine.Playables.Playable origin, global::UnityEngine.Playables.INotification notification, object context)
        {
        }

        public void AddReaction(global::UnityEngine.Timeline.SignalAsset asset, global::UnityEngine.Events.UnityEvent reaction)
        {
        }

        public int AddEmptyReaction(global::UnityEngine.Events.UnityEvent reaction)
        {
            return 0;
        }

        public void Remove(global::UnityEngine.Timeline.SignalAsset asset)
        {
        }

        public global::System.Collections.Generic.IEnumerable<global::UnityEngine.Timeline.SignalAsset> GetRegisteredSignals()
        {
            return null;
        }

        public global::UnityEngine.Events.UnityEvent GetReaction(global::UnityEngine.Timeline.SignalAsset key)
        {
            return null;
        }

        public int Count()
        {
            return 0;
        }

        public void ChangeSignalAtIndex(int idx, global::UnityEngine.Timeline.SignalAsset newKey)
        {
        }

        public void RemoveAtIndex(int idx)
        {
        }

        public void ChangeReactionAtIndex(int idx, global::UnityEngine.Events.UnityEvent reaction)
        {
        }

        public global::UnityEngine.Events.UnityEvent GetReactionAtIndex(int idx)
        {
            return null;
        }

        public global::UnityEngine.Timeline.SignalAsset GetSignalAssetAtIndex(int idx)
        {
            return null;
        }

        private void OnEnable()
        {
        }
    }
}
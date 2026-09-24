namespace UnityEngine.Timeline
{
    public abstract class Marker : global::UnityEngine.ScriptableObject, global::UnityEngine.Timeline.IMarker
    {
        [global::UnityEngine.SerializeField]
        private double m_Time;
        public global::UnityEngine.Timeline.TrackAsset parent { get; private set; }

        public double time
        {
            get
            {
                return 0.0;
            }

            set
            {
            }
        }

        void global::UnityEngine.Timeline.IMarker.Initialize(global::UnityEngine.Timeline.TrackAsset parentTrack)
        {
        }

        public virtual void OnInitialize(global::UnityEngine.Timeline.TrackAsset aPent)
        {
        }
    }
}
public class MeasureFrameTime : global::UnityEngine.MonoBehaviour
{
    private class FrameTimeCalculator
    {
        private int BUCKET_COUNT;
        private int BUCKET_CAPACITY;
        private int Total_Count;
        private double[] _timeConsumed2;
        private int _measuredFrameCount;
        public FrameTimeCalculator(int buckutCount, int bucketCapacity)
        {
        }

        public void AddFrame(double time, int framecount)
        {
        }

        public double GetAvgTime()
        {
            return 0.0;
        }
    }

    private double _starttime;
    private float _lasttime;
    private int _fpsCounter;
    private float _fps;
    private int _fpsSampleVersion;
    private float _fpsSampleDuration;
    private int _framecount;
    private MeasureFrameTime.FrameTimeCalculator _calculateSmall;
    private MeasureFrameTime.FrameTimeCalculator _calculateLarge;
    public float FPS => 0f;
    public int FpsSampleVersion => 0;
    public float FpsSampleDuration => 0f;

    private void OnEnable()
    {
    }

    public void ResetFPS()
    {
    }

    private void OnPreCull()
    {
    }

    private void OnPostRender()
    {
    }

    public double GetRecentFrameTime()
    {
        return 0.0;
    }

    public double GetAvgFrameTime()
    {
        return 0.0;
    }
}
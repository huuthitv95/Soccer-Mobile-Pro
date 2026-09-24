namespace UnityEngine.Timeline
{
    internal static class TimeUtility
    {
        public static readonly double kTimeEpsilon;
        public static readonly double kFrameRateEpsilon;
        public static readonly double k_MaxTimelineDurationInSeconds;
        private static void ValidateFrameRate(double frameRate)
        {
        }

        public static int ToFrames(double time, double frameRate)
        {
            return 0;
        }

        public static double ToExactFrames(double time, double frameRate)
        {
            return 0.0;
        }

        public static double FromFrames(int frames, double frameRate)
        {
            return 0.0;
        }

        public static double FromFrames(double frames, double frameRate)
        {
            return 0.0;
        }

        public static bool OnFrameBoundary(double time, double frameRate)
        {
            return false;
        }

        public static double GetEpsilon(double time, double frameRate)
        {
            return 0.0;
        }

        public static bool OnFrameBoundary(double time, double frameRate, double epsilon)
        {
            return false;
        }

        public static double RoundToFrame(double time, double frameRate)
        {
            return 0.0;
        }

        public static string TimeAsFrames(double timeValue, double frameRate, string format = "F2")
        {
            return null;
        }

        public static string TimeAsTimeCode(double timeValue, double frameRate, string format = "F2")
        {
            return null;
        }

        public static double ParseTimeCode(string timeCode, double frameRate, double defaultValue)
        {
            return 0.0;
        }

        public static double GetAnimationClipLength(global::UnityEngine.AnimationClip clip)
        {
            return 0.0;
        }

        private static string RemoveChar(string str, global::System.Func<char, bool> charToRemoveFunc)
        {
            return null;
        }
    }
}
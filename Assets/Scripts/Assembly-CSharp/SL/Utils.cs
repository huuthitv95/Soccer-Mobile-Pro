namespace SL
{
    public static class Utils
    {
        public enum StringCheckType
        {
            ASCII = 1,
            GB = 2,
            Unicode = 3,
            UTF8 = 4
        }

        public static global::System.DateTime epochTime;
        public static global::System.DateTime Time2022;
        public static global::System.TimeSpan timeCorrection;
        public static int GetUtcTime(bool network, global::System.TimeSpan timeSpan)
        {
            return 0;
        }

        public static global::System.DateTime GetUtcDateTime(long seconds)
        {
            return default;
        }

        public static string GetProgresText(int current, int total, global::UnityEngine.Color color)
        {
            return null;
        }

        public static int GetUtcTime()
        {
            return 0;
        }

        public static string FormatRemainingTime(global::System.DateTime endTime, bool accurateToSecond = true, bool showAllAccuracy = false)
        {
            return null;
        }

        public static string FormatRemainSeconds(int remainSeconds, bool accurateToSecond = true, bool showAllAccuracy = false)
        {
            return null;
        }

        public static string FormatRemainMinutesSeconds(int remainSeconds)
        {
            return null;
        }

        public static global::System.DateTime GetLocalTime(uint timeStamp)
        {
            return default;
        }

        public static global::System.DateTime GetLocalTime()
        {
            return default;
        }

        public static string GetLimitedLengthText(string text, global::SL.Utils.StringCheckType checkType, int characterLimit)
        {
            return null;
        }

        private static string LimitByUTF8(string temp, int characterLimit)
        {
            return null;
        }

        private static string LimitByUnicode(string temp, int characterLimit)
        {
            return null;
        }

        private static string LimitByGB(string temp, int characterLimit)
        {
            return null;
        }

        private static string LimitByASCII(string temp, int characterLimit)
        {
            return null;
        }

        public static string SimpleXor(string context, string key)
        {
            return null;
        }

        public static global::System.Collections.Generic.List<T> CutInLine<T>(global::System.Collections.Generic.List<T> teams, int capacity, global::System.Func<T, bool> condition)
        {
            return null;
        }

        public static void CutInLineInPlace<T>(global::System.Collections.Generic.List<T> teams, global::System.Func<T, bool> condition)
        {
        }
    }
}
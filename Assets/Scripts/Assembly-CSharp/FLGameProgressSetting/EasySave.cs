namespace FLGameProgressSetting
{
    public static class EasySave
    {
        public class RedPointData
        {
            private static global::System.DateTime startPoint;
            private global::System.DateTime ObsoleteTime;
            private string Type;
            private int MaxDurationDays;
            public RedPointData(string type, global::System.DateTime obsoleteTime, int maxDurationDays = 14)
            {
            }

            private string GetKey()
            {
                return null;
            }

            private string GetTimeKey()
            {
                return null;
            }

            public bool CheckRedPoint()
            {
                return false;
            }

            public void MarkRedPoint(bool mark)
            {
            }
        }

        public static global::Srv.GlobalGameProgressSettings Data => null;

        public static void MarkDirty()
        {
        }

        public static int GetInt(string key, int defaultvalue)
        {
            return 0;
        }

        public static void SetInt(string key, int value)
        {
        }

        public static bool HasInt(string key)
        {
            return false;
        }

        public static string GetString(string key, string defaultvalue)
        {
            return null;
        }

        public static void SetString(string key, string value)
        {
        }
    }
}
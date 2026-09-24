namespace FLUserSetting
{
    public class PopupArchives : global::FLUserSetting.LocalDataBase
    {
        public enum PopupType
        {
            GameDayLine = 0,
            MomentChallenge = 1,
            NaturalDayLine = 100
        }

        private static bool IsGameDayType(global::FLUserSetting.PopupArchives.PopupType type)
        {
            return false;
        }

        public static bool FirstShowed(global::FLUserSetting.PopupArchives.PopupType type)
        {
            return false;
        }

        public static void MarkFirstShowed(global::FLUserSetting.PopupArchives.PopupType type)
        {
        }

        public static void MarkLastTime(global::FLUserSetting.PopupArchives.PopupType type)
        {
        }

        public static void MarkDailyPopup(global::FLUserSetting.PopupArchives.PopupType type)
        {
        }

        public static int GetPassedDays(global::FLUserSetting.PopupArchives.PopupType type)
        {
            return 0;
        }

        public static bool DailyPopupShowed(global::FLUserSetting.PopupArchives.PopupType type)
        {
            return false;
        }

        public static bool PopupMark(global::FLUserSetting.PopupArchives.PopupType type)
        {
            return false;
        }

        public static void SetPopupMark(global::FLUserSetting.PopupArchives.PopupType type, bool mark)
        {
        }
    }
}
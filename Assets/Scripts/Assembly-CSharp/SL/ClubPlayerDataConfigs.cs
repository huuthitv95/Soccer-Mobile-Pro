namespace SL
{
    public class ClubPlayerDataConfigs
    {
        public enum EGloveType : byte
        {
            glove_gk1 = 0,
            glove_gk2 = 1,
            glove_gk3 = 2,
            glove_gk4 = 3,
            glove_gk5 = 4,
            glove_gk6 = 5,
            glove_gk7 = 6,
            glove_gk8 = 7
        }

        public int team;
        public int playerId;
        public EditableCoatNumber coatNumberValue;
        public global::SL.ClubPlayerDataConfigs.EGloveType glove;
        public FormationTool.UIRole pos;
        private const string _playerPath = "Assets/GameData/excels/gamedata/ClubPlayer.bytes";
        private static global::System.Collections.Generic.Dictionary<int, global::System.Collections.Generic.List<global::SL.ClubPlayerDataConfigs>> teamMap;
        public static global::SL.ClubPlayerDataConfigs Deserialization(global::System.IO.BinaryReader datas)
        {
            return null;
        }

        public static global::System.Collections.Generic.Dictionary<int, global::System.Collections.Generic.List<global::SL.ClubPlayerDataConfigs>> LoadFromFile()
        {
            return null;
        }

        public static void SaveBytes(global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>> csv, global::System.Collections.Generic.Dictionary<int, int> playerCountByTeam, string path = "Assets/GameData/excels/gamedata/ClubPlayer.bytes")
        {
        }

        private static bool TryParseCoatNumberColorPair(string value, out global::UnityEngine.Color color1, out global::UnityEngine.Color color2)
        {
            color1 = default;
            color2 = default;
            return false;
        }

        private static bool TryParseLegacyStyle(string value, out global::UnityEngine.Color color1, out global::UnityEngine.Color color2)
        {
            color1 = default;
            color2 = default;
            return false;
        }

        private static bool TryParseRgb(string value, out global::UnityEngine.Color color)
        {
            color = default;
            return false;
        }

        public static void Load()
        {
        }

        public static global::SL.ClubPlayerDataConfigs GetConfigById(int team, int id)
        {
            return null;
        }

        public static global::SL.ClubPlayerDataConfigs GetConfigByTeam(int team, bool isGK)
        {
            return null;
        }

        public static global::SL.ClubPlayerDataConfigs GetConfigByClubPlayer(ClubPlayer clubPlayer, out string coatNum)
        {
            coatNum = null;
            return null;
        }

        public static global::System.Collections.Generic.List<global::SL.ClubPlayerDataConfigs> GetConfigByTeam(int team)
        {
            return null;
        }
    }
}
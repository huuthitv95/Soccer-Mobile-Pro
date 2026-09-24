public class TextRendertextureGenerater : global::UnityEngine.MonoBehaviour
{
    public struct TextColorConfig
    {
        public global::UnityEngine.Color color1;
        public global::UnityEngine.Color outlineColor1;
        public global::UnityEngine.Color color2;
        public global::UnityEngine.Color outlineColor2;
        public int useSecondColorIdx;
        public TextColorConfig(global::UnityEngine.Color color1, global::UnityEngine.Color outlineColor1, global::UnityEngine.Color color2, global::UnityEngine.Color outlineColor2, int useSecondColorIdx)
        {
            this.color1 = default;
            this.outlineColor1 = default;
            this.color2 = default;
            this.outlineColor2 = default;
            this.useSecondColorIdx = 0;
        }
    }

    private class Request
    {
        public int id;
        public string Name;
        public global::System.Action<global::UnityEngine.Texture, global::UnityEngine.Rect> CallBack;
    }

    private class ProfilePicAtlas
    {
        private const int capacity = 64;
        public global::System.Collections.Generic.Dictionary<int, global::UnityEngine.Rect> cached;
        public global::System.Collections.Generic.List<int> sequence;
        public global::UnityEngine.RenderTexture Texture;
        public int EptySiteCount => 0;

        public void Add(int id)
        {
        }

        public void Reset()
        {
        }
    }

    private class ProfilePicAtlasCache
    {
        public global::System.Collections.Generic.List<TextRendertextureGenerater.ProfilePicAtlas> cache;
        public bool TryGetValue(int id, out global::System.Collections.Generic.KeyValuePair<global::UnityEngine.Texture, global::UnityEngine.Rect> data)
        {
            data = default;
            return false;
        }

        public TextRendertextureGenerater.ProfilePicAtlas GetHasSiteAtlas()
        {
            return null;
        }
    }

    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Camera m_camera;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform list;
    private static TextRendertextureGenerater Instance;
    private static TextRendertextureGenerater.ProfilePicAtlas playerName;
    private static bool UseDarkNumberStyle(TeamAvatarHelper.NumberColorPair numberColorPair)
    {
        return false;
    }

    private static void EnsureInstance()
    {
    }

    private static void SetNameColor(ref TextRendertextureGenerater.TextColorConfig colorConfig, TeamAvatarHelper.NumberColorPair numberColorPair, bool useSecondColor)
    {
    }

    public static void GeneratePlayerNameTexture(int playerId, string name, TeamAvatarHelper.NumberColorPair numberColorPair)
    {
    }

    public static void GeneratePlayerNameTexture(global::System.Collections.Generic.List<ClubPlayer> players, global::System.Action<global::UnityEngine.Texture, global::UnityEngine.Rect, int> onGet, TextRendertextureGenerater.TextColorConfig colorConfig, int playerNameOverrideId = -1, string playerNameOverride = null)
    {
    }

    public static void GeneratePlayerNameTexture(TeamsData team1, int homeAvatarId, TeamsData team2, int awayAvatarId, bool checkMemory = true, int playerNameOverrideId = -1, string playerNameOverride = null)
    {
    }

    public static global::System.Collections.Generic.KeyValuePair<global::UnityEngine.Texture, global::UnityEngine.Rect> GetPlayerNameTexture(int id)
    {
        return default;
    }

    private void Draw(TextRendertextureGenerater.ProfilePicAtlas atlas, global::System.Collections.Generic.List<TextRendertextureGenerater.Request> requests)
    {
    }
}
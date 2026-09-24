public class PlayerTextureAtlasData : global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<PlayerTextureAtlasData.PartType, global::UnityEngine.Rect>>, global::System.Collections.IEnumerable
{
    public enum PartType
    {
        FACE = 0,
        BODY_SKIN = 1,
        EYE = 2,
        EYEBROW = 3,
        GLOVE = 4,
        ARM_SLEEVE = 5,
        SHOES = 6,
        FLAG = 7,
        TEXTURE_BACK_NUM_SINGLE = 8,
        TEXTURE_BACK_NUM_LEFT = 9,
        TEXTURE_BACK_NUM_RIGHT = 10,
        TEXTURE_FRONT_NUM_SINGLE = 11,
        TEXTURE_FRONT_NUM_LEFT = 12,
        TEXTURE_FRONT_NUM_RIGHT = 13,
        TEXTURE_SHORTS_NUM_SINGLE = 14,
        TEXTURE_SHORTS_NUM_LEFT = 15,
        TEXTURE_SHORTS_NUM_RIGHT = 16,
        NAME_BACK = 17,
        CUSTOM_JERSEY = 18,
        CUSTOM_JERSEY_UP = 19,
        CUSTOM_JERSEY_Down = 20,
        NEED_CHANGE_COLOR = 21,
        AD_SHORT_SLEEVE_LEFT = 22,
        AD_SHORT_SLEEVE_RIGHT = 23,
        AD_LONG_SLEEVE_LEFT = 24,
        AD_LONG_SLEEVE_RIGHT = 25,
        AD_SHORTS = 26,
        AD_SOCK_LEFT = 27,
        AD_SOCK_RIGHT = 28,
        WRISTBAND = 29,
        BEARD = 30,
        AD_CHEST = 31,
        AD_SPONSOR = 32,
        NO_HAIR = 33,
        TEXT = 34,
        NUMBER_BACK = 35,
        NUMBER_SHORTS = 36,
        NEED_PRINTING = 37,
        CLOTH = 38,
        SHORTS = 39,
        SOCK = 40,
        NEED_ADD_MAP = 41,
        ADD_MAP_FOR_MATCH = 42
    }

    public bool UsingMipMap;
    private global::System.Collections.Generic.Dictionary<PlayerTextureAtlasData.PartType, global::UnityEngine.Rect> blocks;
    public bool UseCache;
    public global::UnityEngine.Vector2Int TextureSize { get; set; }

    // C# has no syntax for parameterized property 'Item'.
    public global::UnityEngine.Rect this[PlayerTextureAtlasData.PartType part]
    {
        get
        {
            return default;
        }

        set
        {
        }
    }

    public int BlockCount => 0;

    public PlayerTextureAtlasData.PartType GetFirstKey()
    {
        return PlayerTextureAtlasData.PartType.FACE;
    }

    public bool HasKey(PlayerTextureAtlasData.PartType partType)
    {
        return false;
    }

    global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<PlayerTextureAtlasData.PartType, global::UnityEngine.Rect>> global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<PlayerTextureAtlasData.PartType, global::UnityEngine.Rect>>.GetEnumerator()
    {
        return null;
    }

    global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
    {
        return null;
    }
}
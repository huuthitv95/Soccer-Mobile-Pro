public class ExternalDataPacketArchive
{
    private enum TextureType
    {
        CompetitionIcon = 0,
        PlayerIcon = 1,
        TeamBadge = 2,
        AwayJersey = 3,
        HomeJersey = 4,
        AwayGKJersey = 5,
        HomeGKJersey = 6,
        count = 7
    }

    private class TextureData
    {
        public global::System.Collections.Generic.Dictionary<ExternalDataPacketArchive.TextureType, ExternalDataPacketArchive.TextureDataIndex> index;
        private int version;
        public void Load(string path)
        {
        }

        public bool Contains(ExternalDataPacketArchive.TextureType textureType, int id)
        {
            return false;
        }

        public byte[] GetTextureData(ExternalDataPacketArchive.TextureType textureType, int id)
        {
            return null;
        }
    }

    private class TextureDataIndex
    {
        private int startOffset;
        public global::System.Collections.Generic.Dictionary<int, global::System.Collections.Generic.KeyValuePair<int, int>> map;
        private string path;
        public TextureDataIndex(int starPos, string path, global::System.IO.FileStream stream)
        {
        }

        public bool Contains(int id)
        {
            return false;
        }

        public byte[] GetTextureData(int id)
        {
            return null;
        }
    }

    private string rootPath;
    private int version;
    private global::ExternalDataPacketProto.ExternalDataPacket Data;
    private global::System.Collections.Generic.HashSet<int> HomeGKJersey;
    private global::System.Collections.Generic.HashSet<int> AwayJersey;
    private global::System.Collections.Generic.HashSet<int> CompetitionIcon;
    private global::System.Collections.Generic.HashSet<int> TeamIcon;
    private global::System.Collections.Generic.HashSet<int> PlayerIcon;
    private ExternalDataPacketArchive.TextureData textureData;
    private ExternalDataPacketArchive()
    {
    }

    public static ExternalDataPacketArchive Create(string path)
    {
        return null;
    }

    public static bool Deserialization(ExternalDataPacketArchive result, byte[] buf)
    {
        return false;
    }

    public static int ReadInt32(byte[] buf)
    {
        return 0;
    }

    public static int ReadInt16(byte[] buf)
    {
        return 0;
    }

    public string GetCupName(int id)
    {
        return null;
    }

    public string GetLeagueName(int id)
    {
        return null;
    }

    public string GetTeamName(int id)
    {
        return null;
    }

    public string GetTeamNameAbbr(int id)
    {
        return null;
    }

    public string GetPlayerName(int id)
    {
        return null;
    }

    public bool ContainsCupIcon(int id)
    {
        return false;
    }

    public byte[] GetCupIcon(int id)
    {
        return null;
    }

    public bool ContainsLeagueIcon(int id)
    {
        return false;
    }

    public byte[] GetLeagueIcon(int id)
    {
        return null;
    }

    public bool ContainsTeamIcon(int id)
    {
        return false;
    }

    public byte[] GetTeamIcon(int id)
    {
        return null;
    }

    public bool ContainsPlayerIcon(int id)
    {
        return false;
    }

    public byte[] GetPlayerIcon(int id)
    {
        return null;
    }

    public bool ContainsHomeGKJersey(int id)
    {
        return false;
    }

    public byte[] GetHomeGKJersey(int id)
    {
        return null;
    }

    public bool ContainsAwayGKJersey(int id)
    {
        return false;
    }

    public byte[] GetAwayGKJersey(int id)
    {
        return null;
    }

    public bool ContainsHomeJersey(int id)
    {
        return false;
    }

    public byte[] GetHomeJersey(int id)
    {
        return null;
    }

    public bool ContainsAwayJersey(int id)
    {
        return false;
    }

    public byte[] GetAwayJersey(int id)
    {
        return null;
    }

    public global::UnityEngine.Color GetHomeJerseyColor(int id)
    {
        return default;
    }

    public global::UnityEngine.Color GetAwayJerseyColor(int id)
    {
        return default;
    }
}
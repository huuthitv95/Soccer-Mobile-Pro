public class EditablePlayerIcon : EditableData
{
    private ExternalDataArchives.ArchivesDetailType DetailType;
    private static global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<ExternalDataArchives.ArchivesDetailType, global::System.Collections.Generic.Dictionary<int, global::System.WeakReference<global::UnityEngine.Texture2D>>>> Cache;
    private ClubPlayer clubPlayer;
    public EditablePlayerIcon(int id) : base((ExternalDataArchives.ArchivesType)0, 0)
    {
    }

    private global::System.Collections.Generic.Dictionary<ExternalDataArchives.ArchivesDetailType, global::System.Collections.Generic.Dictionary<int, global::System.WeakReference<global::UnityEngine.Texture2D>>> GetCache(ExternalDataAgent agent)
    {
        return null;
    }

    public void SetClubPlayer(ClubPlayer clubPlayer)
    {
    }

    public void SaveToCache(global::UnityEngine.Texture2D myTexture)
    {
    }

    public void Save(byte[] datas, global::UnityEngine.Texture2D myTexture)
    {
    }

    public bool IsCustom()
    {
        return false;
    }

    public bool MakeImage(global::System.Action<global::UnityEngine.Texture, global::UnityEngine.Rect> action)
    {
        return false;
    }

    public global::UnityEngine.Texture2D LoadFromCache()
    {
        return null;
    }

    public static void ClearCache()
    {
    }

    public override void Reset()
    {
    }
}
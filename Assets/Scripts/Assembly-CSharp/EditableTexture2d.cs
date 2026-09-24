public class EditableTexture2d : EditableData
{
    private static global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<ExternalDataArchives.ArchivesDetailType, global::System.Collections.Generic.Dictionary<int, global::System.WeakReference<global::UnityEngine.Texture2D>>>> Cache;
    private ExternalDataArchives.ArchivesDetailType ArchivesDetailType;
    public global::UnityEngine.Texture2D OrgSprite => null;

    private global::System.Collections.Generic.Dictionary<ExternalDataArchives.ArchivesDetailType, global::System.Collections.Generic.Dictionary<int, global::System.WeakReference<global::UnityEngine.Texture2D>>> GetCache(ExternalDataAgent agent)
    {
        return null;
    }

    public void SaveToCache(global::UnityEngine.Texture2D myTexture)
    {
    }

    public global::UnityEngine.Texture2D LoadFromCache()
    {
        return null;
    }

    public static void ClearCache()
    {
    }

    public EditableTexture2d(ExternalDataArchives.ArchivesType archivesType, int id, ExternalDataArchives.ArchivesDetailType detailType) : base((ExternalDataArchives.ArchivesType)0, 0)
    {
    }

    public void Save(byte[] datas, global::UnityEngine.Texture2D myTexture)
    {
    }

    public bool IsCustom()
    {
        return false;
    }

    public bool MakeImage(global::System.Action<global::UnityEngine.Texture2D> action)
    {
        return false;
    }

    public override void Reset()
    {
    }
}
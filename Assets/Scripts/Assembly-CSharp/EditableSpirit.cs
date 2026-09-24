public class EditableSpirit : EditableData
{
    private static global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<int, global::System.WeakReference<global::UnityEngine.Sprite>>> Cache;
    private string atlasName;
    private string spriteName;
    public global::UnityEngine.Sprite OrgSprite => null;

    private static global::System.Collections.Generic.Dictionary<int, global::System.WeakReference<global::UnityEngine.Sprite>> GetCache(ExternalDataAgent agent)
    {
        return null;
    }

    public static void SaveToCache(global::UnityEngine.Sprite myTexture, ExternalDataArchives.ArchivesType archivesType, int id, ExternalDataAgent agent)
    {
    }

    public global::UnityEngine.Sprite LoadFromCache()
    {
        return null;
    }

    public static void ClearCache()
    {
    }

    public EditableSpirit(ExternalDataArchives.ArchivesType archivesType, int id, string atlas, string spriteName) : base((ExternalDataArchives.ArchivesType)0, 0)
    {
    }

    public void Save(byte[] datas, global::UnityEngine.Texture2D myTexture)
    {
    }

    public bool IsCustom()
    {
        return false;
    }

    public bool MakeImage(global::System.Action<global::UnityEngine.Sprite> action)
    {
        return false;
    }

    public override void Reset()
    {
    }
}
public class TrophyPicGenerater : PicGenerater<TrophyPicGenerater>
{
    public class TrophyPicRequest
    {
        public string name;
        public global::System.Action<global::UnityEngine.Texture, global::UnityEngine.Rect> CallBack;
    }

    private class PicAtlas
    {
        public global::System.Collections.Generic.Dictionary<string, global::UnityEngine.Rect> cached;
        public global::System.Collections.Generic.List<string> sequence;
        public global::UnityEngine.RenderTexture Texture;
        public global::UnityEngine.Vector2Int TextureSize { get; private set; }
        public global::UnityEngine.Vector2Int CellSize { get; private set; }
        public global::UnityEngine.Vector2Int cellCount => default;
        private int capacity => 0;
        public global::UnityEngine.Vector2 cellUVSize => default;
        public int EptySiteCount => 0;

        private PicAtlas()
        {
        }

        public PicAtlas(int textureWidth = 1024, int textureHeight = 512, int cellWidth = 390, int cellHeight = 512)
        {
        }

        public void Add(string name)
        {
        }
    }

    private class PicAtlasCache
    {
        public global::System.Collections.Generic.List<TrophyPicGenerater.PicAtlas> cache;
        private int maxCache;
        public PicAtlasCache(int maxCache = 4)
        {
        }

        public bool TryGetValue(string name, out global::System.Collections.Generic.KeyValuePair<global::UnityEngine.Texture, global::UnityEngine.Rect> data)
        {
            data = default;
            return false;
        }

        public TrophyPicGenerater.PicAtlas GetHasSiteAtlas()
        {
            return null;
        }
    }

    private global::UnityEngine.GameObject canvas;
    private global::System.Collections.Generic.List<global::UnityEngine.Transform> items;
    private global::UnityEngine.GameObject light;
    private global::UnityEngine.GameObject light2;
    private global::System.Collections.Generic.Queue<TrophyPicGenerater.TrophyPicRequest> requestQueue;
    private TrophyPicGenerater.PicAtlasCache caches;
    protected override string ScenePath => null;

    protected override bool CheckEnableUpdate()
    {
        return false;
    }

    protected override void ConsumeTask()
    {
    }

    protected override void OnInit(global::UnityEngine.GameObject root)
    {
    }

    public void GetProfilePic(string name, global::System.Action<global::UnityEngine.Texture, global::UnityEngine.Rect> onGet)
    {
    }

    private bool GetProfilePic(global::System.Collections.Generic.List<TrophyPicGenerater.TrophyPicRequest> requests, TrophyPicGenerater.PicAtlas atlas)
    {
        return false;
    }
}
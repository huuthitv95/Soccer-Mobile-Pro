public class ProfilePicGenerater : MonoSingleton<ProfilePicGenerater>
{
    private class RenderTask
    {
        public global::System.Collections.Generic.List<ProfilePicGenerater.ProfilePicRequest> requests;
        public ProfilePicGenerater.ProfilePicAtlas atlas;
        private ProfilePicGenerater generater;
        private int preproccessCounter;
        private int step;
        public RenderTask(ProfilePicGenerater generater, global::System.Collections.Generic.List<ProfilePicGenerater.ProfilePicRequest> requests, ProfilePicGenerater.ProfilePicAtlas atlas)
        {
        }

        private void Init()
        {
        }

        public void ApplyPlayer(bool isProcessedInStages)
        {
        }

        private void Draw()
        {
        }

        public bool Schedule(bool isProcessedInStages)
        {
            return false;
        }
    }

    public class ProfilePicRequest
    {
        public ClubPlayer Players;
        public global::System.Action<global::UnityEngine.Texture, global::UnityEngine.Rect> CallBack;
    }

    private class ProfilePicAtlas
    {
        private const int capacity = 32;
        private global::System.Collections.Generic.Dictionary<int, global::UnityEngine.Rect> cached;
        public global::UnityEngine.RenderTexture Texture;
        public int EptySiteCount => 0;

        public void Add(int id)
        {
        }

        public bool TryGetOriginalRect(int id, out global::UnityEngine.Rect rect)
        {
            rect = default;
            return false;
        }

        public bool tryGetReduceRect(int id, out global::UnityEngine.Rect rect)
        {
            rect = default;
            return false;
        }

        public bool Contains(int id)
        {
            return false;
        }

        public void Remove(int playerid)
        {
        }
    }

    private class ProfilePicAtlasCache
    {
        public global::System.Collections.Generic.List<ProfilePicGenerater.ProfilePicAtlas> cache;
        private static global::UnityEngine.Texture2D defaultPlayerIcon;
        public bool TryGetValue(int id, out global::System.Collections.Generic.KeyValuePair<global::UnityEngine.Texture, global::UnityEngine.Rect> data)
        {
            data = default;
            return false;
        }

        public ProfilePicGenerater.ProfilePicAtlas GetHasSiteAtlas()
        {
            return null;
        }
    }

    private global::UnityEngine.Camera camera;
    private bool loading;
    private PlayerRender[] players;
    private global::System.Collections.Generic.List<global::UnityEngine.GameObject> playersGO;
    private global::UnityEngine.GameObject canvas;
    private global::UnityEngine.GameObject light;
    private global::UnityEngine.GameObject light2;
    private global::UnityEngine.Material correctRtAlphaMaterial;
    private global::System.Collections.Generic.Queue<ProfilePicGenerater.ProfilePicRequest> requestQueue;
    private global::System.Collections.Generic.Dictionary<ClubPlayer, global::System.Action<global::UnityEngine.Texture, global::UnityEngine.Rect>> waiting;
    private global::System.Collections.Generic.Queue<ProfilePicGenerater.RenderTask> renderTasks;
    private ProfilePicGenerater.ProfilePicAtlasCache caches;
    private global::UnityEngine.Material CorrectRtAlphaMaterial => null;

    private void Awake()
    {
    }

    private void OnDestroy()
    {
    }

    public void LoadScene()
    {
    }

    public void Init()
    {
    }

    public void ScheduleAll()
    {
    }

    private void DoSchedule(bool isSinglePass)
    {
    }

    private void Update()
    {
    }

    private void ConsumeTask()
    {
    }

    public void GetProfilePic(ClubPlayer clubPlayers, global::System.Action<global::UnityEngine.Texture, global::UnityEngine.Rect> onGet)
    {
    }

    public void ClearCache(int playerId)
    {
    }

    public void GetProfilePic(global::System.Collections.Generic.List<ClubPlayer> clubPlayers, global::System.Action<global::UnityEngine.Texture, global::UnityEngine.Rect, ClubPlayer> onGet)
    {
    }

    private void GetProfilePic(global::System.Collections.Generic.List<ProfilePicGenerater.ProfilePicRequest> requests, ProfilePicGenerater.ProfilePicAtlas atlas)
    {
    }
}
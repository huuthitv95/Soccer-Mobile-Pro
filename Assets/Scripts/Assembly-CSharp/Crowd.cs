public class Crowd : global::UnityEngine.MonoBehaviour
{
    private struct TifoVertex
    {
        public global::UnityEngine.Vector3 position;
        public global::UnityEngine.Vector2 uv;
    }

    private enum AnimName
    {
        Sit = 0,
        Sit2Stand = 1,
        Stand = 2,
        SitImmediately = 3,
        Wait2Stand = 4
    }

    public enum CrowdSide
    {
        Away = -1,
        Neutral = 0,
        Home = 1
    }

    public static Crowd Instance;
    public float PlaySpeed;
    public float PlaySpeedScale;
    public static bool AllMine;
    [global::UnityEngine.SerializeField]
    private bool timelineStadium;
    private global::UnityEngine.Mesh tifoMesh;
    private global::UnityEngine.Material tifoMaterial;
    private global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4>> tifoMatrices;
    private global::System.Collections.Generic.List<float> animOffsets;
    private global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> currentAnimMatrices;
    private global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> tifoAnimMatrices;
    [global::UnityEngine.SerializeField]
    private bool enableTifo;
    private bool hasTifoRuntime;
    private global::UnityEngine.Matrix4x4[] renderMatrices;
    public bool ShowTifo;
    private float _time;
    private readonly int[] AnimStartIdx;
    private readonly int[] AnimLength;
    private Crowd.AnimName _targetAnim;
    private int _transmissionTick;
    private int _updateTick;
    private float _lastTick;
    private const int MAX_ANIM_OFFSET = 8;
    private const int WAIT_TICK = 8;
    public static Crowd.CrowdSide TargetSide;
    public global::UnityEngine.Material _CrowdMaterial;
    public global::UnityEngine.Texture _CrowdTex;
    public global::UnityEngine.Texture _ColorMask;
    public global::UnityEngine.Texture _ChairTex;
    private global::UnityEngine.Material _OriginalMaterial;
    private global::UnityEngine.Material _HomeTeamMaterial;
    private global::UnityEngine.Material _AwayTeamMaterial;
    private float ANIMATION_TICK_PER_SECOND;
    private global::UnityEngine.Material _CrowdMaterialInstance;
    private global::System.Collections.Generic.List<global::UnityEngine.Vector3> newVertices;
    private global::System.Collections.Generic.List<global::UnityEngine.Vector2> newUV;
    private global::System.Collections.Generic.List<global::UnityEngine.Vector2> newUV2;
    private global::System.Collections.Generic.List<global::UnityEngine.Color32> newColors;
    private global::System.Collections.Generic.List<int> newTriangles;
    private global::System.Collections.Generic.List<global::UnityEngine.Vector2> tmpUV2;
    private global::System.Collections.Generic.List<global::UnityEngine.Color32> tmpColors;
    private bool IsTifoRuntimeEnabled => false;

    private void InitializeTifoRuntime()
    {
    }

    private void PrepareTifoForCurrentMatch(global::UnityEngine.Color homeColor)
    {
    }

    private global::System.Collections.Generic.List<global::UnityEngine.Matrix4x4> CreateTifoMatricesForSection(int crowdSide)
    {
        return null;
    }

    private void UpdateAndRenderTifo()
    {
    }

    private void Awake()
    {
    }

    private void OnEnable()
    {
    }

    private void OnDisable()
    {
    }

    private void OnDestroy()
    {
    }

    private void Update()
    {
    }

    private global::UnityEngine.Matrix4x4 LerpMatrix(global::UnityEngine.Matrix4x4 a, global::UnityEngine.Matrix4x4 b, float t)
    {
        return default;
    }

    private void SetAllSit(global::UnityEngine.Transform child)
    {
    }

    private void UpdateAnimTick(Crowd.CrowdSide targetside)
    {
    }

    private void SetTick(int tick)
    {
    }

    public void ActiveCelebration(bool standup, Crowd.CrowdSide side, bool immediately = false)
    {
    }

    private void ResetTick()
    {
    }

    private void InitializeCrowdGameObject(global::UnityEngine.GameObject crowdGO, float crowdDensity, int crowdSide, global::UnityEngine.Color homeColor, global::UnityEngine.Color awayColor, global::DynamicCrowd.CrowdSection crowdSection, byte[] brightnessData, int offset)
    {
    }

    private void ActiveCrowdAnimation(global::UnityEngine.GameObject crowdGO, Crowd.AnimName anim, int mask, int delay)
    {
    }

    public global::UnityEngine.Texture GenCrowdTexture(bool isNeutral, global::UnityEngine.Color teamColor)
    {
        return null;
    }
}
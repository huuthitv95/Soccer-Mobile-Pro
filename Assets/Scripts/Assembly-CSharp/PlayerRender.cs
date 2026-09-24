public class PlayerRender : global::UnityEngine.MonoBehaviour, IPlayerRender
{
    private class MeshConfig
    {
        public enum HeadMaterialsOrder
        {
            Eye_Face = 0,
            Face_Eye = 1
        }

        public bool isFemale;
        public global::UnityEngine.SkinnedMeshRenderer HeadHD;
        public global::UnityEngine.SkinnedMeshRenderer BodyHD;
        public global::UnityEngine.SkinnedMeshRenderer Body;
        public PlayerRender.MeshConfig.HeadMaterialsOrder headMaterialsOrder;
        public global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::UnityEngine.GameObject, bool>> womanNodes;
        public global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::UnityEngine.GameObject, bool>> manNodes;
        public global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::UnityEngine.GameObject, bool>> commonNodes;
        private PlayerRender owner;
        public void Reset(PlayerRender owner)
        {
        }

        public void SetMeshVisible(bool highGraphic)
        {
        }
    }

    public global::UnityEngine.SkinnedMeshRenderer[] bodyRenders;
    public global::UnityEngine.SkinnedMeshRenderer[] sideline;
    public global::UnityEngine.Renderer[] collars;
    private AppearanceData appearanceData;
    private global::UnityEngine.Renderer hairs;
    private global::UnityEngine.Renderer hairs_hd;
    public global::UnityEngine.Color MainColor;
    private bool hasHDTexture;
    private PlayerRender.MeshConfig meshConfig;
    private float winkShape;
    private static global::UnityEngine.Material awaySubsClothMat;
    private string[] FemaleHair;
    private bool hasHD_mesh;
    private bool hasLD_mesh;
    private bool usingHD;
    public static string hairFolderHD;
    public static string hairFolder;
    public bool hasNewHDHairMesh;
    public static readonly global::System.Collections.Generic.Dictionary<string, float> HairConfig;
    private global::UnityEngine.GameObject energyEffect;
    private static global::UnityEngine.Material Up_tightMat;
    private static global::UnityEngine.Material Up_normalMat;
    private static global::UnityEngine.Material down_tightMat;
    private static global::UnityEngine.Material down_normalMat;
    private global::System.Collections.Generic.HashSet<string> faceDecoration;
    private global::System.Collections.Generic.List<global::UnityEngine.GameObject> faceDecorationGos;
    public bool Visiable { get; private set; }

    internal void SetAppearanceData(AppearanceData data)
    {
    }

    private void Awake()
    {
    }

    public void CheckChangeHDHead(string headMeshName)
    {
    }

    private void CheckChangeHDHead(global::FLDataTable.StarPlayerAppearance starPlayerAppearance, string headMeshName)
    {
    }

    public void ResetHDHead()
    {
    }

    public void ApplyMainTexture(global::UnityEngine.Texture texture)
    {
    }

    public void SetBlendShapeWeight(sbyte[] datas, sbyte[] somatotype)
    {
    }

    private void OnDestroy()
    {
    }

    public void SetWinkShape(float v)
    {
    }

    public global::System.Collections.IEnumerator DoWinkAnim(bool open = false)
    {
        return null;
    }

    public void StartWinkAnim(bool open = false)
    {
    }

    public void ResetWink()
    {
    }

    public void ShowSubsCloth(bool isHome)
    {
    }

    public void UseHDHead()
    {
    }

    public void UseLowHead()
    {
    }

    public void HideMesh()
    {
    }

    public void ShowMesh()
    {
    }

    public void MarkInvisible()
    {
    }

    public void ResetInvisible()
    {
    }

    public void ResetTexture()
    {
    }

    public void ShowSideline(bool show)
    {
    }

    public void ShowHairs(bool show)
    {
    }

    public void ChangeHairsRenderQueue(int offset = 2, global::UnityEngine.Rendering.RenderQueue baseValue = global::UnityEngine.Rendering.RenderQueue.Transparent)
    {
    }

    public void SetHeight(int height)
    {
    }

    private static void EnableRenderer(global::UnityEngine.Renderer renderer, bool able)
    {
    }

    private global::UnityEngine.Mesh GetWritableHairMesh(global::UnityEngine.Renderer renderer)
    {
        return null;
    }

    private void ApplyAtlasUv(global::UnityEngine.Mesh mesh, global::UnityEngine.Vector2 scale, global::UnityEngine.Vector2 offset)
    {
    }

    public void ChangeHair(string name, global::UnityEngine.Color? color, global::UnityEngine.Color? color2, global::UnityEngine.Color? colorSpec, bool useatlas, bool useHDHair, bool useBlinnPhongInGame)
    {
    }

    public void SwitchHDHair(bool hd)
    {
    }

    public global::UnityEngine.Renderer GetHairRender()
    {
        return null;
    }

    private global::UnityEngine.GameObject TryLoadHairMesh(string name, bool useHDHair)
    {
        return null;
    }

    private bool hairFillter(out global::UnityEngine.Transform targetHair, string hairName, bool useHDHair)
    {
        targetHair = null;
        return false;
    }

    private bool checkHair(string MeshName)
    {
        return false;
    }

    public void ApplyHDTexture(global::System.Collections.Generic.List<global::UnityEngine.Texture> lod, global::System.Collections.Generic.List<global::UnityEngine.Texture> head)
    {
    }

    public void SwitchLod(bool high)
    {
    }

    public void SetClothColor(global::UnityEngine.Color color)
    {
    }

    public void ShowEnergyEffct()
    {
    }

    public void ApplyHead(global::System.Collections.Generic.List<global::UnityEngine.Texture> head)
    {
    }

    public void ChangeJerseyStyle(int style)
    {
    }

    public void SetFaceDecoration(string decoration)
    {
    }

    public void ReleaseCurrentMainTexture()
    {
    }

    public void ReleaseCurrentHDTexture()
    {
    }

    public void ReleaseCurrentHeadTexture()
    {
    }
}
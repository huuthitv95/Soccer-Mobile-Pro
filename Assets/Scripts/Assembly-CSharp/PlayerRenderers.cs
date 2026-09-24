public class PlayerRenderers : global::UnityEngine.MonoBehaviour
{
    public bool female;
    public bool hideBody;
    public static readonly global::System.Collections.Generic.Dictionary<string, float> HairConfig;
    public static readonly global::System.Collections.Generic.Dictionary<string, float> HairAlphaOffsetConfig;
    public static readonly global::System.Collections.Generic.List<string> HasMeshBeards;
    public static readonly global::System.Collections.Generic.Dictionary<string, string> GlassesConfig;
    public global::UnityEngine.Renderer[] skins;
    public global::UnityEngine.Renderer[] heads;
    public global::UnityEngine.Renderer[] shoes;
    public global::UnityEngine.Renderer[] bandages;
    public global::UnityEngine.Renderer hairs;
    public global::UnityEngine.Renderer hairs_lod1;
    private global::UnityEngine.Vector2[] _originalHairUV;
    private global::UnityEngine.Vector2[] _originalHairUVLod1;
    public global::UnityEngine.Renderer[] uniforms;
    public global::UnityEngine.Renderer[] gloves;
    public global::UnityEngine.Renderer[] hands;
    public global::UnityEngine.Renderer beards;
    public global::UnityEngine.Renderer[] vests;
    public global::UnityEngine.Renderer captainFlag;
    public global::UnityEngine.Renderer refereeFlag;
    public global::UnityEngine.Renderer refereeFlagClosed;
    public global::UnityEngine.Renderer[] teeth;
    private global::UnityEngine.Renderer Glasses;
    public global::UnityEngine.Renderer[] christmasParts;
    private global::System.Collections.Generic.Dictionary<string, global::UnityEngine.Renderer> m_BeardCache;
    public global::UnityEngine.SkinnedMeshRenderer head_lod0;
    public global::UnityEngine.SkinnedMeshRenderer head_lod3;
    public global::UnityEngine.SkinnedMeshRenderer head_lod03;
    public global::UnityEngine.SkinnedMeshRenderer female_head_lod0;
    public global::UnityEngine.SkinnedMeshRenderer female_head_lod3;
    public global::UnityEngine.Renderer[] AllRenders;
    public global::UnityEngine.GameObject hairProto;
    public global::UnityEngine.Transform _boneHead;
    public global::UnityEngine.GameObject beardProto;
    public global::UnityEngine.GameObject glassesProto;
    public bool checkHair(string meshName, bool split = false)
    {
        return false;
    }

    private static global::UnityEngine.Vector2[] GetOriginalUV(global::UnityEngine.Renderer r)
    {
        return null;
    }

    public void UpdateHairUV(global::UnityEngine.Renderer r, global::UnityEngine.Vector2 scale, global::UnityEngine.Vector2 offset)
    {
    }

    public void DestroyHair()
    {
    }

    public bool CheckBeard(string meshName)
    {
        return false;
    }

    public global::UnityEngine.Renderer CheckGlasses(string textureName)
    {
        return null;
    }

    public bool Init()
    {
        return false;
    }
}
public class Effects
{
    private const string k_effect_dir = "Assets/GameData/Effects/";
    private global::System.Collections.Generic.Dictionary<EffectID, global::UnityEngine.GameObject> _allEffects;
    private static Effects _instance;
    private static global::UnityEngine.GameObject _effectParent;
    private global::System.Collections.Generic.List<global::UnityEngine.GameObject> allLoadEffectGo;
    public static Effects Instance => null;

    private bool LoadEffect(EffectID effectId)
    {
        return false;
    }

    public void Clear()
    {
    }

    public global::UnityEngine.GameObject GetEffectObj(EffectID id)
    {
        return null;
    }

    public global::UnityEngine.GameObject Play(EffectID effectId, global::UnityEngine.Vector3 effectPosition, float scale = 1f, global::UnityEngine.Quaternion rotation = default(global::UnityEngine.Quaternion), bool loop = false)
    {
        return null;
    }

    public static void PlayEffectWithChilds(global::UnityEngine.Transform transform)
    {
    }

    public void Stop(EffectID effectId)
    {
    }
}
public class TifoManager : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.SkinnedMeshRenderer corwd_HomeFlag_Friendly;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.SkinnedMeshRenderer corwd_AwayFlag_Friendly;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.SkinnedMeshRenderer[] corwd_HomeFlag_HomeAway;
    public void Init(bool isHomeAwayMatch, global::UnityEngine.Texture homeTexture, global::UnityEngine.Texture awayTexture)
    {
    }

    public void Hide()
    {
    }

    public static TifoManager LoadPrefab(global::UnityEngine.Transform parent)
    {
        return null;
    }
}
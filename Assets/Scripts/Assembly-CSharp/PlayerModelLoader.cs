public class PlayerModelLoader : global::UnityEngine.MonoBehaviour
{
    private enum ModelType
    {
        Normal = 0,
        UIPlayer = 1
    }

    private enum LayerType
    {
        GamePlayer = 0,
        UI = 1
    }

    private enum AnimationControllerType
    {
        Normal = 0,
        SelectRole = 1
    }

    private static readonly string[] modelPath;
    private static global::UnityEngine.GameObject[] modelPrefabs;
    private static readonly string[] animationControllerPath;
    private static global::System.WeakReference<global::UnityEngine.RuntimeAnimatorController>[] animationControllers;
    [global::UnityEngine.SerializeField]
    private PlayerModelLoader.ModelType modelType;
    [global::UnityEngine.SerializeField]
    private PlayerModelLoader.AnimationControllerType animationControllerType;
    [global::UnityEngine.SerializeField]
    private PlayerModelLoader.LayerType layer;
    [global::UnityEngine.SerializeField]
    private bool loadOnStart;
    public static global::UnityEngine.GameObject NormalModelPrefab => null;
    public static global::UnityEngine.GameObject UIPlayerModelPrefab => null;
    private global::UnityEngine.GameObject playerGO { get; set; }

    private static global::UnityEngine.GameObject GetModelPrefab(PlayerModelLoader.ModelType modelType)
    {
        return null;
    }

    private static global::UnityEngine.RuntimeAnimatorController GetAnimationController(PlayerModelLoader.AnimationControllerType type)
    {
        return null;
    }

    private void Start()
    {
    }

    public global::UnityEngine.GameObject CheckGetPlayerModel()
    {
        return null;
    }

    public global::UnityEngine.GameObject DetachPlayerModel()
    {
        return null;
    }

    public global::UnityEngine.GameObject AttachPlayerModel(global::UnityEngine.GameObject playerModel, bool worldPositionStays = false)
    {
        return null;
    }

    private void CheckLoadAnimationController(global::UnityEngine.GameObject go)
    {
    }
}
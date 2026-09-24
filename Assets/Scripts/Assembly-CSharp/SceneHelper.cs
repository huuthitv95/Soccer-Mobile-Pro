public class SceneHelper
{
    private static global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.Dictionary<int, bool>> sceneRootObjectsActivable;
    public static global::System.Collections.Generic.HashSet<string> TimelineBeforeMainMenu;
    public static global::System.Action _OnMainSceneLoaded;
    public static void Init()
    {
    }

    private static void SetSceneRootActive(string path, bool active)
    {
    }

    private static void SceneManager_sceneUnloaded(global::UnityEngine.SceneManagement.Scene arg0)
    {
    }

    private static string FullScenePathToLoadPath(string fullPath)
    {
        return null;
    }

    public static void UnLoadScene(string path)
    {
    }

    public static void SetSceneRootActive(global::UnityEngine.SceneManagement.Scene scene, bool active)
    {
    }

    public static LoadingSceneProgress LoadScenesAsync(global::System.Collections.Generic.List<string> loads, global::System.Action completed, bool loadBackground)
    {
        return null;
    }

    public static void ChangeScenes(global::System.Collections.Generic.List<string> loads, global::System.Collections.Generic.List<string> hides)
    {
    }

    public static LoadingSceneProgress LoadScenes(global::System.Collections.Generic.List<string> loads, global::System.Collections.Generic.List<string> hides, global::System.Action completed = null)
    {
        return null;
    }

    public static void UnloadScnesExcept(global::System.Collections.Generic.List<int> excepts)
    {
    }

    public static global::System.Collections.IEnumerator SwitchToGame(CupMatchBase match, global::System.Action complete = null)
    {
        return null;
    }

    public static void BackToMain(global::System.Action OnMainSceneLoaded)
    {
    }

    public static void BackToMain()
    {
    }
}
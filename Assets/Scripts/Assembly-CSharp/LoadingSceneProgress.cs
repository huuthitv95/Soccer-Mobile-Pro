public class LoadingSceneProgress
{
    private global::System.Collections.Generic.List<global::UnityEngine.AsyncOperation> loadings;
    private global::System.Collections.Generic.List<string> _names;
    public float GetProgress()
    {
        return 0f;
    }

    public void AddOperation(global::UnityEngine.AsyncOperation operation, string name)
    {
    }

    public void UnloadAll()
    {
    }

    private global::System.Collections.IEnumerator UnloadAfterComplete(global::UnityEngine.AsyncOperation progress, string name)
    {
        return null;
    }

    public void Clear()
    {
    }
}
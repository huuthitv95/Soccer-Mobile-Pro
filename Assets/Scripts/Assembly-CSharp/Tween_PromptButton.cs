public class Tween_PromptButton : global::UnityEngine.MonoBehaviour
{
    public bool onlyOnce;
    protected const float DT = 0.45f;
    protected const float overshoot = 3.2f;
    private global::UnityEngine.Vector3 localScale;
    protected virtual void OnEnable()
    {
    }

    protected virtual void OnDisable()
    {
    }

    protected virtual global::System.Collections.IEnumerator DelayPrompt()
    {
        return null;
    }
}
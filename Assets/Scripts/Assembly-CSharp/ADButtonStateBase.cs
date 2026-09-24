public abstract class ADButtonStateBase : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    protected bool state;
    [global::UnityEngine.SerializeField]
    protected global::UnityEngine.UI.Button button;
    public global::UnityEngine.Events.UnityEvent<bool> OnADStateChanged;
    public virtual global::UnityEngine.UI.Button Button => null;
    public bool State => false;

    public virtual void UpdateForADState(bool state)
    {
    }

    protected abstract void OnUpdateForADState(bool state);
}
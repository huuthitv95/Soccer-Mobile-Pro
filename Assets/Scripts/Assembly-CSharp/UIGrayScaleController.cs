[global::UnityEngine.DisallowMultipleComponent]
public class UIGrayScaleController : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Material grayMaterial;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform TargetRoot;
    [global::UnityEngine.SerializeField]
    private bool applyOnEnable;
    [global::UnityEngine.SerializeField]
    private bool restoreOnDisable;
    private readonly global::System.Collections.Generic.Dictionary<global::UnityEngine.UI.Graphic, global::UnityEngine.Material> originalMaterials;
    private bool isGrayApplied;
    private void Awake()
    {
    }

    private void OnEnable()
    {
    }

    private void OnDisable()
    {
    }

    public void ApplyGrayScale()
    {
    }

    public void RestoreOriginalMaterials()
    {
    }

    public void SetGray(bool enable)
    {
    }

    private void ApplyGrayScaleInternal()
    {
    }
}
[global::UnityEngine.DisallowMultipleComponent]
public sealed class OverlayGradientImage : global::UnityEngine.EventSystems.UIBehaviour, global::UnityEngine.UI.IMeshModifier, global::UnityEngine.UI.IMaterialModifier
{
    private const string ShaderName = "UI/Overlay Gradient";
    private static readonly int ColorKey0Property;
    private static readonly int MiddleColorKeyProperty;
    private static readonly int ColorKey1Property;
    private static readonly int KeyPosition0Property;
    private static readonly int MiddleKeyPositionProperty;
    private static readonly int KeyPosition1Property;
    private static readonly int BlendInGammaSpaceProperty;
    private const string BlendInGammaSpaceKeyword = "OVERLAY_BLEND_GAMMA";
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Color _colorKey0;
    [global::UnityEngine.SerializeField]
    private float _keyPosition0;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Color _middleColorKey;
    [global::UnityEngine.SerializeField]
    private float _middleKeyPosition;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Color _colorKey1;
    [global::UnityEngine.SerializeField]
    private float _keyPosition1;
    [global::UnityEngine.SerializeField]
    private float _gradientAngle;
    [global::UnityEngine.SerializeField]
    private bool _blendInGammaSpace;
    [global::UnityEngine.HideInInspector]
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Shader _shader;
    private global::UnityEngine.UI.Image _image;
    private global::UnityEngine.Material _runtimeMaterial;
    private global::UnityEngine.Material _runtimeMaterialSource;
    private global::UnityEngine.UIVertex _vertex;
    private bool _shaderErrorLogged;
    public global::UnityEngine.Color ColorKey0
    {
        get
        {
            return default;
        }

        set
        {
        }
    }

    public float KeyPosition0
    {
        get
        {
            return 0f;
        }

        set
        {
        }
    }

    public global::UnityEngine.Color MiddleColorKey
    {
        get
        {
            return default;
        }

        set
        {
        }
    }

    public float MiddleKeyPosition
    {
        get
        {
            return 0f;
        }

        set
        {
        }
    }

    public global::UnityEngine.Color ColorKey1
    {
        get
        {
            return default;
        }

        set
        {
        }
    }

    public float KeyPosition1
    {
        get
        {
            return 0f;
        }

        set
        {
        }
    }

    public float GradientAngle
    {
        get
        {
            return 0f;
        }

        set
        {
        }
    }

    public bool BlendInGammaSpace
    {
        get
        {
            return false;
        }

        set
        {
        }
    }

    private global::UnityEngine.UI.Image Image => null;

    public void ModifyMesh(global::UnityEngine.UI.VertexHelper vertexHelper)
    {
    }

    [global::System.Obsolete]
    public void ModifyMesh(global::UnityEngine.Mesh mesh)
    {
    }

    public global::UnityEngine.Material GetModifiedMaterial(global::UnityEngine.Material baseMaterial)
    {
        return null;
    }

    protected override void OnEnable()
    {
    }

    protected override void OnDisable()
    {
    }

    protected override void OnDestroy()
    {
    }

    protected override void OnRectTransformDimensionsChange()
    {
    }

    protected override void OnDidApplyAnimationProperties()
    {
    }

    private global::UnityEngine.Vector2 GetGradientDirection()
    {
        return default;
    }

    private static float NormalizePosition(float position, float minimum, float size)
    {
        return 0f;
    }

    private void NormalizeSerializedValues()
    {
    }

    private global::UnityEngine.Shader ResolveShader()
    {
        return null;
    }

    private void CreateRuntimeMaterial(global::UnityEngine.Material baseMaterial, global::UnityEngine.Shader shader)
    {
    }

    private void ApplyMaterialProperties()
    {
    }

    private void SetMaterialDirty()
    {
    }

    private void SetVerticesDirty()
    {
    }

    private void DestroyRuntimeMaterial()
    {
    }
}
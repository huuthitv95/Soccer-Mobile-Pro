[global::UnityEngine.DisallowMultipleComponent]
public class ColorPaletteImage : global::UnityEngine.MonoBehaviour
{
    public enum PaletteMaskFormat
    {
        Blend = 0,
        R8 = 1
    }

    private const string ShaderName = "UI/IndexedPalette";
    private const string PaletteTexturePropertyName = "_PaletteTex";
    private const string PaletteWidthPropertyName = "_PaletteWidth";
    private const string PaletteHeightPropertyName = "_PaletteHeight";
    private const string PaletteRowPropertyName = "_PaletteRow";
    private const string PaletteTransitionEnabledPropertyName = "_PaletteTransitionEnabled";
    private const string PaletteTransitionProgressPropertyName = "_PaletteTransitionProgress";
    private const string PaletteTransitionRowPropertyName = "_PaletteTransitionRow";
    private const string PaletteTransitionKeyword = "PALETTE_ROW_TRANSITION";
    private const string SingleChannelMaskPropertyName = "_SingleChannelMask";
    private const string SingleChannelMaskKeyword = "PALETTE_MASK_R8";
    private const string OutputBilinearPropertyName = "_OutputBilinear";
    private const string OutputBilinearKeyword = "PALETTE_OUTPUT_BILINEAR";
    private const float DefaultPaletteTransitionDuration = 0.25f;
    private const int TextureImportMaxSize = 8192;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Sprite _maskSprite;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Texture2D _paletteTexture;
    [global::UnityEngine.SerializeField]
    private int _paletteIndex;
    [global::UnityEngine.SerializeField]
    private ColorPaletteImage.PaletteMaskFormat _maskFormat;
    [global::UnityEngine.SerializeField]
    private bool _applyMaskSprite;
    [global::UnityEngine.SerializeField]
    private bool _forcePointSampling;
    [global::UnityEngine.SerializeField]
    private bool _animatePaletteTransitions;
    [global::UnityEngine.SerializeField]
    private float _paletteTransitionDuration;
    [global::UnityEngine.SerializeField]
    private bool _outputBilinear;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Material _materialTemplate;
    private global::UnityEngine.UI.Image _image;
    private global::UnityEngine.Material _runtimeMaterial;
    private global::UnityEngine.Material _runtimeMaterialSource;
    private bool _isPaletteTransitioning;
    private int _paletteTransitionFromIndex;
    private int _paletteTransitionToIndex;
    private float _paletteTransitionElapsed;
    private float _activePaletteTransitionDuration;
    public global::UnityEngine.Sprite MaskSprite
    {
        get
        {
            return null;
        }

        set
        {
        }
    }

    public global::UnityEngine.Texture2D PaletteTexture
    {
        get
        {
            return null;
        }

        set
        {
        }
    }

    public int PaletteIndex
    {
        get
        {
            return 0;
        }

        set
        {
        }
    }

    public int ColorCount => 0;
    public int PaletteCount => 0;

    public ColorPaletteImage.PaletteMaskFormat MaskFormat
    {
        get
        {
            return ColorPaletteImage.PaletteMaskFormat.Blend;
        }

        set
        {
        }
    }

    public bool AnimatePaletteTransitions
    {
        get
        {
            return false;
        }

        set
        {
        }
    }

    public float PaletteTransitionDuration
    {
        get
        {
            return 0f;
        }

        set
        {
        }
    }

    public bool OutputBilinear
    {
        get
        {
            return false;
        }

        set
        {
        }
    }

    public void Apply()
    {
    }

    public void SetPaletteIndex(int paletteIndex)
    {
    }

    public void SetPaletteIndex(int paletteIndex, bool animate)
    {
    }

    public void SetPaletteIndex(int paletteIndex, float transitionDuration)
    {
    }

    public void SetPaletteIndexImmediate(int paletteIndex)
    {
    }

    private void OnEnable()
    {
    }

    private void OnDisable()
    {
    }

    private void OnDestroy()
    {
    }

    private void Update()
    {
    }

    private void OnValidate()
    {
    }

    private void ApplyMaterialProperties()
    {
    }

    private int ClampPaletteIndex(int paletteIndex)
    {
        return 0;
    }

    private int GetTexturePaletteRow(int paletteIndex)
    {
        return 0;
    }

    private void CompletePaletteTransition()
    {
    }

    private int GetPaletteTransitionStartIndex()
    {
        return 0;
    }

    private float GetPaletteTransitionProgress()
    {
        return 0f;
    }

    private void ResetPaletteTransitionState()
    {
    }

    private static void SetMaterialKeyword(global::UnityEngine.Material material, string keyword, bool enabled)
    {
    }

    private void ApplyTextureSamplingSettings()
    {
    }

    private static void ApplyTextureSamplingSettings(global::UnityEngine.Texture2D texture, bool isMaskTexture)
    {
    }

    private void ClearRuntimeMaterial()
    {
    }

    private void EnsureImage()
    {
    }

    private global::UnityEngine.Material EnsureRuntimeMaterial()
    {
        return null;
    }
}
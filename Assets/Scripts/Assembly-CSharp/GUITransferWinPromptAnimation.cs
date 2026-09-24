[global::UnityEngine.DisallowMultipleComponent]
public sealed class GUITransferWinPromptAnimation : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform messagePanel;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.CanvasGroup messagePanelCanvasGroup;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform character;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.CanvasGroup characterCanvasGroup;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform actionButton;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.CanvasGroup actionButtonCanvasGroup;
    private const float CharacterStartTime = 0.35f;
    private const float CharacterMoveDuration = 0.32f;
    private const float CharacterFadeDuration = 0.24f;
    private const float CharacterStartOffsetY = 110f;
    private const float MessageStartTime = 0.65f;
    private const float MessageMoveDuration = 0.36f;
    private const float MessageStartOffsetX = 520f;
    private const float ButtonStartTime = 0.95f;
    private const float ButtonFadeDuration = 0.18f;
    private const float ButtonScaleDuration = 0.24f;
    private const float ButtonStartScale = 0.82f;
    private global::UnityEngine.Vector2 messageShownPosition;
    private global::UnityEngine.Vector2 characterShownPosition;
    private global::UnityEngine.Vector3 buttonShownScale;
    private global::DG.Tweening.Sequence sequence;
    private void Awake()
    {
    }

    private void OnEnable()
    {
    }

    private void OnDisable()
    {
    }

    private void Play()
    {
    }

    private void Kill()
    {
    }
}
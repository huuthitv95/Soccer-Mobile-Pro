public class Win_LicensedChallenge : global::Common.WindowBase
{
    [global::System.Serializable]
    public class HighlightTween
    {
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Image image;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.UI.Text text;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Color disableColor;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.Color enableColor;
        [global::UnityEngine.SerializeField]
        private float fadeDuration;
        [global::UnityEngine.SerializeField]
        private float holdTime;
        [global::UnityEngine.SerializeField]
        private float phaseOffset;
        private global::DG.Tweening.Sequence imageSeq;
        private global::DG.Tweening.Sequence textSeq;
        public void PlayHighlight()
        {
        }

        public void StopHighlight()
        {
        }
    }

    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text manCityRatingText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text monacoRatingText;
    [global::UnityEngine.SerializeField]
    private GUITabGroupStyle tabGroup;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.RawImage manCityRewardImage;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.RawImage monacoRewardImage;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform manCityTweenTarget;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform monacoTweenTarget;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject manCityCompleteMark;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject monacoCompleteMark;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Toggle manCityToggle;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Toggle monacoToggle;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnPlay;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button manCityCompleteButton;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button monacoCompleteButton;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button startManCityBtn;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button startMonacoBtn;
    private int currentTeamIndex;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.CanvasGroup chooseTeamMark;
    [global::UnityEngine.SerializeField]
    private Win_LicensedChallenge.HighlightTween manCityHighlight;
    [global::UnityEngine.SerializeField]
    private Win_LicensedChallenge.HighlightTween monacoHighlight;
    public override void OnOpen(object parameter)
    {
    }

    private void OnPlayClick()
    {
    }

    private void PlaySelectTween(global::UnityEngine.Transform target)
    {
    }

    private void PlayDeselectTween(global::UnityEngine.Transform target)
    {
    }
}
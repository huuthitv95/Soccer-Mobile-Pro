public class GUIPlayerCareerNextBtn : global::UnityEngine.MonoBehaviour
{
    public enum NextBtnType
    {
        NextMatch = 0,
        Suspension = 1,
        Transfer = 2
    }

    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject[] nextMatchObjs;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject[] suspensionObjs;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject[] transferObjs;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject[] hideOnTransfer;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image coachTrustIcon;
    public void SetNextBtnType(GUIPlayerCareerNextBtn.NextBtnType type, CoachTrustTier trustTier)
    {
    }
}
public class AlternativeAdBoard : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::Gadsme.GadsmePlacement[] ad_groupA;
    [global::UnityEngine.SerializeField]
    private global::Gadsme.GadsmePlacement[] ad_groupB;
    private global::UnityEngine.GameObject alternativeAdBoardPrefabA;
    private global::UnityEngine.GameObject alternativeAdBoardPrefabB;
    private global::UnityEngine.GameObject[] alternativeAdBoardA;
    private global::UnityEngine.GameObject[] alternativeAdBoardB;
    private bool useAlternativeAdBoardA;
    private bool useAlternativeAdBoardB;
    private UvOffsetAnimator uvOffsetAnimatorA;
    private UvOffsetAnimator uvOffsetAnimatorB;
    private UvOffsetAnimator otherAnimator;
    private float timer;
    public void LoadPrefabForMatch(CupMatchBase match)
    {
    }

    private void Update()
    {
    }

    private void Check()
    {
    }

    private void Check(global::UnityEngine.GameObject[] gameObjects, global::Gadsme.GadsmePlacement[] placements, ref bool state)
    {
    }
}
public class HoldCupIKConfigGenerator : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    public HoldCupIKConfigs configs;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform leftHand;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform rightHand;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform cup;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform Template;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform templateLeftHand;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform templateRightHand;
    private void GetFingerTransform(global::UnityEngine.Transform hand, FingerIKConfigs rightFinger)
    {
    }

    private bool CheckFingerConfig()
    {
        return false;
    }

    public void ResetBones()
    {
    }
}
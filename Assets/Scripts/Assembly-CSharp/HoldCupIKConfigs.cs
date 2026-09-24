[global::UnityEngine.CreateAssetMenu]
public class HoldCupIKConfigs : global::UnityEngine.ScriptableObject
{
	public global::System.Collections.Generic.List<string> CupNames;

	public global::System.Collections.Generic.List<global::UnityEngine.Vector3> cupLocalPos;

	public global::System.Collections.Generic.List<global::UnityEngine.Quaternion> cupLocalRotation;

	public global::System.Collections.Generic.List<global::UnityEngine.Vector3> cupLocalScale;

	public global::System.Collections.Generic.List<global::UnityEngine.Vector3> LeftHandIKPos;

	public global::System.Collections.Generic.List<global::UnityEngine.Quaternion> LeftHandIKRotation;

	public global::System.Collections.Generic.List<global::UnityEngine.Vector3> RightHandIKPos;

	public global::System.Collections.Generic.List<global::UnityEngine.Quaternion> RightHandIKRotation;

	public global::System.Collections.Generic.List<FingerIKConfigs> rightFinger;

	public global::System.Collections.Generic.List<FingerIKConfigs> leftFinger;
}

namespace Common
{
    public class PlayerBoneHolder : global::UnityEngine.MonoBehaviour
    {
        public global::UnityEngine.Transform[] body;
        [global::System.NonSerialized]
        public global::UnityEngine.Transform selectedMark2;
        [global::System.NonSerialized]
        public global::UnityEngine.Transform selectedMark;
        [global::System.NonSerialized]
        public global::UnityEngine.Transform heroMark;
        [global::System.NonSerialized]
        public global::UnityEngine.Transform heroName;
        [global::System.NonSerialized]
        public global::UnityEngine.Transform offsideMark;
        [global::System.NonSerialized]
        public global::UnityEngine.Transform buffStrengthen;
        [global::System.NonSerialized]
        public global::UnityEngine.Transform buffAutoShoot;
        [global::System.NonSerialized]
        public global::UnityEngine.Transform effectStrengthen;
        [global::System.NonSerialized]
        public global::UnityEngine.Transform effectAutoShoot;
        [global::System.NonSerialized]
        public global::UnityEngine.Transform heroHaloYellow;
        [global::System.NonSerialized]
        public global::UnityEngine.Transform heroHaloPurple;
        [global::System.NonSerialized]
        public global::UnityEngine.Transform shadowNight;
        private global::UnityEngine.Vector3[] TposPositions;
        private global::UnityEngine.Quaternion[] TposRotations;
        private global::UnityEngine.Quaternion[] TposInverselocalRotations;
        private bool animating;
        private global::Common.VelocityCalculator leftFootVelocityCalculator;
        private global::Common.VelocityCalculator rightFootVelocityCalculator;
        private global::UnityEngine.Quaternion bodyTposInverseRotation;
        private global::System.Collections.Generic.Dictionary<string, global::UnityEngine.Transform> skinBoneNodes;
        public global::UnityEngine.Vector3 LeftFootVelocity => default;
        public global::UnityEngine.Vector3 RightFootVelocity => default;
        public global::UnityEngine.Vector3 Forward => default;

        public void UpdateFootVelocity(float deltaTime)
        {
        }

        private void Awake()
        {
        }

        private void Update()
        {
        }

        public void ApplyPositionOffset(global::System.Collections.Generic.List<global::UnityEngine.Vector3> positionOffset, float t)
        {
        }

        public void ApplyRotationOffset(global::System.Collections.Generic.List<global::UnityEngine.Quaternion> quaternions, float t)
        {
        }

        public void ApplyPositionOffset(global::UnityEngine.Vector3 positionOffset, float t)
        {
        }

        public void ApplyRotationOffset(int bone, global::UnityEngine.Quaternion quaternion)
        {
        }

        public void ApplyRotationOffset(int bone, global::UnityEngine.Quaternion quaternion, float t)
        {
        }

        public void ApplyPositionOffset(global::UnityEngine.Vector3 positionOffsetPre, global::UnityEngine.Vector3 positionOffset, float t)
        {
        }

        public void ApplyRotationOffset(int bone, global::UnityEngine.Quaternion quaternionPre, global::UnityEngine.Quaternion quaternion, float t)
        {
        }

        public void TransferBodyRotationToPlayer(bool reviseRotationY = false)
        {
        }

        public void EnsureOnTheGround()
        {
        }

        public global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::UnityEngine.Vector3, global::UnityEngine.Quaternion>> CloneBoneTransform(bool reviseRotationY = false)
        {
            return null;
        }

        public static global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::UnityEngine.Vector3, global::UnityEngine.Quaternion>> CloneBoneTransform(global::UnityEngine.Transform root, bool reviseRotationY = false)
        {
            return null;
        }

        public global::UnityEngine.Transform GetSkinBoneNode(string boneName, global::System.Collections.Generic.IEnumerable<string> boneNames)
        {
            return null;
        }
    }
}
namespace Common
{
    public static class Extentions
    {
        public static global::UnityEngine.Vector3 ToUnityVector(this global::UnityEngine.Vector3 footBallVec)
        {
            return default;
        }

        public static global::UnityEngine.Vector3 ToEngineVector(this global::UnityEngine.Vector3 unityVector)
        {
            return default;
        }

        public static global::UnityEngine.Vector3 ToXZVector(this global::UnityEngine.Vector3 vec)
        {
            return default;
        }

        public static global::UnityEngine.Quaternion ToUnityQuaternion(this global::UnityEngine.Quaternion footBallQuaternion)
        {
            return default;
        }

        public static global::UnityEngine.Quaternion ToEngineQuaternion(this global::UnityEngine.Quaternion unityQuaternion)
        {
            return default;
        }

        public static bool FindNodesByName(this global::UnityEngine.Transform node, global::System.Collections.Generic.Dictionary<string, global::UnityEngine.Transform> dictName2Node, ref int remainingCount)
        {
            return false;
        }

        public static global::UnityEngine.Transform FindInChildren(this global::UnityEngine.Transform transform, string name)
        {
            return null;
        }

        public static global::UnityEngine.Transform FindChildRecursive(this global::UnityEngine.Transform parent, string childName, bool ignoreCase = false)
        {
            return null;
        }

        public static global::UnityEngine.Transform FindChildRecursive(this global::UnityEngine.Transform parent, global::System.Predicate<global::UnityEngine.Transform> predicate)
        {
            return null;
        }

        public static global::System.Collections.Generic.List<global::UnityEngine.Transform> GetChilds(this global::UnityEngine.Transform t, global::System.Predicate<global::UnityEngine.Transform> predicate = null)
        {
            return null;
        }

        public static global::UnityEngine.Transform GetChild(this global::UnityEngine.Transform t, global::System.Predicate<global::UnityEngine.Transform> predicate)
        {
            return null;
        }

        public static void HideChilds(this global::UnityEngine.Transform t)
        {
        }

        public static void HideChilds(this global::UnityEngine.Transform t, int skipFirstN)
        {
        }

        public static void SetLayer(this global::UnityEngine.Transform t, int layer)
        {
        }

        public static T RandomGet<T>(this global::System.Collections.Generic.List<T> list)
        {
            return default;
        }

        public static T RandomGet<T>(this global::System.Collections.Generic.List<T> list, global::System.Random RandomCreator)
        {
            return default;
        }

        public static T AddComponentNotExist<T>(this global::UnityEngine.GameObject obj)
            where T : global::UnityEngine.Component
        {
            return null;
        }

        public static bool CheckAddComponentExist<T>(this global::UnityEngine.GameObject obj)
            where T : global::UnityEngine.Component
        {
            return false;
        }

        public static global::UnityEngine.Vector3? ToVector3(this string vecStr, string spliter = ",")
        {
            return null;
        }

        public static global::System.Collections.Generic.List<T> Shuffle<T>(this global::System.Collections.Generic.List<T> list)
        {
            return null;
        }

        public static global::System.Collections.Generic.List<T> ShuffleInPlace<T>(this global::System.Collections.Generic.List<T> list)
        {
            return null;
        }

        public static void ShuffleByParity<T>(this global::System.Collections.Generic.List<T> list)
        {
        }

        public static void ShuffleByParityRange<T>(this global::System.Collections.Generic.List<T> list, int start, int count)
        {
        }

        public static global::UnityEngine.Rect Rotation(this global::UnityEngine.Rect rect, global::Common.RectRotation rotation)
        {
            return default;
        }

        public static void CopyLocalTransform(this global::UnityEngine.Transform source, global::UnityEngine.Transform destination)
        {
        }

        public static void ResetLocalTransform(this global::UnityEngine.Transform t)
        {
        }

        public static void DepthFirstTraversal(this global::UnityEngine.Transform t, global::System.Action<global::UnityEngine.Transform> action)
        {
        }
    }
}
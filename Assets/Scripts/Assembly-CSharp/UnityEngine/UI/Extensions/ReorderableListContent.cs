namespace UnityEngine.UI.Extensions
{
    public class ReorderableListContent : global::UnityEngine.MonoBehaviour
    {
        private global::System.Collections.Generic.List<global::UnityEngine.Transform> _cachedChildren;
        private global::System.Collections.Generic.List<global::UnityEngine.UI.Extensions.ReorderableListElement> _cachedListElement;
        private global::UnityEngine.UI.Extensions.ReorderableListElement _ele;
        private global::UnityEngine.UI.Extensions.ReorderableList _extList;
        private global::UnityEngine.RectTransform _rect;
        private void OnEnable()
        {
        }

        public void OnTransformChildrenChanged()
        {
        }

        public void Init(global::UnityEngine.UI.Extensions.ReorderableList extList)
        {
        }

        private global::System.Collections.IEnumerator RefreshChildren()
        {
            return null;
        }
    }
}
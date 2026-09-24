namespace UnityEngine.UI.Extensions
{
    public class SelectionBox : global::UnityEngine.MonoBehaviour
    {
        public class SelectionEvent : global::UnityEngine.Events.UnityEvent<global::UnityEngine.UI.Extensions.IBoxSelectable[]>
        {
        }

        public global::UnityEngine.Color color;
        public global::UnityEngine.Sprite art;
        private global::UnityEngine.Vector2 origin;
        public global::UnityEngine.RectTransform selectionMask;
        private global::UnityEngine.RectTransform boxRect;
        private global::UnityEngine.UI.Extensions.IBoxSelectable[] selectables;
        private global::UnityEngine.MonoBehaviour[] selectableGroup;
        private global::UnityEngine.UI.Extensions.IBoxSelectable clickedBeforeDrag;
        private global::UnityEngine.UI.Extensions.IBoxSelectable clickedAfterDrag;
        public global::UnityEngine.UI.Extensions.SelectionBox.SelectionEvent onSelectionChange;
        private void ValidateCanvas()
        {
        }

        private void SetSelectableGroup(global::System.Collections.Generic.IEnumerable<global::UnityEngine.MonoBehaviour> behaviourCollection)
        {
        }

        private void CreateBoxRect()
        {
        }

        private void ResetBoxRect()
        {
        }

        private void BeginSelection()
        {
        }

        private bool PointIsValidAgainstSelectionMask(global::UnityEngine.Vector2 screenPoint)
        {
            return false;
        }

        private global::UnityEngine.UI.Extensions.IBoxSelectable GetSelectableAtMousePosition()
        {
            return null;
        }

        private void DragSelection()
        {
        }

        private void ApplySingleClickDeselection()
        {
        }

        private void ApplyPreSelections()
        {
        }

        private global::UnityEngine.Vector2 GetScreenPointOfSelectable(global::UnityEngine.UI.Extensions.IBoxSelectable selectable)
        {
            return default;
        }

        private global::UnityEngine.Camera GetScreenPointCamera(global::UnityEngine.RectTransform rectTransform)
        {
            return null;
        }

        public global::UnityEngine.UI.Extensions.IBoxSelectable[] GetAllSelected()
        {
            return null;
        }

        private void EndSelection()
        {
        }

        private void Start()
        {
        }

        private void Update()
        {
        }
    }
}
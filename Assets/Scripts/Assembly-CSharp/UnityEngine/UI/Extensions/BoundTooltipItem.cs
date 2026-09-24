namespace UnityEngine.UI.Extensions
{
    public class BoundTooltipItem : global::UnityEngine.MonoBehaviour
    {
        public global::UnityEngine.UI.Text TooltipText;
        public global::UnityEngine.Vector3 ToolTipOffset;
        private static global::UnityEngine.UI.Extensions.BoundTooltipItem instance;
        public bool IsActive => false;
        public static global::UnityEngine.UI.Extensions.BoundTooltipItem Instance => null;

        private void Awake()
        {
        }

        public void ShowTooltip(string text, global::UnityEngine.Vector3 pos)
        {
        }

        public void HideTooltip()
        {
        }
    }
}
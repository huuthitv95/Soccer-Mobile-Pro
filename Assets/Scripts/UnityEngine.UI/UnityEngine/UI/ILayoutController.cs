// Restored from Unity 2020.3.49f1 bundled uGUI. See RecoveryProvenance.md.
using UnityEngine;
using System.Collections;

namespace UnityEngine.UI
{

    /// <summary>
    /// Base interface to be implemented by components that control the layout of RectTransforms.
    /// </summary>
    /// <remarks>
    /// If a component is driving its own RectTransform it should implement the interface [[ILayoutSelfController]].
    /// If a component is driving the RectTransforms of its children, it should implement [[ILayoutGroup]].
    ///
    /// The layout system will first invoke SetLayoutHorizontal and then SetLayoutVertical.
    ///
    /// In the SetLayoutHorizontal call it is valid to call LayoutUtility.GetMinWidth, LayoutUtility.GetPreferredWidth, and LayoutUtility.GetFlexibleWidth on the RectTransform of itself or any of its children.
    /// In the SetLayoutVertical call it is valid to call LayoutUtility.GetMinHeight, LayoutUtility.GetPreferredHeight, and LayoutUtility.GetFlexibleHeight on the RectTransform of itself or any of its children.
    ///
    /// The component may use this information to determine the width and height to use for its own RectTransform or the RectTransforms of its children.
    /// </remarks>
    public interface ILayoutController
    {
        /// <summary>
        /// Callback invoked by the auto layout system which handles horizontal aspects of the layout.
        /// </summary>
        void SetLayoutHorizontal();

        /// <summary>
        /// Callback invoked by the auto layout system which handles vertical aspects of the layout.
        /// </summary>
        void SetLayoutVertical();
    }
}

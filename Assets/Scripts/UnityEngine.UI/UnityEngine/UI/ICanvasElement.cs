// Restored from Unity 2020.3.49f1 bundled uGUI. See RecoveryProvenance.md.
using System;
using System.Collections.Generic;
using UnityEngine.UI.Collections;

namespace UnityEngine.UI
{

    /// <summary>
    /// This is an element that can live on a Canvas.
    /// </summary>
    public interface ICanvasElement
    {
        /// <summary>
        /// Rebuild the element for the given stage.
        /// </summary>
        /// <param name="executing">The current CanvasUpdate stage being rebuild.</param>
        void Rebuild(CanvasUpdate executing);

        /// <summary>
        /// Get the transform associated with the ICanvasElement.
        /// </summary>
        Transform transform { get; }

        /// <summary>
        /// Callback sent when this ICanvasElement has completed layout.
        /// </summary>
        void LayoutComplete();

        /// <summary>
        /// Callback sent when this ICanvasElement has completed Graphic rebuild.
        /// </summary>
        void GraphicUpdateComplete();

        /// <summary>
        /// Used if the native representation has been destroyed.
        /// </summary>
        /// <returns>Return true if the element is considered destroyed.</returns>
        bool IsDestroyed();
    }
}

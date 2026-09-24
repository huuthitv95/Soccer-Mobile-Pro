// Restored from Unity 2020.3.49f1 bundled uGUI. See RecoveryProvenance.md.
namespace UnityEngine.UI
{

    /// <summary>
    /// Interface for elements that can be clipped if they are under an IClipper
    /// </summary>
    public interface IClippable
    {
        /// <summary>
        /// GameObject of the IClippable object
        /// </summary>
        GameObject gameObject { get; }

        /// <summary>
        /// Will be called when the state of a parent IClippable changed.
        /// </summary>
        void RecalculateClipping();

        /// <summary>
        /// The RectTransform of the clippable.
        /// </summary>
        RectTransform rectTransform { get; }

        /// <summary>
        /// Clip and cull the IClippable given a specific clipping rect
        /// </summary>
        /// <param name="clipRect">The Rectangle in which to clip against.</param>
        /// <param name="validRect">Is the Rect valid. If not then the rect has 0 size.</param>
        void Cull(Rect clipRect, bool validRect);

        /// <summary>
        /// Set the clip rect for the IClippable.
        /// </summary>
        /// <param name="value">The Rectangle for the clipping</param>
        /// <param name="validRect">Is the rect valid.</param>
        void SetClipRect(Rect value, bool validRect);

        /// <summary>
        /// Set the clip softness for the IClippable.
        ///
        /// The softness is a linear alpha falloff over clipSoftness pixels.
        /// </summary>
        /// <param name="clipSoftness">The number of pixels to apply the softness to </param>
        void SetClipSoftness(Vector2 clipSoftness);
    }
}

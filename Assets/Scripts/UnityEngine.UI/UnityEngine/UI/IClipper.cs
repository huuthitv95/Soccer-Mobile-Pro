// Restored from Unity 2020.3.49f1 bundled uGUI. See RecoveryProvenance.md.
namespace UnityEngine.UI
{
    /// <summary>
    /// Interface that can be used to recieve clipping callbacks as part of the canvas update loop.
    /// </summary>
    public interface IClipper
    {
        /// <summary>
        /// Function to to cull / clip children elements.
        /// </summary>
        /// <remarks>
        /// Called after layout and before Graphic update of the Canvas update loop.
        /// </remarks>

        void PerformClipping();
    }
}

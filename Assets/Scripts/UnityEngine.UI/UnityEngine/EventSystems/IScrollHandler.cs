// Restored from Unity 2020.3.49f1 bundled uGUI. See RecoveryProvenance.md.
namespace UnityEngine.EventSystems
{

    /// <summary>
    /// Interface to implement if you wish to receive OnScroll callbacks.
    /// </summary>
    /// <remarks>
    /// Criteria for this event is implementation dependent. For example see StandAloneInputModule.
    /// </remarks>
    public interface IScrollHandler : IEventSystemHandler
    {
        /// <summary>
        /// Use this callback to detect scroll events.
        /// </summary>
        void OnScroll(PointerEventData eventData);
    }
}

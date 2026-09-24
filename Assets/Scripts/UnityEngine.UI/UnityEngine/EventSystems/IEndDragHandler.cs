// Restored from Unity 2020.3.49f1 bundled uGUI. See RecoveryProvenance.md.
namespace UnityEngine.EventSystems
{

    /// <summary>
    /// Interface to implement if you wish to receive OnEndDrag callbacks.
    /// Note: You need to implement IDragHandler in addition to IEndDragHandler.
    /// </summary>
    /// <remarks>
    /// Criteria for this event is implementation dependent. For example see StandAloneInputModule.
    /// </remarks>
    public interface IEndDragHandler : IEventSystemHandler
    {
        /// <summary>
        /// Called by a BaseInputModule when a drag is ended.
        /// </summary>
        void OnEndDrag(PointerEventData eventData);
    }
}

// Restored from Unity 2020.3.49f1 bundled uGUI. See RecoveryProvenance.md.
namespace UnityEngine.EventSystems
{

    /// <summary>
    /// Interface to implement if you wish to receive OnInitializePotentialDrag callbacks.
    /// </summary>
    /// <remarks>
    /// Criteria for this event is implementation dependent. For example see StandAloneInputModule.
    /// </remarks>
    public interface IInitializePotentialDragHandler : IEventSystemHandler
    {
        /// <summary>
        /// Called by a BaseInputModule when a drag has been found but before it is valid to begin the drag.
        /// </summary>
        void OnInitializePotentialDrag(PointerEventData eventData);
    }
}

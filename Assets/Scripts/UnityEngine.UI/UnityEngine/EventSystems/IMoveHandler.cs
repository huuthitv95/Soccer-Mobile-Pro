// Restored from Unity 2020.3.49f1 bundled uGUI. See RecoveryProvenance.md.
namespace UnityEngine.EventSystems
{

    /// <summary>
    /// Interface to implement if you wish to receive OnMove callbacks.
    /// </summary>
    /// <remarks>
    /// Criteria for this event is implementation dependent. For example see StandAloneInputModule.
    /// </remarks>
    public interface IMoveHandler : IEventSystemHandler
    {
        /// <summary>
        /// Called by a BaseInputModule when a move event occurs.
        /// </summary>
        void OnMove(AxisEventData eventData);
    }
}

// Restored from Unity 2020.3.49f1 bundled uGUI. See RecoveryProvenance.md.
namespace UnityEngine.EventSystems
{

    /// <summary>
    /// Interface to implement if you wish to receive OnUpdateSelected callbacks.
    /// </summary>
    /// <remarks>
    /// Criteria for this event is implementation dependent. For example see StandAloneInputModule.
    /// </remarks>
    public interface IUpdateSelectedHandler : IEventSystemHandler
    {
        /// <summary>
        /// Called by the EventSystem when the object associated with this EventTrigger is updated.
        /// </summary>
        /// <example>
        /// <code>
        /// using UnityEngine;
        /// using UnityEngine.EventSystems;
        ///
        /// public class UpdateSelectedExample : MonoBehaviour, IUpdateSelectedHandler
        /// {
        ///     public void OnUpdateSelected(BaseEventData data)
        ///     {
        ///         Debug.Log("OnUpdateSelected called.");
        ///     }
        /// }
        /// </code>
        /// </example>
        void OnUpdateSelected(BaseEventData eventData);
    }
}

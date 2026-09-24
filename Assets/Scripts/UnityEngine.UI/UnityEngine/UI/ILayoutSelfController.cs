// Restored from Unity 2020.3.49f1 bundled uGUI. See RecoveryProvenance.md.
using UnityEngine;
using System.Collections;

namespace UnityEngine.UI
{

    /// <summary>
    /// ILayoutSelfController is an ILayoutController that should drive its own RectTransform.
    /// </summary>
    /// <remarks>
    /// The iLayoutSelfController derives from the base controller [[ILayoutController]] and controls the layout of a RectTransform.
    ///
    /// Use the ILayoutSelfController to manipulate a GameObject’s own RectTransform component, which you attach in the Inspector.Use ILayoutGroup to manipulate RectTransforms belonging to the children of the GameObject.
    ///
    /// Call ILayoutController.SetLayoutHorizontal to handle horizontal parts of the layout, and call ILayoutController.SetLayoutVertical to handle vertical parts.
    /// You can change the height, width, position and rotation of the RectTransform.
    /// </remarks>
    /// <example>
    /// <code>
    /// //This script shows how the GameObject’s own RectTransforms can be changed.
    /// //This creates a rectangle on the screen of the scale, positition and rotation you define in the Inspector.
    /// //Make sure to set the X and Y scale to be more than 0 to see it
    ///
    /// using UnityEngine;
    /// using UnityEngine.UI;
    /// using UnityEngine.EventSystems;
    ///
    /// public class Example : UIBehaviour, ILayoutSelfController
    /// {
    ///     //Fields in the inspector used to manipulate the RectTransform
    ///     public Vector3 m_Position;
    ///     public Vector3 m_Rotation;
    ///     public Vector2 m_Scale;
    ///
    ///     //This handles horizontal aspects of the layout (derived from ILayoutController)
    ///     public virtual void SetLayoutHorizontal()
    ///     {
    ///         //Move and Rotate the RectTransform appropriately
    ///         UpdateRectTransform();
    ///     }
    ///
    ///     //This handles vertical aspects of the layout
    ///     public virtual void SetLayoutVertical()
    ///     {
    ///         //Move and Rotate the RectTransform appropriately
    ///         UpdateRectTransform();
    ///     }
    ///
    ///     //This tells when there is a change in the inspector
    ///     #if UNITY_EDITOR
    ///     protected override void OnValidate()
    ///     {
    ///         Debug.Log("Validate");
    ///         //Update the RectTransform position, rotation and scale
    ///         UpdateRectTransform();
    ///     }
    ///
    ///     #endif
    ///
    ///     //This tells when there has been a change to the RectTransform's settings in the inspector
    ///     protected override void OnRectTransformDimensionsChange()
    ///     {
    ///         //Update the RectTransform position, rotation and scale
    ///         UpdateRectTransform();
    ///     }
    ///
    ///     void UpdateRectTransform()
    ///     {
    ///         //Fetch the RectTransform from the GameObject
    ///         RectTransform rectTransform = GetComponent<RectTransform>();
    ///
    ///         //Change the scale of the RectTransform using the fields in the inspector
    ///         rectTransform.localScale = new Vector3(m_Scale.x, m_Scale.y, 0);
    ///
    ///         //Change the position and rotation of the RectTransform
    ///         rectTransform.SetPositionAndRotation(m_Position, Quaternion.Euler(m_Rotation));
    ///     }
    /// }
    /// </code>
    /// </example>
    public interface ILayoutSelfController : ILayoutController
    {
    }
}

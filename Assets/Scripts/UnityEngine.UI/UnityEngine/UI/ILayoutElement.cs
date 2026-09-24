// Restored from Unity 2020.3.49f1 bundled uGUI. See RecoveryProvenance.md.
using UnityEngine;
using System.Collections;

namespace UnityEngine.UI
{
    /// <summary>
    ///   A component is treated as a layout element by the auto layout system if it implements ILayoutElement.
    /// </summary>
    /// <remarks>
    /// The layout system will invoke CalculateLayoutInputHorizontal before querying minWidth, preferredWidth, and flexibleWidth. It can potentially save performance if these properties are cached when CalculateLayoutInputHorizontal is invoked, so they don't need to be recalculated every time the properties are queried.
    ///
    /// The layout system will invoke CalculateLayoutInputVertical before querying minHeight, preferredHeight, and flexibleHeight.It can potentially save performance if these properties are cached when CalculateLayoutInputVertical is invoked, so they don't need to be recalculated every time the properties are queried.
    ///
    /// The minWidth, preferredWidth, and flexibleWidth properties should not rely on any properties of the RectTransform of the layout element, otherwise the behavior will be non-deterministic.
    /// The minHeight, preferredHeight, and flexibleHeight properties may rely on horizontal aspects of the RectTransform, such as the width or the X component of the position.
    /// Any properties of the RectTransforms on child layout elements may always be relied on.
    /// </remarks>
    public interface ILayoutElement
    {
        /// <summary>
        /// After this method is invoked, layout horizontal input properties should return up-to-date values.
        ///  Children will already have up-to-date layout horizontal inputs when this methods is called.
        /// </summary>
        void CalculateLayoutInputHorizontal();

        /// <summary>
        ///After this method is invoked, layout vertical input properties should return up-to-date values.
        ///Children will already have up-to-date layout vertical inputs when this methods is called.
        /// </summary>
        void CalculateLayoutInputVertical();

        /// <summary>
        /// The minimum width this layout element may be allocated.
        /// </summary>
        float minWidth { get; }

        /// <summary>
        /// The preferred width this layout element should be allocated if there is sufficient space.
        /// </summary>
        /// <remarks>
        /// PreferredWidth can be set to -1 to remove the size.
        /// </remarks>
        float preferredWidth { get; }

        /// <summary>
        /// The extra relative width this layout element should be allocated if there is additional available space.
        /// </summary>
        /// <remarks>
        /// Setting preferredWidth to -1 removed the preferredWidth.
        /// </remarks>
        /// <example>
        ///<code>
        ///using UnityEngine;
        ///using System.Collections;
        ///using UnityEngine.UI; // Required when using UI elements.
        ///
        ///public class ExampleClass : MonoBehaviour
        ///{
        ///    public Transform MyContentPanel;
        ///
        ///    //Sets the flexible height on on all children in the content panel.
        ///    public void Start()
        ///    {
        ///        //Assign all the children of the content panel to an array.
        ///        LayoutElement[] myLayoutElements = MyContentPanel.GetComponentsInChildren<LayoutElement>();
        ///
        ///        //For each child in the array change its LayoutElement's flexible width to 200.
        ///        foreach (LayoutElement element in myLayoutElements)
        ///        {
        ///            element.flexibleWidth = 200f;
        ///        }
        ///    }
        ///}
        ///</code>
        ///</example>

        float flexibleWidth { get; }

        /// <summary>
        /// The minimum height this layout element may be allocated.
        /// </summary>
        float minHeight { get; }

        /// <summary>
        /// The preferred height this layout element should be allocated if there is sufficient space.
        /// </summary>
        /// <remarks>
        /// PreferredHeight can be set to -1 to remove the size.
        /// </remarks>
        float preferredHeight { get; }

        /// <summary>
        /// The extra relative height this layout element should be allocated if there is additional available space.
        /// </summary>
        ///<example>
        ///<code>
        ///using UnityEngine;
        ///using System.Collections;
        ///using UnityEngine.UI; // Required when using UI elements.
        ///
        ///public class ExampleClass : MonoBehaviour
        ///{
        ///    public Transform MyContentPanel;
        ///
        ///    //Sets the flexible height on on all children in the content panel.
        ///    public void Start()
        ///    {
        ///        //Assign all the children of the content panel to an array.
        ///        LayoutElement[] myLayoutElements = MyContentPanel.GetComponentsInChildren<LayoutElement>();
        ///
        ///        //For each child in the array change its LayoutElement's flexible height to 100.
        ///        foreach (LayoutElement element in myLayoutElements)
        ///        {
        ///            element.flexibleHeight = 100f;
        ///        }
        ///    }
        ///}
        ///</code>
        ///</example>
        float flexibleHeight { get; }

        /// <summary>
        /// The layout priority of this component.
        /// </summary>
        /// <remarks>
        /// If multiple components on the same GameObject implement the ILayoutElement interface, the values provided by components that return a higher priority value are given priority. However, values less than zero are ignored. This way a component can override only select properties by leaving the remaning values to be -1 or other values less than zero.
        /// </remarks>
        int layoutPriority { get; }
    }
}

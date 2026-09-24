// Restored from Unity 2020.3.49f1 bundled uGUI. See RecoveryProvenance.md.
using UnityEngine;
using System.Collections;

namespace UnityEngine.UI
{

    /// <summary>
    /// A RectTransform will be ignored by the layout system if it has a component which implements ILayoutIgnorer.
    /// </summary>
    /// <remarks>
    /// A components that implements ILayoutIgnorer can be used to make a parent layout group component not consider this RectTransform part of the group. The RectTransform can then be manually positioned despite being a child GameObject of a layout group.
    /// </remarks>
    public interface ILayoutIgnorer
    {
        /// <summary>
        /// Should this RectTransform be ignored bvy the layout system?
        /// </summary>
        /// <remarks>
        /// Setting this property to true will make a parent layout group component not consider this RectTransform part of the group. The RectTransform can then be manually positioned despite being a child GameObject of a layout group.
        /// </remarks>
        bool ignoreLayout { get; }
    }
}

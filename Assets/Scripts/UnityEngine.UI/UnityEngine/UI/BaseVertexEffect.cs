// Restored from Unity 2020.3.49f1 bundled uGUI. See RecoveryProvenance.md.
using System;
using System.Collections.Generic;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
    [Obsolete("Use BaseMeshEffect instead", true)]
    /// <summary>
    /// Obsolete class use BaseMeshEffect instead.
    /// </summary>
    public abstract class BaseVertexEffect
    {
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        [Obsolete("Use BaseMeshEffect.ModifyMeshes instead", true)] //We can't upgrade automatically since the signature changed.
        public abstract void ModifyVertices(List<UIVertex> vertices);
    }

#if UNITY_EDITOR
#endif
}

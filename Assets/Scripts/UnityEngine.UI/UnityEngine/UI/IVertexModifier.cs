// Restored from Unity 2020.3.49f1 bundled uGUI. See RecoveryProvenance.md.
using System;
using System.Collections.Generic;

namespace UnityEngine.UI
{
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    [Obsolete("Use IMeshModifier instead", true)]
    public interface IVertexModifier
    {
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        [Obsolete("use IMeshModifier.ModifyMesh (VertexHelper verts)  instead", true)]
        void ModifyVertices(List<UIVertex> verts);
    }
}

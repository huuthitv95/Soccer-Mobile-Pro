public class RectTransformSizeGroup : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::System.Collections.Generic.List<RectTransformSnapshot> _snapshots;
    public int SnapshotCount => 0;

    public RectTransformSnapshot GetSnapshot(int index)
    {
        return null;
    }

    public void ApplySnapshot(int index)
    {
    }

    public void ApplySnapshot(bool isSelected)
    {
    }

    public void ApplySnapshot(int index, bool applyPosition = true, bool applySize = true, bool applyAnchors = true, bool applyPivot = true, bool applyScale = false, bool applyRotation = false)
    {
    }

    public void CaptureSnapshot(int index)
    {
    }

    public RectTransformSnapshot CaptureFromCurrent(string snapshotName = null)
    {
        return null;
    }

    public void RemoveSnapshot(int index)
    {
    }

    public RectTransformEntry GetEntry(int snapshotIndex, int entryIndex)
    {
        return null;
    }

    public void CopyEntryFrom(int snapshotIndex, int entryIndex, global::UnityEngine.RectTransform source)
    {
    }

    public void PasteEntryTo(int snapshotIndex, int entryIndex, global::UnityEngine.RectTransform target)
    {
    }

    public void SyncEntriesFromTargets(global::System.Collections.Generic.List<global::UnityEngine.RectTransform> targets)
    {
    }

    private void CaptureAllSnapshots()
    {
    }

    private void ApplySnapshot0()
    {
    }
}
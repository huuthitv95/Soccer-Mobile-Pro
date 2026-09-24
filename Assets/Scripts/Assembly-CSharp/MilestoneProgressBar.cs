public class MilestoneProgressBar : global::UnityEngine.MonoBehaviour
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform milestonesContainer;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform milestoneProto;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image progressBar;
    [global::UnityEngine.SerializeField]
    private float milestoneMinSpacing;
    [global::UnityEngine.SerializeField]
    private bool useUniformMilestoneSpacing;
    [global::UnityEngine.SerializeField]
    private float leftPadding;
    [global::UnityEngine.SerializeField]
    private float rightPadding;
    private readonly global::System.Collections.Generic.List<global::UnityEngine.Transform> milestoneItems;
    private readonly global::System.Collections.Generic.List<float> milestonePositions;
    private int total;
    private int[] milestoneValues;
    private float currentProgress;
    public global::System.Collections.Generic.IReadOnlyList<global::UnityEngine.Transform> MilestoneItems => null;

    public void Init(int total, int[] milestones)
    {
    }

    public void SetProgress(float progress)
    {
    }

    private void ClearMilestones()
    {
    }

    private void LayoutMilestones()
    {
    }

    private void ApplyProgress()
    {
    }

    private float MapProgressToFillAmount(float progress)
    {
        return 0f;
    }

    private int[] CreateMilestoneOrder()
    {
        return null;
    }

    private float[] BuildMilestonePositions(int[] order)
    {
        return null;
    }

    private float GetMilestoneLayoutProgress(int index, int rank, int count)
    {
        return 0f;
    }

    private float GetLayoutWidth()
    {
        return 0f;
    }

    private void OnRectTransformDimensionsChange()
    {
    }
}
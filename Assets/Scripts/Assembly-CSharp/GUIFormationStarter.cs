public class GUIFormationStarter : GUIFormationItem
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform bound;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.RectTransform filed;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image playerKit;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.GameObject posTip;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform posName;
    public override void UpdateRevisedFormationUI()
    {
    }

    protected override void OnInitialize()
    {
    }

    protected global::UnityEngine.Vector2 getPostion(bool IsRevised)
    {
        return default;
    }

    public override void OnSelect(bool select)
    {
    }

    public override void UpdateOriginalFormationUI()
    {
    }

    public override void OnCovered(bool covered, FormationTool.UIPosition position)
    {
    }

    private global::UnityEngine.Color CheckSkilledPosition(FormationTool.UIPosition position)
    {
        return default;
    }

    protected override bool CheckSwitchable()
    {
        return false;
    }
}
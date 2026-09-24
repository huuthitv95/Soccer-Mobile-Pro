[global::System.Serializable]
public struct GUIFormationThumbCore
{
    [global::UnityEngine.SerializeField]
    public global::UnityEngine.UI.Text name;
    [global::UnityEngine.SerializeField]
    public global::UnityEngine.Transform formationBG;
    [global::UnityEngine.SerializeField]
    public global::UnityEngine.Transform dotGroup;
    [global::UnityEngine.SerializeField]
    public global::UnityEngine.Transform currentFlag;
    [global::UnityEngine.SerializeField]
    public global::UnityEngine.UI.Button button;
    public global::SL.FormationTemplate data;
    private global::UnityEngine.Color bgColor;
    private global::UnityEngine.Color dotColor;
    [global::UnityEngine.SerializeField]
    private float[] offsets;
    [global::UnityEngine.SerializeField]
    private float[] lineTilts;
    [global::UnityEngine.SerializeField]
    private bool horizontal;
    [global::UnityEngine.SerializeField]
    private bool mirror;
    [global::UnityEngine.SerializeField]
    private bool mirrorAcrossGoalkeeperStrikerAxis;
    public void Init(global::UnityEngine.Transform root, global::SL.FormationTemplate data, global::UnityEngine.Events.UnityAction<global::SL.FormationTemplate> onClick, bool horizontal = false, bool mirror = false, bool mirrorAcrossGoalkeeperStrikerAxis = false)
    {
    }

    public void Updater(TeamsData team)
    {
    }

    public void Updater(int currentCode, bool updateCurrent = false)
    {
    }

    private static int FindLineIndex(global::System.Collections.Generic.List<float> linePositions, float position)
    {
        return 0;
    }
}
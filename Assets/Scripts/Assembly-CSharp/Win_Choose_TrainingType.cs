public class Win_Choose_TrainingType : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform list;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnClose;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button btnNext;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text TrainingName;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text Desc;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text progress;
    private int CurIndex;
    public override void OnOpen(object parameter)
    {
    }

    private global::UnityEngine.Sprite GetTrainingIcon(global::EngineMessages.TrainingConfig.Types.Type type)
    {
        return null;
    }

    private global::UnityEngine.Sprite GetSelectedTrainingIcon(global::EngineMessages.TrainingConfig.Types.Type type)
    {
        return null;
    }
}
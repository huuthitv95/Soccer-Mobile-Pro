public class GUIArchiveItemPlayerCareer : GUIArchiveItemStyleBase
{
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text playerNameText;
    [global::UnityEngine.SerializeField]
    private GUIPlayerType playerType;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform playerPos;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text timeText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image TeamIcon;
    [global::UnityEngine.SerializeField]
    private PlayerModelLoader playerModelLoader;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text playerAbilityText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Image namtionIcon;
    private void HandleOcclusion()
    {
    }

    public override void Fill(Win_Archives.ArchiveInfo info)
    {
    }

    private void ApplyPlayerModel(global::Srv.PlayerCareerThumbnail info, TeamsData team)
    {
    }
}
public class Win_WelcomeToNewClub : global::Common.WindowBase
{
    public class Parameter
    {
        public global::FL.PlayerCareer PlayerCareer;
        public string TextStringId;
    }

    [global::UnityEngine.SerializeField]
    private GUITeam guiTeam;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text welcomeText;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Button confirmButton;
    public override void OnOpen(object parameter)
    {
    }

    private void Fill(global::FL.PlayerCareer playerCareer, string textStringId)
    {
    }
}
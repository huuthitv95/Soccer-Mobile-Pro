namespace DreamClubSoccer
{
    public class CheatingTool : global::UnityEngine.MonoBehaviour
    {
        public global::UnityEngine.UI.Text versionInfo;
        public global::UnityEngine.UI.Button button0;
        public global::UnityEngine.UI.Button button1;
        public global::UnityEngine.UI.Text timeInfo;
        public global::UnityEngine.UI.Button language;
        public global::UnityEngine.GameObject[] debugButtons;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::UnityEngine.Events.UnityAction m_OnCheatingRefresh;
        private int[] cheatingSequence;
        private int times;
        private float lastClickTime;
        public global::UnityEngine.GameObject dumpSetting;
        public global::UnityEngine.GameObject saveSetting;
        public global::UnityEngine.GameObject loadSettingFromfile;
        public global::UnityEngine.UI.InputField inputSetting;
        private PlayerSetting.DumpType _currentDump;
        public global::UnityEngine.GameObject _abList;
        public global::UnityEngine.GameObject _abItem;
        public event global::UnityEngine.Events.UnityAction OnCheatingRefresh
        {
            [global::System.Runtime.CompilerServices.CompilerGenerated]
            add
            {
            }

            [global::System.Runtime.CompilerServices.CompilerGenerated]
            remove
            {
            }
        }

        private void Start()
        {
        }

        public static void ExportGameData()
        {
        }

        public void UploadGameData()
        {
        }

        public static global::System.Collections.IEnumerator UploadGameData(global::System.Action<bool, string> onCompleted, global::System.Collections.Generic.Dictionary<string, string> headers = null)
        {
            return null;
        }

        private void OnClick(int index)
        {
        }

        public void OpenGlobalConfig()
        {
        }

        public void MaxDebug()
        {
        }

        private void Refresh()
        {
        }

        public void DumpSetting()
        {
        }

        public void DumpABTest()
        {
        }

        public void DumpSyncData()
        {
        }

        public void CheatConsumeNoAdIap()
        {
        }

        private void Dump2Input(PlayerSetting.DumpType type)
        {
        }

        public void SaveSetting()
        {
        }

        private global::System.Collections.Generic.Dictionary<string, string> ComposeABInput()
        {
            return null;
        }

        public void LoadDumpFile()
        {
        }

        private global::System.Collections.IEnumerator RefreshTime()
        {
            return null;
        }

        public void clearSvae()
        {
        }

        public void ClearCMP()
        {
        }

        private void UpdateLanguage()
        {
        }

        public void refreshRemoteConfig()
        {
        }
    }
}
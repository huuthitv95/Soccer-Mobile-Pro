using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor.SceneManagement;
#endif
namespace Soccer.Recovery.Lobby
{
    [DefaultExecutionOrder(-900)]
    public sealed class LobbyRecoverySceneNavigator : MonoBehaviour, ILobbySceneNavigator
    {
        private bool requested;
        private void Awake() { LobbyRecoveryServices.Register(this); }
        public bool TryLoad(string path)
        {
            if (requested || path != LobbyRecoveryController.LobbyScenePath) return false;
            return Load(path);
        }
        public bool TryLoadStart() => requested ? false : Load("Assets/Recovery/Scenes/LobbyStart.unity");
        private bool Load(string path)
        {
            if (requested) return false;
            requested = true;
#if UNITY_EDITOR
            EditorSceneManager.LoadSceneAsyncInPlayMode(path, new LoadSceneParameters(LoadSceneMode.Single));
            return true;
#else
            return false;
#endif
        }
    }
}

// Recovery scene adapter; native load list is [Scenes/UI/Start, Scenes/UI/Launch].
// This editor adapter intentionally stops at isolated Start, replacing SceneHelper.
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor.SceneManagement;
#endif
namespace Soccer.Recovery.Boot
{
    [DefaultExecutionOrder(-900)]
    public sealed class OfflineBootSceneNavigator : MonoBehaviour, IBootSceneNavigator
    {
        public const string RecoveryStartScenePath = "Assets/Recovery/Scenes/BootStart.unity";
        private bool requested;
        private void Awake() => BootRecoveryServices.RegisterNavigator(this);
        private void OnDestroy() => BootRecoveryServices.UnregisterNavigator(this);
        public bool TryLoadRecoveryStart()
        {
            if (requested) return false;
            requested = true;
#if UNITY_EDITOR
            EditorSceneManager.LoadSceneAsyncInPlayMode(RecoveryStartScenePath, new LoadSceneParameters(LoadSceneMode.Single));
            return true;
#else
            return false; // Original Build Settings contain no recovery scenes.
#endif
        }
    }
}

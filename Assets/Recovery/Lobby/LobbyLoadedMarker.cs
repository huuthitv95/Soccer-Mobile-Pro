using UnityEngine;
namespace Soccer.Recovery.Lobby
{
    public sealed class LobbyLoadedMarker : MonoBehaviour
    {
        [SerializeField] private GameObject offlineConfigPrefab;
        public void SetOfflineConfigPrefab(GameObject prefab) { offlineConfigPrefab = prefab; }
        private void Awake() { LobbyRecoveryTrace.Record(LobbyRecoveryEvent.LobbyLoaded, gameObject.scene.path); }
        private void Start()
        {
            if (offlineConfigPrefab == null) return;
            var instance = Instantiate(offlineConfigPrefab);
            instance.name = "Win_GlobalConfig (recovery replacement)";
            instance.transform.SetParent(transform, false);
            instance.GetComponent<Soccer.Recovery.GlobalConfig.OfflineConfigWindow>().Initialize();
        }
    }
}

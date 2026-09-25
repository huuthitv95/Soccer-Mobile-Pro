using UnityEngine;

namespace Soccer.Recovery.Lobby
{
    [DefaultExecutionOrder(-1000)]
    public sealed class OfflineLobbyStartupAdapter : MonoBehaviour, ILobbyStartupServices
    {
        [SerializeField] private LobbyRecoveryProfile profile = new LobbyRecoveryProfile();
        public LobbyRecoveryProfile Profile => profile;
        private void Awake()
        {
            LobbyRecoveryServices.Reset();
            profile = LobbyRecoveryRunConfiguration.Consume(profile);
            LobbyRecoveryServices.Register(this);
            LobbyRecoveryTrace.Record(LobbyRecoveryEvent.SessionStarted, "profile=" + profile.Mode);
        }
        public LobbyReadiness Readiness(LobbyDependency dependency)
        {
            switch (dependency)
            {
                case LobbyDependency.ResourceManager: return profile.ResourceManager;
                case LobbyDependency.PressStart: return profile.PressStart;
                case LobbyDependency.NotchInitialized: return profile.NotchInitialized;
                case LobbyDependency.SaveCallback: return profile.SaveCallback;
                case LobbyDependency.NetworkProbe: return profile.NetworkProbe;
                case LobbyDependency.AbTest: return profile.AbTest;
                case LobbyDependency.CoreContent: return profile.CoreContent;
                default: return LobbyReadiness.Failed;
            }
        }
    }
}

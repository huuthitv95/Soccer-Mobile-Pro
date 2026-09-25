// Recovery-only in-memory profile. No original PlayerPrefs or save files are read/written.
namespace Soccer.Recovery.Boot
{
    public enum OfflineCloudSaveOutcome { Success, Failure, Pending }
    [System.Serializable]
    public sealed class BootRecoveryProfile
    {
        public bool NetworkProbePreviouslyRecorded;
        public bool SimulatedInternetReachable;
        public bool SaveRootReady = true;
        public OfflineCloudSaveOutcome Outcome = OfflineCloudSaveOutcome.Success;
        public int CallbackDelayFrames = 90;
        public int InitialError;
    }
    public static class BootRecoveryRunConfiguration
    {
        // Consumed once by the next recovery scene; never applied to game saves.
        public static BootRecoveryProfile NextProfile;
        public static BootRecoveryProfile Consume()
        {
            var profile = NextProfile ?? new BootRecoveryProfile();
            NextProfile = null;
            return profile;
        }
    }
}

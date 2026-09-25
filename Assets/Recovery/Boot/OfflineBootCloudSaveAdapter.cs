// Recovery-only service replacement. Inputs are synthetic, not real login/sync.
using System;
using System.Collections;
using UnityEngine;
namespace Soccer.Recovery.Boot
{
    [DefaultExecutionOrder(-1000)]
    public sealed class OfflineBootCloudSaveAdapter : MonoBehaviour, IBootCloudSaveAdapter
    {
        public BootRecoveryProfile Profile { get; private set; }
        public int BeginCount { get; private set; }
        private Action<bool> completed;
        private Action<float> progress;
        private bool cancelled;
        private void Awake()
        {
            BootRecoveryServices.Reset();
            Profile = BootRecoveryRunConfiguration.Consume();
            BootRecoveryServices.RegisterCloudSave(this);
        }
        private void OnDestroy()
        {
            Cancel();
            BootRecoveryServices.UnregisterCloudSave(this);
        }
        public IEnumerator CheckLoad(Action<bool> onCompleted, Action<float> onProgress)
        {
            BeginCount++;
            completed = onCompleted; progress = onProgress;
            BootRecoveryTrace.Record(BootRecoveryEvent.CloudSaveStarted);
            if (!cancelled) progress(0f);
            while (!cancelled && Profile.Outcome == OfflineCloudSaveOutcome.Pending) yield return null;
            for (var frame = 0; !cancelled && frame < Profile.CallbackDelayFrames; frame++) yield return null;
            if (!cancelled)
            {
                progress(100f);
                completed(Profile.Outcome == OfflineCloudSaveOutcome.Success);
            }
        }
        // Test seam: copies callbacks before cancellation to simulate an already queued callback.
        public Action<bool> CaptureCompletion() => completed;
        public Action<float> CaptureProgress() => progress;
        public void Cancel() { cancelled = true; completed = null; progress = null; }
    }
}

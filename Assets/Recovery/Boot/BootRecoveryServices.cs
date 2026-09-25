// Recovery-only adapters. They are intentionally separate from original game services.
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Soccer.Recovery.Boot
{
    public interface IBootCloudSaveAdapter
    {
        BootRecoveryProfile Profile { get; }
        System.Collections.IEnumerator CheckLoad(Action<bool> completed, Action<float> percentProgress);
        void Cancel();
    }

    public interface IBootSceneNavigator
    {
        bool TryLoadRecoveryStart();
    }

    public enum BootRecoveryEvent
    {
        Awake,
        WaitingForSaveRoot,
        CloudSaveStarted,
        Cancelled,
        NoCloudSaveAdapter,
        CloudSaveSucceeded,
        CloudSaveFailed,
        NetworkGateSatisfied,
        TransitionRequested,
        NoRecoveryNavigator,
        StartSceneLoaded,
        LateOrDuplicateCallbackIgnored
    }

    public static class BootRecoveryTrace
    {
        private static readonly List<BootRecoveryEvent> events = new List<BootRecoveryEvent>();
        private static readonly List<string> timeline = new List<string>();
        public static IReadOnlyList<BootRecoveryEvent> Events => events;
        public static IReadOnlyList<string> Timeline => timeline;
        public static void Record(BootRecoveryEvent value)
        {
            events.Add(value);
            timeline.Add(Time.frameCount + ": " + value);
        }
        public static void Reset() { events.Clear(); timeline.Clear(); }
        public static int Count(BootRecoveryEvent value)
        {
            var count = 0;
            foreach (var item in events) if (item == value) count++;
            return count;
        }
    }

    public static class BootRecoveryServices
    {
        private static IBootCloudSaveAdapter cloudSave;
        private static IBootSceneNavigator navigator;

        public static IBootCloudSaveAdapter CurrentCloudSave => cloudSave;
        public static void RegisterCloudSave(IBootCloudSaveAdapter value) => cloudSave = value;
        public static void UnregisterCloudSave(IBootCloudSaveAdapter value)
        {
            if (ReferenceEquals(cloudSave, value)) cloudSave = null;
        }
        public static void RegisterNavigator(IBootSceneNavigator value) => navigator = value;
        public static void UnregisterNavigator(IBootSceneNavigator value)
        {
            if (ReferenceEquals(navigator, value)) navigator = null;
        }
        public static bool TryLoadRecoveryStart() => navigator != null && navigator.TryLoadRecoveryStart();
        public static void Reset()
        {
            cloudSave = null;
            navigator = null;
            BootRecoveryTrace.Reset();
        }
    }
}

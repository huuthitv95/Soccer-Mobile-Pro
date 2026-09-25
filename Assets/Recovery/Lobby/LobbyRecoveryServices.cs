using System;
using System.Collections.Generic;
using UnityEngine;

namespace Soccer.Recovery.Lobby
{
    public enum LobbyRecoveryEvent
    {
        SessionStarted, WaitingForDependency, DependencyReady, DependencyFailed,
        AbTestWaitStarted, AbTestPassed, AbTestFailed, TeachingMatchBlocked,
        LobbyTransitionRequested, LobbyLoaded, MenuActionOpened, MenuActionReturned
    }

    public enum LobbyReadiness { Pending, Ready, Failed, NotRequired }
    public enum LobbyMode { Legacy, PlayerCareer }
    public enum LobbyDependency { ResourceManager, PressStart, NotchInitialized, AbTest, SaveCallback, NetworkProbe, CoreContent }

    [Serializable]
    public sealed class LobbyRecoveryProfile
    {
        public LobbyMode Mode = LobbyMode.Legacy;
        public bool TeachingMatchSelected;
        public LobbyReadiness ResourceManager = LobbyReadiness.Ready;
        public LobbyReadiness PressStart = LobbyReadiness.Ready;
        public LobbyReadiness NotchInitialized = LobbyReadiness.Ready;
        public LobbyReadiness SaveCallback = LobbyReadiness.Ready;
        public LobbyReadiness NetworkProbe = LobbyReadiness.Ready;
        public LobbyReadiness AbTest = LobbyReadiness.Ready;
        public LobbyReadiness CoreContent = LobbyReadiness.Ready;
        // Optional deterministic clock input for validation; -1 uses Unity Time.deltaTime.
        public float AbTestElapsedOverrideSeconds = -1f;
    }
    public static class LobbyRecoveryRunConfiguration
    {
        public static LobbyRecoveryProfile NextProfile;
        public static LobbyRecoveryProfile Consume(LobbyRecoveryProfile fallback)
        {
            var result = NextProfile ?? fallback;
            NextProfile = null;
            return result;
        }
    }

    public interface ILobbyContentProvider
    {
        GameObject Resolve(string nativeAssetPath);
    }
    public interface ILobbyStartupServices
    {
        LobbyRecoveryProfile Profile { get; }
        LobbyReadiness Readiness(LobbyDependency dependency);
    }
    public interface ILobbySceneNavigator
    {
        bool TryLoad(string recoveryScenePath);
        bool TryLoadStart();
    }
    public interface ILobbyActionSink
    {
        void OpenOfflineInformation(string actionId, string displayName);
        void ReturnToLobby();
    }

    public static class LobbyRecoveryTrace
    {
        private static readonly List<string> timeline = new List<string>();
        private static readonly List<LobbyRecoveryEvent> events = new List<LobbyRecoveryEvent>();
        public static IReadOnlyList<string> Timeline => timeline;
        public static IReadOnlyList<LobbyRecoveryEvent> Events => events;
        public static void Record(LobbyRecoveryEvent value, string detail = "")
        {
            events.Add(value);
            timeline.Add(Time.frameCount + ": " + value + (string.IsNullOrEmpty(detail) ? "" : " / " + detail));
        }
        public static int Count(LobbyRecoveryEvent value)
        {
            var result = 0;
            foreach (var item in events) if (item == value) result++;
            return result;
        }
        public static void Reset() { timeline.Clear(); events.Clear(); }
    }

    public static class LobbyRecoveryServices
    {
        public static ILobbyStartupServices Startup { get; private set; }
        public static ILobbySceneNavigator Navigator { get; private set; }
        public static ILobbyActionSink Actions { get; private set; }
        public static ILobbyContentProvider Content { get; private set; }
        public static void Register(ILobbyStartupServices v) { Startup = v; }
        public static void Register(ILobbySceneNavigator v) { Navigator = v; }
        public static void Register(ILobbyActionSink v) { Actions = v; }
        public static void Register(ILobbyContentProvider v) { Content = v; }
        public static void Reset()
        {
            Startup = null; Navigator = null; Actions = null; Content = null;
            LobbyRecoveryTrace.Reset();
        }
    }
}

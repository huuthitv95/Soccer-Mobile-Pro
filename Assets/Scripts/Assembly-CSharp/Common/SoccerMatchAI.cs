namespace Common
{
    public class SoccerMatchAI
    {
        private class OnCopyfileCallback : global::UnityEngine.AndroidJavaProxy
        {
            private global::System.Func<bool> until;
            private global::System.Func<string> parameters;
            public OnCopyfileCallback(global::System.Func<bool> until = null, global::System.Func<string> parameters = null) : base((string)null)
            {
            }

            public void OnOperationFinish(bool succeed, string path)
            {
            }
        }

        private class OnCopySplashfileCallback : global::UnityEngine.AndroidJavaProxy
        {
            private global::System.Action action;
            public OnCopySplashfileCallback(global::System.Action callback) : base((string)null)
            {
            }

            public void OnOperationFinish(bool succeed, string path)
            {
            }
        }

        public delegate void MessageFunction(ushort opcode, global::System.IntPtr buffer, int size);
        public delegate void LogFunction(string buffer);
        public delegate void NotifyPortFunction(ushort port);
        private unsafe delegate void match_init(char* parameters, int length);
        private unsafe delegate void set_assets_path(char* path, int length);
        private delegate void set_logger(global::System.IntPtr funcPtr);
        private delegate void set_notify_port(global::System.IntPtr funcPtr);
        private delegate void set_message_reader(global::System.IntPtr funcPtr);
        private static global::UnityEngine.AndroidJavaProxy _copyCB;
        private static global::UnityEngine.AndroidJavaProxy _copySplashCB;
        public static global::Common.Event<global::EngineMessages.MatchScoreChanged> OnMatchScoreChanged;
        public static global::Common.Event<global::EngineMessages.MatchPenaltiesChanged> OnMatchPenaltiesChanged;
        public static global::Common.Event<global::EngineMessages.SwtichPlayer> OnSwitchedPlayer;
        public static global::Common.Event<global::EngineMessages.GameOver> OnGameOver;
        public static global::Common.Event<global::EngineMessages.MatchPhaseChanged> OnMatchPhaseChanged;
        public static global::Common.Event<global::EngineMessages.FrameDetail> OnGetServerFrame;
        public static global::Common.Event<global::EngineMessages.MatchStatistics> OnGetStatistics;
        public static global::Common.Event OnMatchCreated;
        public static global::Common.Event<global::EngineMessages.FoulEvent> OnFoulEvent;
        public static global::Common.Event<global::EngineMessages.BallOverSideEvent> OnBallOverSideEvent;
        public static global::Common.Event OnOffsideEvent;
        public static global::Common.Event<global::EngineMessages.PrepareSetPieceEvent> OnPrepareSetPieceOver;
        public static global::Common.Event<global::EngineMessages.AllFatigues> OnPushFatigue;
        public static global::Common.Event<global::EngineMessages.IntValues> OnTeamOffDefTransition;
        public static global::Common.Event<OpCode, global::EngineMessages.IntValues> OnSfx;
        private static global::System.Threading.Thread aiThread;
        private static global::System.IntPtr enginePtr;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private static global::System.Action m_OnEngineInited;
        private static bool path_inited;
        public static global::System.Action OnNetworkReady;
        private static global::EngineMessages.InputData emptyInput;
        public static bool IsReady { get; set; }

        public static event global::System.Action OnEngineInited
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

        public static void StartEngine(string filecopy, global::System.Action onfilecopy = null, global::System.Func<bool> until = null, global::System.Func<string> parameters = null)
        {
        }

        [global::System.Runtime.InteropServices.PreserveSig]
        internal static extern int MatchInit(string parameters, int length);
        [global::System.Runtime.InteropServices.PreserveSig]
        internal static extern void SetAssetsPath(string path, int length);
        [global::System.Runtime.InteropServices.PreserveSig]
        internal static extern void SendMessage(ushort opcode, global::System.IntPtr buffer, int size);
        [global::System.Runtime.InteropServices.PreserveSig]
        internal static extern void SetLogger(global::System.IntPtr logger);
        [global::System.Runtime.InteropServices.PreserveSig]
        internal static extern void SetMessageReader(global::System.IntPtr reader);
        [global::System.Runtime.InteropServices.PreserveSig]
        internal static extern void SetNotifyPortFunction(global::System.IntPtr notifyFunction);
        public static void SetNotifyFunction(global::Common.SoccerMatchAI.NotifyPortFunction func)
        {
        }

        public static void SetLogger(global::Common.SoccerMatchAI.LogFunction logger)
        {
        }

        public static void SetMessageReader(global::Common.SoccerMatchAI.MessageFunction reader)
        {
        }

        public static void SendMessage(ushort opcode, byte[] buffer)
        {
        }

        public static void ReadMessage(ushort opcode, global::System.IntPtr bufferPtr, int size)
        {
        }

        public static void LogMessage(string message)
        {
        }

        public static void OnNotifyPort(ushort port)
        {
        }

        public static void ShutDownEngine()
        {
        }

        private static void StartEnginThread(string matchconfig)
        {
        }

        private static void StartEngineCode(string parameters = "")
        {
        }

        public static void SetupNativePath(string respath)
        {
        }

        private static void StartNetWork()
        {
        }

        private static void UpdateNet()
        {
        }

        private static void ReceiveEngineMessage(global::Common.GameMessage message)
        {
        }

        public static void StopMatch()
        {
        }

        public static void SetRuningState(bool play)
        {
        }

        public static void RequestSwitchPlayer(int teamId, int quitPlayerDatabaseId, int enterPlayerDatabaseId)
        {
        }

        public static void DoStep(global::EngineMessages.InputData inputData = null)
        {
        }

        public static void StartMatch(global::EngineMessages.MatchConfig matchConfig)
        {
        }

        public static void ChangeFormation(int teamId, string formationXml)
        {
        }

        public static void RestoreStamina(float value)
        {
        }

        public static void RestoreStamina(int playerId, float value)
        {
        }

        public static void SetBallPosition(global::UnityEngine.Vector3 ballPos)
        {
        }

        public static void RequestStatistics()
        {
        }

        public static void QueryFatigue()
        {
        }

        public static void ChangeRestartBallTaker(global::EngineMessages.RestartBallTaker restartMatchBallTaker)
        {
        }

        public static void ChangeTactics(int teamId, string str)
        {
        }

        public static void ChangeTactics(int teamId, TacticsData tacticsData)
        {
        }

        public static void ChangeConfigs(global::System.Collections.Generic.Dictionary<string, string> config)
        {
        }

        public static void ChangeGoalKickTacticConfig(int id)
        {
        }

        public static void ChangeCornerKickTacticConfig(int id)
        {
        }
    }
}
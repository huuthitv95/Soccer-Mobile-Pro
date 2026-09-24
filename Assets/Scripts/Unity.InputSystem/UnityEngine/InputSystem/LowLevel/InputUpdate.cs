namespace UnityEngine.InputSystem.LowLevel
{
    internal static class InputUpdate
    {
        [global::System.Serializable]
        public struct UpdateStepCount
        {
            private bool m_WasUpdated;
            public uint value { get; private set; }

            public void OnBeforeUpdate()
            {
            }

            public void OnUpdate()
            {
            }
        }

        [global::System.Serializable]
        public struct SerializedState
        {
            public global::UnityEngine.InputSystem.LowLevel.InputUpdateType lastUpdateType;
            public global::UnityEngine.InputSystem.LowLevel.InputUpdate.UpdateStepCount playerUpdateStepCount;
        }

        public static uint s_UpdateStepCount;
        public static global::UnityEngine.InputSystem.LowLevel.InputUpdateType s_LatestUpdateType;
        public static global::UnityEngine.InputSystem.LowLevel.InputUpdate.UpdateStepCount s_PlayerUpdateStepCount;
        internal static void OnBeforeUpdate(global::UnityEngine.InputSystem.LowLevel.InputUpdateType type)
        {
        }

        internal static void OnUpdate(global::UnityEngine.InputSystem.LowLevel.InputUpdateType type)
        {
        }

        public static global::UnityEngine.InputSystem.LowLevel.InputUpdate.SerializedState Save()
        {
            return default;
        }

        public static void Restore(global::UnityEngine.InputSystem.LowLevel.InputUpdate.SerializedState state)
        {
        }

        public static global::UnityEngine.InputSystem.LowLevel.InputUpdateType GetUpdateTypeForPlayer(this global::UnityEngine.InputSystem.LowLevel.InputUpdateType mask)
        {
            return global::UnityEngine.InputSystem.LowLevel.InputUpdateType.None;
        }

        public static bool IsPlayerUpdate(this global::UnityEngine.InputSystem.LowLevel.InputUpdateType updateType)
        {
            return false;
        }
    }
}
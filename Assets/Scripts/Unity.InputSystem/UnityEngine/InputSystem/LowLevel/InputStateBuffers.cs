namespace UnityEngine.InputSystem.LowLevel
{
    internal struct InputStateBuffers
    {
        [global::System.Serializable]
        internal struct DoubleBuffers
        {
            public unsafe void** deviceToBufferMapping;
            public bool valid => false;

            public unsafe void SetFrontBuffer(int deviceIndex, void* ptr)
            {
            }

            public unsafe void SetBackBuffer(int deviceIndex, void* ptr)
            {
            }

            public unsafe void* GetFrontBuffer(int deviceIndex)
            {
                return null;
            }

            public unsafe void* GetBackBuffer(int deviceIndex)
            {
                return null;
            }

            public void SwapBuffers(int deviceIndex)
            {
            }
        }

        public uint sizePerBuffer;
        public uint totalSize;
        public unsafe void* defaultStateBuffer;
        public unsafe void* noiseMaskBuffer;
        public unsafe void* resetMaskBuffer;
        private unsafe void* m_AllBuffers;
        internal global::UnityEngine.InputSystem.LowLevel.InputStateBuffers.DoubleBuffers m_PlayerStateBuffers;
        internal unsafe static void* s_DefaultStateBuffer;
        internal unsafe static void* s_NoiseMaskBuffer;
        internal unsafe static void* s_ResetMaskBuffer;
        internal static global::UnityEngine.InputSystem.LowLevel.InputStateBuffers.DoubleBuffers s_CurrentBuffers;
        public global::UnityEngine.InputSystem.LowLevel.InputStateBuffers.DoubleBuffers GetDoubleBuffersFor(global::UnityEngine.InputSystem.LowLevel.InputUpdateType updateType)
        {
            return default;
        }

        public unsafe static void* GetFrontBufferForDevice(int deviceIndex)
        {
            return null;
        }

        public unsafe static void* GetBackBufferForDevice(int deviceIndex)
        {
            return null;
        }

        public static void SwitchTo(global::UnityEngine.InputSystem.LowLevel.InputStateBuffers buffers, global::UnityEngine.InputSystem.LowLevel.InputUpdateType update)
        {
        }

        public void AllocateAll(global::UnityEngine.InputSystem.InputDevice[] devices, int deviceCount)
        {
        }

        private unsafe static global::UnityEngine.InputSystem.LowLevel.InputStateBuffers.DoubleBuffers SetUpDeviceToBufferMappings(int deviceCount, ref byte* bufferPtr, uint sizePerBuffer, uint mappingTableSizePerBuffer)
        {
            return default;
        }

        public void FreeAll()
        {
        }

        public void MigrateAll(global::UnityEngine.InputSystem.InputDevice[] devices, int deviceCount, global::UnityEngine.InputSystem.LowLevel.InputStateBuffers oldBuffers)
        {
        }

        private static void MigrateDoubleBuffer(global::UnityEngine.InputSystem.LowLevel.InputStateBuffers.DoubleBuffers newBuffer, global::UnityEngine.InputSystem.InputDevice[] devices, int deviceCount, global::UnityEngine.InputSystem.LowLevel.InputStateBuffers.DoubleBuffers oldBuffer)
        {
        }

        private unsafe static void MigrateSingleBuffer(void* newBuffer, global::UnityEngine.InputSystem.InputDevice[] devices, int deviceCount, void* oldBuffer)
        {
        }

        private static uint ComputeSizeOfSingleStateBuffer(global::UnityEngine.InputSystem.InputDevice[] devices, int deviceCount)
        {
            return 0u;
        }

        private static uint NextDeviceOffset(uint currentOffset, global::UnityEngine.InputSystem.InputDevice device)
        {
            return 0u;
        }
    }
}
public class BraidManager
{
    private enum CSKernel
    {
        UpdateFixedBones = 0,
        UpdatePosition = 1,
        ResolveConstraints = 2,
        UpdateCollision = 3,
        UpdateVelocity = 4,
        BulidMatrics = 5
    }

    public struct BoneGPU
    {
        public global::UnityEngine.Matrix4x4 bindpose;
        public global::UnityEngine.Matrix4x4 initTransform;
        public global::UnityEngine.Matrix4x4 initTransformInverse;
        public global::UnityEngine.Vector3 tailPosition;
        public float length;
        public global::UnityEngine.Vector3 prevTailPosition;
        private int _parentIdx;
        public global::UnityEngine.Vector3 velocity;
        private int matrixIdx_braidIdx;
        public int parentIdx
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public int braidIdx
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public int matrixIdx
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }
    }

    public struct BraidGPU
    {
        public global::UnityEngine.Matrix4x4 meshWorldToLocalMatrix;
        public global::UnityEngine.Matrix4x4 boneLocalToWorldMatrix;
        public global::UnityEngine.Matrix4x4 boneWorldToLocalMatrix;
        private global::UnityEngine.Vector4 collider0;
        private global::UnityEngine.Vector4 collider1;
        private global::UnityEngine.Vector4 collider2;
        private global::UnityEngine.Vector4 collider3;
        private global::UnityEngine.Vector4 collider4;
        private global::UnityEngine.Vector4 collider5;
        public int colliderCount;
        private uint fixedBoneOffsetAndCount;
        private uint physBoneOffsetAndCount;
        private float pad0;
        public uint fixedBoneOffset
        {
            get
            {
                return 0u;
            }

            set
            {
            }
        }

        public uint fixedBoneCount
        {
            get
            {
                return 0u;
            }

            set
            {
            }
        }

        public uint physBoneOffset
        {
            get
            {
                return 0u;
            }

            set
            {
            }
        }

        public uint physBoneCount
        {
            get
            {
                return 0u;
            }

            set
            {
            }
        }

        public void SetCollider(int idx, global::UnityEngine.Vector4 collider)
        {
        }
    }

    private global::UnityEngine.Rendering.CommandBuffer _commandBuffer;
    private global::UnityEngine.ComputeShader _computeShader;
    public int SolveCount;
    private const int BoneStructSize = 240;
    private const int BraidStructSize = 304;
    public global::UnityEngine.ComputeBuffer _braidsCB;
    public global::System.Collections.Generic.List<BraidManager.BraidGPU> _braidsCBData;
    public global::UnityEngine.ComputeBuffer _bonesCB;
    private int _boneMatrixCount;
    public global::UnityEngine.RenderTexture _boneMatrixTex;
    private int _totalFixedBoneCount;
    private int _totalPhysBoneCount;
    public global::System.Collections.Generic.List<BraidRenderer> _braidRenderers;
    private bool _isBraidCPUsDirty;
    private bool _isBraidsDirty;
    private bool _isMaterialDataDirty;
    private bool _isDisabled;
    private static BraidManager instance;
    private const int COMPUTE_THREAD_COUNT_X = 16;
    public static BraidManager Instance => null;

    private void DisableBraidRenderer(BraidRenderer braidRenderer)
    {
    }

    public void DisableBraidManager()
    {
    }

    public void RegisterBraid(BraidRenderer braidRenderer)
    {
    }

    public void UnRegisterBraid(BraidRenderer braidRenderer)
    {
    }

    public void InitColliders(global::UnityEngine.GameObject hairGO, global::UnityEngine.GameObject playerGO)
    {
    }

    public void GeneratePlayer(global::UnityEngine.GameObject playerGO)
    {
    }

    public void CreateHair(global::UnityEngine.GameObject hairGO)
    {
    }

    private global::System.Collections.Generic.List<global::System.Tuple<global::UnityEngine.Transform, int>> GetHierarchyList(global::UnityEngine.Transform root)
    {
        return null;
    }

    private void UpdateComputeBufferData()
    {
    }

    private void UpdateMaterialData()
    {
    }

    private static global::UnityEngine.RenderTextureFormat GetBoneMatrixFormat()
    {
        return global::UnityEngine.RenderTextureFormat.ARGB32;
    }

    public void Update(BraidRenderer braidRenderer)
    {
    }

    private void GenerateCommandBuffer()
    {
    }

    public void LateUpdate()
    {
    }
}
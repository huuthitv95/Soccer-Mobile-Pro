public class SelectRole : global::UnityEngine.MonoBehaviour
{
    private sealed class TemporaryBallHider : global::System.IDisposable
    {
        private global::UnityEngine.MeshRenderer ball;
        private bool wasActive;
        private global::UnityEngine.GameObject selected;
        private bool selectedWasActive;
        public TemporaryBallHider(global::UnityEngine.MeshRenderer ball, global::UnityEngine.GameObject selected, bool wasActive, bool selectedWasActive)
        {
        }

        public void Dispose()
        {
        }
    }

    private static readonly int[] appearanceIds;
    private const string IdleTypeParam = "IdleType";
    private const string SelectCloserTrigger = "SelectCloser";
    private const string SelectBackTrigger = "SelectBack";
    private const string ForceIdleTrigger = "ForceIdle";
    private const int StaticPlayerIndex = 3;
    [global::UnityEngine.SerializeField]
    private PlayerModelLoader[] playerModelLoader;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Camera targetCamera;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.MeshRenderer ball;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform selected;
    private global::UnityEngine.Collider[] colliders;
    private global::UnityEngine.Animator[] animators;
    private global::UnityEngine.Vector3[] originWorldPositions;
    private bool[] originPoseCached;
    private global::UnityEngine.Quaternion[] originWorldRotations;
    private SelectRoleRootMotionCorrector[] rootMotionCorrectors;
    private global::System.Action<int, global::UnityEngine.GameObject> onRoleSelected;
    private int selectedIndex;
    private bool isInitialized;
    public void Init(global::System.Action<int, global::UnityEngine.GameObject> onRoleSelected)
    {
    }

    public global::System.IDisposable HideBallTemporarily()
    {
        return null;
    }

    public global::UnityEngine.GameObject ShowStaticPlayer(int appearanceId)
    {
        return null;
    }

    public void ShowBlank()
    {
    }

    private global::UnityEngine.GameObject PreparePlayerModel(int index, int appearanceId, bool applyRootMotion, bool enableCollider)
    {
        return null;
    }

    private void ApplyAppearance(int index, int appearanceId, bool applyRootMotion)
    {
    }

    private void SetLoadedPlayerActive(int index, bool active)
    {
    }

    private void ResetSelectionState()
    {
    }

    private void Update()
    {
    }

    private bool TryGetPointerDownPosition(out global::UnityEngine.Vector2 position)
    {
        position = default;
        return false;
    }

    private int GetRoleIndexByHit(global::UnityEngine.Collider hit)
    {
        return 0;
    }

    private void Select(int index)
    {
    }

    private void TriggerMove(int index, bool isMoveCloser)
    {
    }

    private void CacheOriginPose(int index, global::UnityEngine.GameObject go)
    {
    }

    private void SetIdleByParam(int index, bool forceIdle)
    {
    }

    private void EquipBall(int idx, global::UnityEngine.GameObject go)
    {
    }
}
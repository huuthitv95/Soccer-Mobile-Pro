namespace Common
{
    [global::UnityEngine.DisallowMultipleComponent]
    public class OccludedObjectRuleHandler : global::UnityEngine.MonoBehaviour
    {
        private struct OccludedObjectState
        {
            public global::UnityEngine.GameObject target;
            public bool wasActive;
        }

        [global::UnityEngine.SerializeField]
        private global::UnityEngine.GameObject[] hideObjectsWhenOccluded;
        [global::UnityEngine.SerializeField]
        private global::UnityEngine.GameObject[] hideObjectsWhenClosing;
        private global::System.Collections.Generic.List<global::UnityEngine.GameObject> dynamicHideOnOcclusion;
        private global::System.Collections.Generic.List<global::UnityEngine.GameObject> dynamicHideOnClosing;
        private readonly global::System.Collections.Generic.List<global::Common.OccludedObjectRuleHandler.OccludedObjectState> occludedHiddenObjects;
        private global::Common.WindowBase occludingWindowForHiddenObjects;
        private WindowTweenBase occludingTweenForHiddenObjects;
        private global::Common.WindowBase ownerWindow;
        private WindowTweenBase ownerTweenForHideWhenClosing;
        public void AddDynamicHideOnOcclusion(global::UnityEngine.GameObject obj)
        {
        }

        public void AddDynamicHideOnClosing(global::UnityEngine.GameObject obj)
        {
        }

        private void Awake()
        {
        }

        private void Start()
        {
        }

        public void Apply(global::Common.WindowBase other)
        {
        }

        public void Restore()
        {
        }

        public void Cleanup()
        {
        }

        private void OnDestroy()
        {
        }

        private void UnregisterOccludedObjectRestoreCallback()
        {
        }

        private void TryRegisterHideWhenClosingCallback()
        {
        }

        private void UnregisterHideWhenClosingCallback()
        {
        }

        private void HideConfiguredObjects()
        {
        }
    }
}
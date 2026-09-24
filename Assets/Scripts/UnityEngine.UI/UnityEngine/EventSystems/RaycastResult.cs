namespace UnityEngine.EventSystems
{
    public struct RaycastResult
    {
        private global::UnityEngine.GameObject m_GameObject;
        public global::UnityEngine.EventSystems.BaseRaycaster module;
        public float distance;
        public float index;
        public int depth;
        public int sortingGroupID;
        public int sortingGroupOrder;
        public int sortingLayer;
        public int sortingOrder;
        public global::UnityEngine.Vector3 worldPosition;
        public global::UnityEngine.Vector3 worldNormal;
        public global::UnityEngine.Vector2 screenPosition;
        public int displayIndex;
        public global::UnityEngine.GameObject gameObject
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public bool isValid => false;

        public void Clear()
        {
        }

        public override string ToString()
        {
            return null;
        }
    }
}
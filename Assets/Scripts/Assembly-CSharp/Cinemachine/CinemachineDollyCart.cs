namespace Cinemachine
{
    public class CinemachineDollyCart : global::UnityEngine.MonoBehaviour
    {
        public enum UpdateMethod
        {
            Update = 0,
            FixedUpdate = 1
        }

        public global::Cinemachine.CinemachinePathBase m_Path;
        public global::Cinemachine.CinemachineDollyCart.UpdateMethod m_UpdateMethod;
        public global::Cinemachine.CinemachinePathBase.PositionUnits m_PositionUnits;
        public float m_Speed;
        public float m_Position;
        private void FixedUpdate()
        {
        }

        private void Update()
        {
        }

        private void SetCartPosition(float distanceAlongPath)
        {
        }
    }
}
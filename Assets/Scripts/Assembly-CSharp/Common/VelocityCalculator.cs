namespace Common
{
    public struct VelocityCalculator
    {
        private global::UnityEngine.Vector3[] positions;
        private int currentIndex;
        public global::UnityEngine.Vector3 Velocity { get; private set; }

        public void RecordPosition(global::UnityEngine.Vector3 position, float detlaTime)
        {
        }

        private void UpdateVelocity(float deltaTime)
        {
        }

        public VelocityCalculator(int size)
        {
            positions = null;
            currentIndex = 0;
            Velocity = default;
        }
    }
}
namespace FLMessageSystem.IngameMessages
{
	public struct OnSfxBallBounce
	{
		public global::UnityEngine.Transform ball;

		public global::UnityEngine.Vector3 Velocity;

		public float VelocityMagnitude;

		public OnSfxBallBounce(global::UnityEngine.Transform ball, global::UnityEngine.Vector3 velocity)
		{
			this.ball = null;
			Velocity = default;
			VelocityMagnitude = 0f;
		}
	}
}

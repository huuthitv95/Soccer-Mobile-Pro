namespace FLMessageSystem.IngameMessages
{
	public struct OnKickBallSFX
	{
		public OpCode sfx;

		public global::UnityEngine.Transform ball;

		public global::UnityEngine.Vector3 Velocity;

		public float VelocityMagnitude;

		public OnKickBallSFX(OpCode sfx, global::UnityEngine.Transform ball, global::UnityEngine.Vector3 velocity)
		{
			this.sfx = OpCode.None;
			this.ball = null;
			Velocity = default;
			VelocityMagnitude = 0f;
		}
	}
}

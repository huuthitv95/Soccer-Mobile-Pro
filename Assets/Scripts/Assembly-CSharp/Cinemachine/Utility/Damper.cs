namespace Cinemachine.Utility
{
	public static class Damper
	{
		private const float Epsilon = 0.0001f;

		public const float kNegligibleResidual = 0.01f;

		private static float DecayConstant(float time, float residual)
		{
			return 0f;
		}

		private static float Decay(float initial, float decayConstant, float deltaTime)
		{
			return 0f;
		}

		public static float Damp(float initial, float dampTime, float deltaTime)
		{
			return 0f;
		}

		public static global::UnityEngine.Vector3 Damp(global::UnityEngine.Vector3 initial, global::UnityEngine.Vector3 dampTime, float deltaTime)
		{
			return default;
		}

		public static global::UnityEngine.Vector3 Damp(global::UnityEngine.Vector3 initial, float dampTime, float deltaTime)
		{
			return default;
		}
	}
}

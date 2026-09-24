namespace UnityEngine.InputSystem.Processors
{
	internal class CompensateRotationProcessor : global::UnityEngine.InputSystem.InputProcessor<global::UnityEngine.Quaternion>
	{
		public override global::UnityEngine.InputSystem.InputProcessor.CachingPolicy cachingPolicy => global::UnityEngine.InputSystem.InputProcessor.CachingPolicy.CacheResult;

		public override global::UnityEngine.Quaternion Process(global::UnityEngine.Quaternion value, global::UnityEngine.InputSystem.InputControl control)
		{
			return default;
		}

		public override string ToString()
		{
			return null;
		}
	}
}

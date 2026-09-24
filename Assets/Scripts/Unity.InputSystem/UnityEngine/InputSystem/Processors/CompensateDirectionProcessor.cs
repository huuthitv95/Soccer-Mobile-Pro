namespace UnityEngine.InputSystem.Processors
{
	internal class CompensateDirectionProcessor : global::UnityEngine.InputSystem.InputProcessor<global::UnityEngine.Vector3>
	{
		public override global::UnityEngine.InputSystem.InputProcessor.CachingPolicy cachingPolicy => global::UnityEngine.InputSystem.InputProcessor.CachingPolicy.CacheResult;

		public override global::UnityEngine.Vector3 Process(global::UnityEngine.Vector3 value, global::UnityEngine.InputSystem.InputControl control)
		{
			return default;
		}

		public override string ToString()
		{
			return null;
		}
	}
}

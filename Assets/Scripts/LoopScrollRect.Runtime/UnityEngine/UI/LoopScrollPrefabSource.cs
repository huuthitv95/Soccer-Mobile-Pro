namespace UnityEngine.UI
{
	public interface LoopScrollPrefabSource
	{
		global::UnityEngine.GameObject GetObject(int index);

		void ReturnObject(global::UnityEngine.Transform trans);
	}
}

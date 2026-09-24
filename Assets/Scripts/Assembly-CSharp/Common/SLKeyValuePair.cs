namespace Common
{
	[global::System.Serializable]
	public class SLKeyValuePair<KEY, VALUE>
	{
		[global::UnityEngine.SerializeField]
		public KEY key;

		[global::UnityEngine.SerializeField]
		public VALUE value;
	}
}

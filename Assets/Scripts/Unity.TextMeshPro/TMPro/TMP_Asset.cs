namespace TMPro
{
	[global::System.Serializable]
	public abstract class TMP_Asset : global::UnityEngine.ScriptableObject
	{
		private int m_InstanceID;

		public int hashCode;

		public global::UnityEngine.Material material;

		public int materialHashCode;

		public int instanceID => 0;
	}
}

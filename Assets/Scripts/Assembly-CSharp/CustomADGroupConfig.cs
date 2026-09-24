[global::UnityEngine.CreateAssetMenu]
public class CustomADGroupConfig : global::UnityEngine.ScriptableObject
{
	[global::System.Serializable]
	public struct ADGroup
	{
		public int groupId;

		public string[] materialNames;

		public float displayDuration;
	}

	public CustomADGroupConfig.ADGroup[] groups;
}

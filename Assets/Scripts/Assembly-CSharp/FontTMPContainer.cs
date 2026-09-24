[global::UnityEngine.CreateAssetMenu]
public class FontTMPContainer : global::UnityEngine.ScriptableObject
{
	[global::System.Serializable]
	public struct FontTMPEntry
	{
		public global::TMPro.TMP_FontAsset font;

		public global::UnityEngine.Material[] materials;
	}

	[global::UnityEngine.SerializeField]
	public FontTMPContainer.FontTMPEntry[] FontTMPs;
}

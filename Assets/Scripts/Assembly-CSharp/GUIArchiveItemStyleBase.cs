public abstract class GUIArchiveItemStyleBase : global::UnityEngine.MonoBehaviour
{
	protected static readonly string NormalStylePrefabPath;

	protected static readonly string PlayerCareerStylePrefabPath;

	public abstract void Fill(Win_Archives.ArchiveInfo archiveInfo);

	public static GUIArchiveItemStyleBase Create(Win_Archives.ArchiveInfo info, global::UnityEngine.Transform parent)
	{
		return null;
	}
}

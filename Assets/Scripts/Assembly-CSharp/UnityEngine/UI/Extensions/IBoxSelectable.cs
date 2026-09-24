namespace UnityEngine.UI.Extensions
{
	public interface IBoxSelectable
	{
		bool selected { get; set; }

		bool preSelected { get; set; }

		global::UnityEngine.Transform transform { get; }
	}
}

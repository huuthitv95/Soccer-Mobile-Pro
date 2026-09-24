namespace FancyScrollView
{
	public interface IFancyCellGroupContext
	{
		global::UnityEngine.GameObject CellTemplate { get; set; }

		global::System.Func<int> GetGroupCount { get; set; }
	}
}

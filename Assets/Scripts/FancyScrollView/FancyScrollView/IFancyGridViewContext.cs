namespace FancyScrollView
{
	public interface IFancyGridViewContext : global::FancyScrollView.IFancyScrollRectContext, global::FancyScrollView.IFancyCellGroupContext
	{
		global::System.Func<float> GetStartAxisSpacing { get; set; }

		global::System.Func<float> GetCellSize { get; set; }
	}
}

namespace FancyScrollView
{
	public interface IFancyScrollRectContext
	{
		global::FancyScrollView.ScrollDirection ScrollDirection { get; set; }

		global::System.Func<(float, float)> CalculateScrollSize { get; set; }
	}
}

namespace FLInterface
{
	public interface IShowHideable
	{
		bool enabled { get; }

		void Show();

		void Hide();
	}
}

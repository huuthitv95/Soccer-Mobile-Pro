namespace Common
{
	public interface IRecycleable
	{
		void OnCreateFromPool();

		void OnReleaseToPool();
	}
}

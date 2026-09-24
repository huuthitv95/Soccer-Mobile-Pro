namespace Game.UI.Tween
{
	public interface ISequentialTweenItem
	{
		global::UnityEngine.RectTransform RootRect { get; }

		float StartDelay { get; set; }

		bool IsActiveAndEnabled { get; }

		global::Game.UI.Tween.SequentialTweenItemType ItemType { get; }

		void Play();

		void Stop();
	}
}

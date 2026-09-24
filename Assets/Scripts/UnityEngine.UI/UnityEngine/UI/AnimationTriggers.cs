namespace UnityEngine.UI
{
	[global::System.Serializable]
	public class AnimationTriggers
	{
		private const string kDefaultNormalAnimName = "Normal";

		private const string kDefaultHighlightedAnimName = "Highlighted";

		private const string kDefaultPressedAnimName = "Pressed";

		private const string kDefaultSelectedAnimName = "Selected";

		private const string kDefaultDisabledAnimName = "Disabled";

		[global::UnityEngine.SerializeField]
		private string m_NormalTrigger;

		[global::UnityEngine.SerializeField]
		private string m_HighlightedTrigger;

		[global::UnityEngine.SerializeField]
		private string m_PressedTrigger;

		[global::UnityEngine.SerializeField]
		private string m_SelectedTrigger;

		[global::UnityEngine.SerializeField]
		private string m_DisabledTrigger;

		public string normalTrigger
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string highlightedTrigger
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string pressedTrigger
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string selectedTrigger
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string disabledTrigger
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}

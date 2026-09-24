namespace UnityEngine.UI
{
	[global::System.Serializable]
	public struct Navigation : global::System.IEquatable<global::UnityEngine.UI.Navigation>
	{
		[global::System.Flags]
		public enum Mode
		{
			None = 0,
			Horizontal = 1,
			Vertical = 2,
			Automatic = Horizontal | Vertical,
			Explicit = 4
		}

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.UI.Navigation.Mode m_Mode;

		[global::UnityEngine.SerializeField]
		private bool m_WrapAround;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.UI.Selectable m_SelectOnUp;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.UI.Selectable m_SelectOnDown;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.UI.Selectable m_SelectOnLeft;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.UI.Selectable m_SelectOnRight;

		public global::UnityEngine.UI.Navigation.Mode mode
		{
			get
			{
				return global::UnityEngine.UI.Navigation.Mode.None;
			}
			set
			{
			}
		}

		public bool wrapAround
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public global::UnityEngine.UI.Selectable selectOnUp
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public global::UnityEngine.UI.Selectable selectOnDown
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public global::UnityEngine.UI.Selectable selectOnLeft
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public global::UnityEngine.UI.Selectable selectOnRight
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static global::UnityEngine.UI.Navigation defaultNavigation => default;

		public bool Equals(global::UnityEngine.UI.Navigation other)
		{
			return false;
		}
	}
}

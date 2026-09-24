namespace UnityEngine.UI
{
	[global::System.Serializable]
	public struct ColorBlock : global::System.IEquatable<global::UnityEngine.UI.ColorBlock>
	{
		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Color m_NormalColor;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Color m_HighlightedColor;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Color m_PressedColor;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Color m_SelectedColor;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Color m_DisabledColor;

		[global::UnityEngine.SerializeField]
		private float m_ColorMultiplier;

		[global::UnityEngine.SerializeField]
		private float m_FadeDuration;

		public static global::UnityEngine.UI.ColorBlock defaultColorBlock;

		public global::UnityEngine.Color normalColor
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public global::UnityEngine.Color highlightedColor
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public global::UnityEngine.Color pressedColor
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public global::UnityEngine.Color selectedColor
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public global::UnityEngine.Color disabledColor
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public float colorMultiplier
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float fadeDuration
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		static ColorBlock()
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(global::UnityEngine.UI.ColorBlock other)
		{
			return false;
		}

		public static bool operator ==(global::UnityEngine.UI.ColorBlock point1, global::UnityEngine.UI.ColorBlock point2)
		{
			return false;
		}

		public static bool operator !=(global::UnityEngine.UI.ColorBlock point1, global::UnityEngine.UI.ColorBlock point2)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}

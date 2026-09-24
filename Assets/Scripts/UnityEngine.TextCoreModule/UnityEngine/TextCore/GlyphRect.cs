namespace UnityEngine.TextCore
{
	[global::System.Serializable]
	[global::UnityEngine.Scripting.UsedByNativeCode]
	public struct GlyphRect : global::System.IEquatable<global::UnityEngine.TextCore.GlyphRect>
	{
		[global::UnityEngine.SerializeField]
		private int m_X;

		[global::UnityEngine.SerializeField]
		private int m_Y;

		[global::UnityEngine.SerializeField]
		private int m_Width;

		[global::UnityEngine.SerializeField]
		private int m_Height;

		private static readonly global::UnityEngine.TextCore.GlyphRect s_ZeroGlyphRect;

		public int x => 0;

		public int y => 0;

		public int width => 0;

		public int height => 0;

		public static global::UnityEngine.TextCore.GlyphRect zero => default;

		public GlyphRect(int x, int y, int width, int height)
		{
			m_X = 0;
			m_Y = 0;
			m_Width = 0;
			m_Height = 0;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(global::UnityEngine.TextCore.GlyphRect other)
		{
			return false;
		}
	}
}

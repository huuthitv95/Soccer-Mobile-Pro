namespace UnityEngine.TextCore.LowLevel
{
	[global::System.Serializable]
	[global::UnityEngine.Scripting.UsedByNativeCode]
	public struct GlyphValueRecord : global::System.IEquatable<global::UnityEngine.TextCore.LowLevel.GlyphValueRecord>
	{
		[global::UnityEngine.SerializeField]
		private float m_XPlacement;

		[global::UnityEngine.SerializeField]
		private float m_YPlacement;

		[global::UnityEngine.SerializeField]
		private float m_XAdvance;

		[global::UnityEngine.SerializeField]
		private float m_YAdvance;

		public float xPlacement => 0f;

		public float yPlacement => 0f;

		public float xAdvance => 0f;

		public float yAdvance => 0f;

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(global::UnityEngine.TextCore.LowLevel.GlyphValueRecord other)
		{
			return false;
		}
	}
}

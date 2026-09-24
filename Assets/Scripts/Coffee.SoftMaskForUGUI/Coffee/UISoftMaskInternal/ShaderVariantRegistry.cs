namespace Coffee.UISoftMaskInternal
{
	[global::System.Serializable]
	public class ShaderVariantRegistry
	{
		[global::System.Serializable]
		internal class StringPair : global::System.IEquatable<global::Coffee.UISoftMaskInternal.ShaderVariantRegistry.StringPair>
		{
			public string key;

			public string value;

			public bool Equals(global::Coffee.UISoftMaskInternal.ShaderVariantRegistry.StringPair other)
			{
				return false;
			}

			public override bool Equals(object obj)
			{
				return false;
			}

			public override int GetHashCode()
			{
				return 0;
			}
		}

		private global::System.Collections.Generic.Dictionary<int, string> _cachedOptionalShaders;

		[global::UnityEngine.SerializeField]
		private global::System.Collections.Generic.List<global::Coffee.UISoftMaskInternal.ShaderVariantRegistry.StringPair> m_OptionalShaders;

		[global::UnityEngine.SerializeField]
		internal global::UnityEngine.ShaderVariantCollection m_Asset;

		public global::System.Func<string, bool> onShaderRequested;

		public global::UnityEngine.ShaderVariantCollection shaderVariantCollection => null;

		public global::UnityEngine.Shader FindOptionalShader(global::UnityEngine.Shader shader, string requiredName, string format, string defaultOptionalShaderName)
		{
			return null;
		}
	}
}

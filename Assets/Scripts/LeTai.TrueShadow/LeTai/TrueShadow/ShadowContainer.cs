namespace LeTai.TrueShadow
{
	internal class ShadowContainer
	{
		public readonly int requestHash;

		public global::UnityEngine.RenderTexture Texture { get; }

		public global::LeTai.TrueShadow.ShadowSettingSnapshot Snapshot { get; }

		public int Padding { get; }

		public global::UnityEngine.Vector2Int ImprintSize { get; }

		public int RefCount { get; internal set; }

		internal ShadowContainer(global::UnityEngine.RenderTexture texture, global::LeTai.TrueShadow.ShadowSettingSnapshot snapshot, int padding, global::UnityEngine.Vector2Int imprintSize)
		{
		}
	}
}

namespace DG.Tweening.Plugins.Core.PathCore
{
	[global::System.Serializable]
	public struct ControlPoint
	{
		public global::UnityEngine.Vector3 a;

		public global::UnityEngine.Vector3 b;

		public ControlPoint(global::UnityEngine.Vector3 a, global::UnityEngine.Vector3 b)
		{
			this.a = default;
			this.b = default;
		}

		public static global::DG.Tweening.Plugins.Core.PathCore.ControlPoint operator +(global::DG.Tweening.Plugins.Core.PathCore.ControlPoint cp, global::UnityEngine.Vector3 v)
		{
			return default;
		}

		public override string ToString()
		{
			return null;
		}
	}
}

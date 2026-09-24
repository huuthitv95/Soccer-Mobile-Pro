namespace UnityEngine.UI.Extensions
{
	[global::System.Serializable]
	public class CableCurve
	{
		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Vector2 m_start;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Vector2 m_end;

		[global::UnityEngine.SerializeField]
		private float m_slack;

		[global::UnityEngine.SerializeField]
		private int m_steps;

		[global::UnityEngine.SerializeField]
		private bool m_regen;

		private static global::UnityEngine.Vector2[] emptyCurve;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Vector2[] points;

		public bool regenPoints
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public global::UnityEngine.Vector2 start
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public global::UnityEngine.Vector2 end
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public float slack
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int steps
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public global::UnityEngine.Vector2 midPoint => default;

		public CableCurve()
		{
		}

		public CableCurve(global::UnityEngine.Vector2[] inputPoints)
		{
		}

		public CableCurve(global::UnityEngine.UI.Extensions.CableCurve v)
		{
		}

		public global::UnityEngine.Vector2[] Points()
		{
			return null;
		}
	}
}

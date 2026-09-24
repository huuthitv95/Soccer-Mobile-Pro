namespace UnityEngine.UI.Extensions
{
	public class Circle
	{
		[global::UnityEngine.SerializeField]
		private float xAxis;

		[global::UnityEngine.SerializeField]
		private float yAxis;

		[global::UnityEngine.SerializeField]
		private int steps;

		public float X
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float Y
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int Steps
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public Circle(float radius)
		{
		}

		public Circle(float radius, int steps)
		{
		}

		public Circle(float xAxis, float yAxis)
		{
		}

		public Circle(float xAxis, float yAxis, int steps)
		{
		}

		public global::UnityEngine.Vector2 Evaluate(float t)
		{
			return default;
		}

		public void Evaluate(float t, out global::UnityEngine.Vector2 eval)
		{
			eval = default;
		}
	}
}

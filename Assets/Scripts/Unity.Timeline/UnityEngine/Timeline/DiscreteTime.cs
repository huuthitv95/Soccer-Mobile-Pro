namespace UnityEngine.Timeline
{
	internal struct DiscreteTime : global::System.IComparable
	{
		private const double k_Tick = 1E-12;

		public static readonly global::UnityEngine.Timeline.DiscreteTime kMaxTime;

		private readonly long m_DiscreteTime;

		public static double tickValue => 0.0;

		public DiscreteTime(global::UnityEngine.Timeline.DiscreteTime time)
		{
			m_DiscreteTime = 0L;
		}

		private DiscreteTime(long time)
		{
			m_DiscreteTime = 0L;
		}

		public DiscreteTime(double time)
		{
			m_DiscreteTime = 0L;
		}

		public DiscreteTime(float time)
		{
			m_DiscreteTime = 0L;
		}

		public DiscreteTime(int time)
		{
			m_DiscreteTime = 0L;
		}

		public DiscreteTime(int frame, double fps)
		{
			m_DiscreteTime = 0L;
		}

		public global::UnityEngine.Timeline.DiscreteTime OneTickBefore()
		{
			return default;
		}

		public global::UnityEngine.Timeline.DiscreteTime OneTickAfter()
		{
			return default;
		}

		public long GetTick()
		{
			return 0L;
		}

		public static global::UnityEngine.Timeline.DiscreteTime FromTicks(long ticks)
		{
			return default;
		}

		public int CompareTo(object obj)
		{
			return 0;
		}

		public bool Equals(global::UnityEngine.Timeline.DiscreteTime other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		private static long DoubleToDiscreteTime(double time)
		{
			return 0L;
		}

		private static long FloatToDiscreteTime(float time)
		{
			return 0L;
		}

		private static long IntToDiscreteTime(int time)
		{
			return 0L;
		}

		private static double ToDouble(long time)
		{
			return 0.0;
		}

		private static float ToFloat(long time)
		{
			return 0f;
		}

		public static explicit operator double(global::UnityEngine.Timeline.DiscreteTime b)
		{
			return 0.0;
		}

		public static explicit operator float(global::UnityEngine.Timeline.DiscreteTime b)
		{
			return 0f;
		}

		public static explicit operator long(global::UnityEngine.Timeline.DiscreteTime b)
		{
			return 0L;
		}

		public static explicit operator global::UnityEngine.Timeline.DiscreteTime(double time)
		{
			return default;
		}

		public static explicit operator global::UnityEngine.Timeline.DiscreteTime(float time)
		{
			return default;
		}

		public static implicit operator global::UnityEngine.Timeline.DiscreteTime(int time)
		{
			return default;
		}

		public static explicit operator global::UnityEngine.Timeline.DiscreteTime(long time)
		{
			return default;
		}

		public static bool operator ==(global::UnityEngine.Timeline.DiscreteTime lhs, global::UnityEngine.Timeline.DiscreteTime rhs)
		{
			return false;
		}

		public static bool operator !=(global::UnityEngine.Timeline.DiscreteTime lhs, global::UnityEngine.Timeline.DiscreteTime rhs)
		{
			return false;
		}

		public static bool operator >(global::UnityEngine.Timeline.DiscreteTime lhs, global::UnityEngine.Timeline.DiscreteTime rhs)
		{
			return false;
		}

		public static bool operator <(global::UnityEngine.Timeline.DiscreteTime lhs, global::UnityEngine.Timeline.DiscreteTime rhs)
		{
			return false;
		}

		public static bool operator <=(global::UnityEngine.Timeline.DiscreteTime lhs, global::UnityEngine.Timeline.DiscreteTime rhs)
		{
			return false;
		}

		public static bool operator >=(global::UnityEngine.Timeline.DiscreteTime lhs, global::UnityEngine.Timeline.DiscreteTime rhs)
		{
			return false;
		}

		public static global::UnityEngine.Timeline.DiscreteTime operator +(global::UnityEngine.Timeline.DiscreteTime lhs, global::UnityEngine.Timeline.DiscreteTime rhs)
		{
			return default;
		}

		public static global::UnityEngine.Timeline.DiscreteTime operator -(global::UnityEngine.Timeline.DiscreteTime lhs, global::UnityEngine.Timeline.DiscreteTime rhs)
		{
			return default;
		}

		public override string ToString()
		{
			return null;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static global::UnityEngine.Timeline.DiscreteTime Min(global::UnityEngine.Timeline.DiscreteTime lhs, global::UnityEngine.Timeline.DiscreteTime rhs)
		{
			return default;
		}

		public static global::UnityEngine.Timeline.DiscreteTime Max(global::UnityEngine.Timeline.DiscreteTime lhs, global::UnityEngine.Timeline.DiscreteTime rhs)
		{
			return default;
		}

		public static double SnapToNearestTick(double time)
		{
			return 0.0;
		}

		public static float SnapToNearestTick(float time)
		{
			return 0f;
		}

		public static long GetNearestTick(double time)
		{
			return 0L;
		}
	}
}

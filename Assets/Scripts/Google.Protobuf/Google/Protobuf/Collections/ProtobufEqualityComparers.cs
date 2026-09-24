namespace Google.Protobuf.Collections
{
	public static class ProtobufEqualityComparers
	{
		private class BitwiseDoubleEqualityComparerImpl : global::System.Collections.Generic.EqualityComparer<double>
		{
			public override bool Equals(double x, double y)
			{
				return false;
			}

			public override int GetHashCode(double obj)
			{
				return 0;
			}
		}

		private class BitwiseSingleEqualityComparerImpl : global::System.Collections.Generic.EqualityComparer<float>
		{
			public override bool Equals(float x, float y)
			{
				return false;
			}

			public override int GetHashCode(float obj)
			{
				return 0;
			}
		}

		private class BitwiseNullableDoubleEqualityComparerImpl : global::System.Collections.Generic.EqualityComparer<double?>
		{
			public override bool Equals(double? x, double? y)
			{
				return false;
			}

			public override int GetHashCode(double? obj)
			{
				return 0;
			}
		}

		private class BitwiseNullableSingleEqualityComparerImpl : global::System.Collections.Generic.EqualityComparer<float?>
		{
			public override bool Equals(float? x, float? y)
			{
				return false;
			}

			public override int GetHashCode(float? obj)
			{
				return 0;
			}
		}

		public static global::System.Collections.Generic.EqualityComparer<double> BitwiseDoubleEqualityComparer { get; }

		public static global::System.Collections.Generic.EqualityComparer<float> BitwiseSingleEqualityComparer { get; }

		public static global::System.Collections.Generic.EqualityComparer<double?> BitwiseNullableDoubleEqualityComparer { get; }

		public static global::System.Collections.Generic.EqualityComparer<float?> BitwiseNullableSingleEqualityComparer { get; }

		public static global::System.Collections.Generic.EqualityComparer<T> GetEqualityComparer<T>()
		{
			return null;
		}
	}
}

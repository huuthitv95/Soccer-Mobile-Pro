namespace Google.Protobuf
{
	internal sealed class JsonToken : global::System.IEquatable<global::Google.Protobuf.JsonToken>
	{
		internal enum TokenType
		{
			Null = 0,
			False = 1,
			True = 2,
			StringValue = 3,
			Number = 4,
			Name = 5,
			StartObject = 6,
			EndObject = 7,
			StartArray = 8,
			EndArray = 9,
			EndDocument = 10
		}

		private static readonly global::Google.Protobuf.JsonToken _true;

		private static readonly global::Google.Protobuf.JsonToken _false;

		private static readonly global::Google.Protobuf.JsonToken _null;

		private static readonly global::Google.Protobuf.JsonToken startObject;

		private static readonly global::Google.Protobuf.JsonToken endObject;

		private static readonly global::Google.Protobuf.JsonToken startArray;

		private static readonly global::Google.Protobuf.JsonToken endArray;

		private static readonly global::Google.Protobuf.JsonToken endDocument;

		private readonly global::Google.Protobuf.JsonToken.TokenType type;

		private readonly string stringValue;

		private readonly double numberValue;

		internal static global::Google.Protobuf.JsonToken Null => null;

		internal static global::Google.Protobuf.JsonToken False => null;

		internal static global::Google.Protobuf.JsonToken True => null;

		internal static global::Google.Protobuf.JsonToken StartObject => null;

		internal static global::Google.Protobuf.JsonToken EndObject => null;

		internal static global::Google.Protobuf.JsonToken StartArray => null;

		internal static global::Google.Protobuf.JsonToken EndArray => null;

		internal static global::Google.Protobuf.JsonToken EndDocument => null;

		internal global::Google.Protobuf.JsonToken.TokenType Type => global::Google.Protobuf.JsonToken.TokenType.Null;

		internal string StringValue => null;

		internal double NumberValue => 0.0;

		internal static global::Google.Protobuf.JsonToken Name(string name)
		{
			return null;
		}

		internal static global::Google.Protobuf.JsonToken Value(string value)
		{
			return null;
		}

		internal static global::Google.Protobuf.JsonToken Value(double value)
		{
			return null;
		}

		private JsonToken(global::Google.Protobuf.JsonToken.TokenType type, string stringValue = null, double numberValue = 0.0)
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		public bool Equals(global::Google.Protobuf.JsonToken other)
		{
			return false;
		}
	}
}

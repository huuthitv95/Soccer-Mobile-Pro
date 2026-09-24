namespace LitJson
{
	public class JsonException : global::System.ApplicationException
	{
		public JsonException()
		{
		}

		internal JsonException(global::LitJson.ParserToken token)
		{
		}

		internal JsonException(global::LitJson.ParserToken token, global::System.Exception inner_exception)
		{
		}

		internal JsonException(int c)
		{
		}

		internal JsonException(int c, global::System.Exception inner_exception)
		{
		}

		public JsonException(string message)
		{
		}

		public JsonException(string message, global::System.Exception inner_exception)
		{
		}
	}
}

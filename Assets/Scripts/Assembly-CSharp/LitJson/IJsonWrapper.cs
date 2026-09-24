namespace LitJson
{
	public interface IJsonWrapper : global::System.Collections.IList, global::System.Collections.ICollection, global::System.Collections.IEnumerable, global::System.Collections.Specialized.IOrderedDictionary, global::System.Collections.IDictionary
	{
		bool IsArray { get; }

		bool IsBoolean { get; }

		bool IsDouble { get; }

		bool IsInt { get; }

		bool IsLong { get; }

		bool IsObject { get; }

		bool IsString { get; }

		bool GetBoolean();

		double GetDouble();

		int GetInt();

		global::LitJson.JsonType GetJsonType();

		long GetLong();

		string GetString();

		void SetBoolean(bool val);

		void SetDouble(double val);

		void SetInt(int val);

		void SetJsonType(global::LitJson.JsonType type);

		void SetLong(long val);

		void SetString(string val);

		string ToJson();

		void ToJson(global::LitJson.JsonWriter writer);
	}
}

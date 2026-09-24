namespace LitJson
{
	internal delegate void ExporterFunc(object obj, global::LitJson.JsonWriter writer);
	public delegate void ExporterFunc<T>(T obj, global::LitJson.JsonWriter writer);
}

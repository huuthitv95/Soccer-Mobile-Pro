namespace LitJson
{
    public class JsonMapper
    {
        private static readonly int max_nesting_depth;
        private static readonly global::System.IFormatProvider datetime_format;
        private static readonly global::System.Collections.Generic.IDictionary<global::System.Type, global::LitJson.ExporterFunc> base_exporters_table;
        private static readonly global::System.Collections.Generic.IDictionary<global::System.Type, global::LitJson.ExporterFunc> custom_exporters_table;
        private static readonly global::System.Collections.Generic.IDictionary<global::System.Type, global::System.Collections.Generic.IDictionary<global::System.Type, global::LitJson.ImporterFunc>> base_importers_table;
        private static readonly global::System.Collections.Generic.IDictionary<global::System.Type, global::System.Collections.Generic.IDictionary<global::System.Type, global::LitJson.ImporterFunc>> custom_importers_table;
        private static readonly global::System.Collections.Generic.IDictionary<global::System.Type, global::LitJson.ArrayMetadata> array_metadata;
        private static readonly object array_metadata_lock;
        private static readonly global::System.Collections.Generic.IDictionary<global::System.Type, global::System.Collections.Generic.IDictionary<global::System.Type, global::System.Reflection.MethodInfo>> conv_ops;
        private static readonly object conv_ops_lock;
        private static readonly global::System.Collections.Generic.IDictionary<global::System.Type, global::LitJson.ObjectMetadata> object_metadata;
        private static readonly object object_metadata_lock;
        private static readonly global::System.Collections.Generic.IDictionary<global::System.Type, global::System.Collections.Generic.IList<global::LitJson.PropertyMetadata>> type_properties;
        private static readonly object type_properties_lock;
        private static readonly global::LitJson.JsonWriter static_writer;
        private static readonly object static_writer_lock;
        static JsonMapper()
        {
        }

        private static void AddArrayMetadata(global::System.Type type)
        {
        }

        private static void AddObjectMetadata(global::System.Type type)
        {
        }

        private static void AddTypeProperties(global::System.Type type)
        {
        }

        private static global::System.Reflection.MethodInfo GetConvOp(global::System.Type t1, global::System.Type t2)
        {
            return null;
        }

        private static object ReadValue(global::System.Type inst_type, global::LitJson.JsonReader reader)
        {
            return null;
        }

        private static global::LitJson.IJsonWrapper ReadValue(global::LitJson.WrapperFactory factory, global::LitJson.JsonReader reader)
        {
            return null;
        }

        private static void ReadSkip(global::LitJson.JsonReader reader)
        {
        }

        private static void RegisterBaseExporters()
        {
        }

        private static void RegisterBaseImporters()
        {
        }

        private static void RegisterImporter(global::System.Collections.Generic.IDictionary<global::System.Type, global::System.Collections.Generic.IDictionary<global::System.Type, global::LitJson.ImporterFunc>> table, global::System.Type json_type, global::System.Type value_type, global::LitJson.ImporterFunc importer)
        {
        }

        private static void WriteValue(object obj, global::LitJson.JsonWriter writer, bool writer_is_private, int depth)
        {
        }

        public static string ToJson(object obj)
        {
            return null;
        }

        public static void ToJson(object obj, global::LitJson.JsonWriter writer)
        {
        }

        public static global::LitJson.JsonData ToObject(global::LitJson.JsonReader reader)
        {
            return null;
        }

        public static global::LitJson.JsonData ToObject(global::System.IO.TextReader reader)
        {
            return null;
        }

        public static global::LitJson.JsonData ToObject(string json)
        {
            return null;
        }

        public static T ToObject<T>(global::LitJson.JsonReader reader)
        {
            return default;
        }

        public static T ToObject<T>(global::System.IO.TextReader reader)
        {
            return default;
        }

        public static T ToObject<T>(string json)
        {
            return default;
        }

        public static object ToObject(string json, global::System.Type ConvertType)
        {
            return null;
        }

        public static global::LitJson.IJsonWrapper ToWrapper(global::LitJson.WrapperFactory factory, global::LitJson.JsonReader reader)
        {
            return null;
        }

        public static global::LitJson.IJsonWrapper ToWrapper(global::LitJson.WrapperFactory factory, string json)
        {
            return null;
        }

        public static void RegisterExporter<T>(global::LitJson.ExporterFunc<T> exporter)
        {
        }

        public static void RegisterImporter<TJson, TValue>(global::LitJson.ImporterFunc<TJson, TValue> importer)
        {
        }

        public static void UnregisterExporters()
        {
        }

        public static void UnregisterImporters()
        {
        }
    }
}
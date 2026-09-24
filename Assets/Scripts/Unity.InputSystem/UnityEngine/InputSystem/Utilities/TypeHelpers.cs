namespace UnityEngine.InputSystem.Utilities
{
	internal static class TypeHelpers
	{
		public static TObject As<TObject>(this object obj)
		{
			return default;
		}

		public static bool IsInt(this global::System.TypeCode type)
		{
			return false;
		}

		public static global::System.Type GetValueType(global::System.Reflection.MemberInfo member)
		{
			return null;
		}

		public static string GetNiceTypeName(this global::System.Type type)
		{
			return null;
		}

		public static global::System.Type GetGenericTypeArgumentFromHierarchy(global::System.Type type, global::System.Type genericTypeDefinition, int argumentIndex)
		{
			return null;
		}
	}
}

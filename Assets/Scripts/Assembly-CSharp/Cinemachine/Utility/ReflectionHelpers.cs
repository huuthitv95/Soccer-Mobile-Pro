namespace Cinemachine.Utility
{
    public static class ReflectionHelpers
    {
        public static void CopyFields(object src, object dst, global::System.Reflection.BindingFlags bindingAttr = global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic)
        {
        }

        public static T AccessInternalField<T>(this global::System.Type type, object obj, string memberName)
        {
            return default;
        }

        public static object GetParentObject(string path, object obj)
        {
            return null;
        }

        public static string GetFieldPath<TType, TValue>(global::System.Linq.Expressions.Expression<global::System.Func<TType, TValue>> expr)
        {
            return null;
        }
    }
}
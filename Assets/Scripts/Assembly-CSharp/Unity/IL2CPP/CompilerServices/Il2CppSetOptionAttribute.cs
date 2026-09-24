namespace Unity.IL2CPP.CompilerServices
{
	public class Il2CppSetOptionAttribute : global::System.Attribute
	{
		public global::Unity.IL2CPP.CompilerServices.Option Option { get; private set; }

		public object Value { get; private set; }

		public Il2CppSetOptionAttribute(global::Unity.IL2CPP.CompilerServices.Option option, object value)
		{
		}
	}
}

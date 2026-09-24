namespace FLTest.GlobalConfig
{
	public sealed class MethodBindingAttribute : global::System.Attribute
	{
		public string DisplayName { get; }

		public string StateCheckFuncName { get; }

		public string BindingFuncName { get; }

		public string ValueFieldName { get; }

		public string DisabledText { get; }

		public MethodBindingAttribute(string displayName = null, string stateCheckFuncName = null, string bindingFuncName = null, string valueFieldName = null, string disabledText = null)
		{
		}
	}
}

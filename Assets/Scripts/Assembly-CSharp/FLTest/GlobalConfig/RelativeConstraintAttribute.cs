namespace FLTest.GlobalConfig
{
	public sealed class RelativeConstraintAttribute : global::System.Attribute
	{
		public string OtherField { get; }

		public global::FLTest.GlobalConfig.RelativeOp Op { get; }

		public bool AutoClamp { get; }

		public RelativeConstraintAttribute(string otherField, global::FLTest.GlobalConfig.RelativeOp op, bool autoClamp = true)
		{
		}
	}
}

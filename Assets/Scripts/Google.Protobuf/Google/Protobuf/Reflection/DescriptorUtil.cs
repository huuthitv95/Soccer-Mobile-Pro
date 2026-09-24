namespace Google.Protobuf.Reflection
{
	internal static class DescriptorUtil
	{
		internal delegate TOutput IndexedConverter<TInput, TOutput>(TInput element, int index);

		internal static global::System.Collections.Generic.IList<TOutput> ConvertAndMakeReadOnly<TInput, TOutput>(global::System.Collections.Generic.IList<TInput> input, global::Google.Protobuf.Reflection.DescriptorUtil.IndexedConverter<TInput, TOutput> converter)
		{
			return null;
		}
	}
}

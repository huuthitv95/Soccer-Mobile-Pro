namespace Google.Protobuf
{
	public interface IMessage
	{
		global::Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }

		void MergeFrom(global::Google.Protobuf.CodedInputStream input);

		void WriteTo(global::Google.Protobuf.CodedOutputStream output);

		int CalculateSize();
	}
	public interface IMessage<T> : global::Google.Protobuf.IMessage, global::System.IEquatable<T>, global::Google.Protobuf.IDeepCloneable<T> where T : global::Google.Protobuf.IMessage<T>
	{
	}
}

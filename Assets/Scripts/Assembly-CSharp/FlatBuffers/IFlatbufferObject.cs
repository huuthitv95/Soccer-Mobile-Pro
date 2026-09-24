namespace FlatBuffers
{
	public interface IFlatbufferObject
	{
		global::FlatBuffers.ByteBuffer ByteBuffer { get; }

		void __init(int _i, global::FlatBuffers.ByteBuffer _bb);
	}
}

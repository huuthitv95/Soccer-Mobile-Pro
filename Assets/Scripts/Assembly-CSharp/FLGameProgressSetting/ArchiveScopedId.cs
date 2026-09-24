namespace FLGameProgressSetting
{
	internal readonly struct ArchiveScopedId : global::System.IEquatable<global::FLGameProgressSetting.ArchiveScopedId>
	{
		internal int Scope { get; }

		internal int Id { get; }

		internal ArchiveScopedId(int scope, int id)
		{
			Scope = 0;
			Id = 0;
		}

		public bool Equals(global::FLGameProgressSetting.ArchiveScopedId other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}

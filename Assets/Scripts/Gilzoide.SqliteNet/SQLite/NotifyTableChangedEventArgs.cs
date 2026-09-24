namespace SQLite
{
	public class NotifyTableChangedEventArgs : global::System.EventArgs
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::SQLite.TableMapping Table__BackingField;

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::SQLite.NotifyTableChangedAction Action__BackingField;

		private global::SQLite.TableMapping Table
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				Table__BackingField = value;
			}
		}

		private global::SQLite.NotifyTableChangedAction Action
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				Action__BackingField = value;
			}
		}

		public NotifyTableChangedEventArgs(global::SQLite.TableMapping table, global::SQLite.NotifyTableChangedAction action)
		{
		}
	}
}

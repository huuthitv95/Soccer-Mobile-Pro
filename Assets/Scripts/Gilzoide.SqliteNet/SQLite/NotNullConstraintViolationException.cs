namespace SQLite
{
	public class NotNullConstraintViolationException : global::SQLite.SQLiteException
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.IEnumerable<global::SQLite.TableMapping.Column> Columns__BackingField;

		protected global::System.Collections.Generic.IEnumerable<global::SQLite.TableMapping.Column> Columns
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				Columns__BackingField = value;
			}
		}

		protected NotNullConstraintViolationException(global::SQLite.SQLite3.Result r, string message)
			: base(global::SQLite.SQLite3.Result.OK, null)
		{
		}

		protected NotNullConstraintViolationException(global::SQLite.SQLite3.Result r, string message, global::SQLite.TableMapping mapping, object obj)
			: base(global::SQLite.SQLite3.Result.OK, null)
		{
		}

		public new static global::SQLite.NotNullConstraintViolationException New(global::SQLite.SQLite3.Result r, string message)
		{
			return null;
		}

		public static global::SQLite.NotNullConstraintViolationException New(global::SQLite.SQLite3.Result r, string message, global::SQLite.TableMapping mapping, object obj)
		{
			return null;
		}
	}
}

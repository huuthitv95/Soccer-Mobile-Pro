namespace SQLite
{
	public static class SQLite3
	{
		public enum Result
		{
			OK = 0,
			Error = 1,
			Internal = 2,
			Perm = 3,
			Abort = 4,
			Busy = 5,
			Locked = 6,
			NoMem = 7,
			ReadOnly = 8,
			Interrupt = 9,
			IOError = 10,
			Corrupt = 11,
			NotFound = 12,
			Full = 13,
			CannotOpen = 14,
			LockErr = 15,
			Empty = 16,
			SchemaChngd = 17,
			TooBig = 18,
			Constraint = 19,
			Mismatch = 20,
			Misuse = 21,
			NotImplementedLFS = 22,
			AccessDenied = 23,
			Format = 24,
			Range = 25,
			NonDBFile = 26,
			Notice = 27,
			Warning = 28,
			Row = 100,
			Done = 101
		}

		public enum ExtendedResult
		{
			IOErrorRead = 266,
			IOErrorShortRead = 522,
			IOErrorWrite = 778,
			IOErrorFsync = 1034,
			IOErrorDirFSync = 1290,
			IOErrorTruncate = 1546,
			IOErrorFStat = 1802,
			IOErrorUnlock = 2058,
			IOErrorRdlock = 2314,
			IOErrorDelete = 2570,
			IOErrorBlocked = 2826,
			IOErrorNoMem = 3082,
			IOErrorAccess = 3338,
			IOErrorCheckReservedLock = 3594,
			IOErrorLock = 3850,
			IOErrorClose = 4106,
			IOErrorDirClose = 4362,
			IOErrorSHMOpen = 4618,
			IOErrorSHMSize = 4874,
			IOErrorSHMLock = 5130,
			IOErrorSHMMap = 5386,
			IOErrorSeek = 5642,
			IOErrorDeleteNoEnt = 5898,
			IOErrorMMap = 6154,
			LockedSharedcache = 262,
			BusyRecovery = 261,
			CannottOpenNoTempDir = 270,
			CannotOpenIsDir = 526,
			CannotOpenFullPath = 782,
			CorruptVTab = 267,
			ReadonlyRecovery = 264,
			ReadonlyCannotLock = 520,
			ReadonlyRollback = 776,
			AbortRollback = 516,
			ConstraintCheck = 275,
			ConstraintCommitHook = 531,
			ConstraintForeignKey = 787,
			ConstraintFunction = 1043,
			ConstraintNotNull = 1299,
			ConstraintPrimaryKey = 1555,
			ConstraintTrigger = 1811,
			ConstraintUnique = 2067,
			ConstraintVTab = 2323,
			NoticeRecoverWAL = 283,
			NoticeRecoverRollback = 539
		}

		public enum ColType
		{
			Integer = 1,
			Float = 2,
			Text = 3,
			Blob = 4,
			Null = 5
		}

		[global::System.Runtime.InteropServices.PreserveSig]
		public static extern global::SQLite.SQLite3.Result Open(byte[] filename, out global::System.IntPtr db, int flags, string zvfs);

		[global::System.Runtime.InteropServices.PreserveSig]
		public static extern global::SQLite.SQLite3.Result Close(global::System.IntPtr db);

		[global::System.Runtime.InteropServices.PreserveSig]
		public static extern global::SQLite.SQLite3.Result Close2(global::System.IntPtr db);

		[global::System.Runtime.InteropServices.PreserveSig]
		public static extern int SystemErrno(global::System.IntPtr db);

		[global::System.Runtime.InteropServices.PreserveSig]
		public static extern global::SQLite.SQLite3.Result BusyTimeout(global::System.IntPtr db, int milliseconds);

		[global::System.Runtime.InteropServices.PreserveSig]
		public static extern int Changes(global::System.IntPtr db);

		[global::System.Runtime.InteropServices.PreserveSig]
		public static extern global::SQLite.SQLite3.Result Prepare2(global::System.IntPtr db, string sql, int numBytes, out global::System.IntPtr stmt, global::System.IntPtr pzTail);

		public static global::System.IntPtr Prepare2(global::System.IntPtr db, string query)
		{
			return (global::System.IntPtr)0;
		}

		[global::System.Runtime.InteropServices.PreserveSig]
		public static extern global::SQLite.SQLite3.Result Step(global::System.IntPtr stmt);

		[global::System.Runtime.InteropServices.PreserveSig]
		public static extern global::SQLite.SQLite3.Result Reset(global::System.IntPtr stmt);

		[global::System.Runtime.InteropServices.PreserveSig]
		public static extern global::SQLite.SQLite3.Result Finalize(global::System.IntPtr stmt);

		[global::System.Runtime.InteropServices.PreserveSig]
		public static extern long LastInsertRowid(global::System.IntPtr db);

		[global::System.Runtime.InteropServices.PreserveSig]
		public static extern global::System.IntPtr Errmsg(global::System.IntPtr db);

		public static string GetErrmsg(global::System.IntPtr db)
		{
			return null;
		}

		[global::System.Runtime.InteropServices.PreserveSig]
		public static extern int BindParameterIndex(global::System.IntPtr stmt, string name);

		[global::System.Runtime.InteropServices.PreserveSig]
		public static extern int BindNull(global::System.IntPtr stmt, int index);

		[global::System.Runtime.InteropServices.PreserveSig]
		public static extern int BindInt(global::System.IntPtr stmt, int index, int val);

		[global::System.Runtime.InteropServices.PreserveSig]
		public static extern int BindInt64(global::System.IntPtr stmt, int index, long val);

		[global::System.Runtime.InteropServices.PreserveSig]
		public static extern int BindDouble(global::System.IntPtr stmt, int index, double val);

		[global::System.Runtime.InteropServices.PreserveSig]
		public static extern int BindText(global::System.IntPtr stmt, int index, string val, int n, global::System.IntPtr free);

		[global::System.Runtime.InteropServices.PreserveSig]
		public static extern int BindBlob(global::System.IntPtr stmt, int index, byte[] val, int n, global::System.IntPtr free);

		[global::System.Runtime.InteropServices.PreserveSig]
		public static extern int ColumnCount(global::System.IntPtr stmt);

		[global::System.Runtime.InteropServices.PreserveSig]
		private static extern global::System.IntPtr ColumnName16Internal(global::System.IntPtr stmt, int index);

		public static string ColumnName16(global::System.IntPtr stmt, int index)
		{
			return null;
		}

		[global::System.Runtime.InteropServices.PreserveSig]
		public static extern global::SQLite.SQLite3.ColType ColumnType(global::System.IntPtr stmt, int index);

		[global::System.Runtime.InteropServices.PreserveSig]
		public static extern int ColumnInt(global::System.IntPtr stmt, int index);

		[global::System.Runtime.InteropServices.PreserveSig]
		public static extern long ColumnInt64(global::System.IntPtr stmt, int index);

		[global::System.Runtime.InteropServices.PreserveSig]
		public static extern double ColumnDouble(global::System.IntPtr stmt, int index);

		[global::System.Runtime.InteropServices.PreserveSig]
		public static extern global::System.IntPtr ColumnText16(global::System.IntPtr stmt, int index);

		[global::System.Runtime.InteropServices.PreserveSig]
		public static extern global::System.IntPtr ColumnBlob(global::System.IntPtr stmt, int index);

		[global::System.Runtime.InteropServices.PreserveSig]
		public static extern int ColumnBytes(global::System.IntPtr stmt, int index);

		public static string ColumnString(global::System.IntPtr stmt, int index)
		{
			return null;
		}

		public static byte[] ColumnByteArray(global::System.IntPtr stmt, int index)
		{
			return null;
		}

		[global::System.Runtime.InteropServices.PreserveSig]
		public static extern global::SQLite.SQLite3.ExtendedResult ExtendedErrCode(global::System.IntPtr db);

		[global::System.Runtime.InteropServices.PreserveSig]
		public static extern int LibVersionNumber();
	}
}

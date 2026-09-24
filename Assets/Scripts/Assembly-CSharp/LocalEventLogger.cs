public static class LocalEventLogger
{
    private struct EventEntry
    {
        public string EventName;
        public string CsvLine;
    }

    private static readonly global::System.Collections.Generic.Queue<LocalEventLogger.EventEntry> s_queue;
    private static readonly object s_queueLock;
    private static global::System.Threading.Thread s_workerThread;
    private static bool s_isRunning;
    private static string s_tempDir;
    private static string s_exportDir;
    private static readonly global::System.Collections.Generic.Dictionary<string, string[]> s_eventParamNames;
    private static readonly long s_unixEpochTicks;
    private static readonly global::System.Text.StringBuilder logSB;
    private static readonly char[] _csvSpecialChars;
    public static void Initialize()
    {
    }

    public static void Shutdown()
    {
    }

    public static void Log(string eventName, string[] paramNames, string[] paramValues)
    {
    }

    public static void Flush()
    {
    }

    public static void Export()
    {
    }

    public static void Export(string eventName)
    {
    }

    private static void Export(string eventName, string timeSuffix)
    {
    }

    private static void WorkerLoop()
    {
    }

    private static void WriteEntry(LocalEventLogger.EventEntry entry)
    {
    }

    private static string[] SplitCsvLine(string line)
    {
        return null;
    }

    private static string EscapeCsvField(string field)
    {
        return null;
    }
}
public static class AtomicSave
{
    private sealed class Candidate
    {
        public readonly string Path;
        public readonly byte[] Data;
        public readonly long Sequence;
        public readonly long WriteTicks;
        public Candidate(string path, byte[] data, long sequence, long writeTicks)
        {
        }
    }

    private const int EnvelopeMagic = 827151425;
    private const int EnvelopeVersion = 1;
    private const int EnvelopeHashLength = 32;
    private const int MaxEnvelopePayloadLength = 67108864;
    private const int RawSequenceMagic = 827409747;
    private const int RawSequenceVersion = 1;
    private static readonly object IoLock;
    public static string GetTempPath(string primaryPath)
    {
        return null;
    }

    public static void Write(string primaryPath, string backupPath, byte[] data, global::System.Func<byte[], bool> validator = null)
    {
    }

    public static void Write(string primaryPath, string backupPath, byte[] data, int offset, int count, global::System.Func<byte[], bool> validator = null)
    {
    }

    public static void WriteMirrored(string primaryPath, string backupPath, byte[] data, global::System.Func<byte[], bool> validator = null)
    {
    }

    public static void WriteMirrored(string primaryPath, string backupPath, byte[] data, int offset, int count, global::System.Func<byte[], bool> validator = null)
    {
    }

    public static bool TryReadNewest(string primaryPath, string backupPath, global::System.Func<byte[], bool> validator, global::System.Func<byte[], long> sequenceReader, out byte[] data, out string sourcePath)
    {
        data = null;
        sourcePath = null;
        return false;
    }

    public static void WriteSequenced(string primaryPath, string backupPath, long sequence, byte[] payload)
    {
    }

    public static void WriteSequencedMirrored(string primaryPath, string backupPath, long sequence, byte[] payload)
    {
    }

    public static bool TryReadNewestSequenced(string primaryPath, string backupPath, out long sequence, out byte[] payload, out string sourcePath)
    {
        sequence = default;
        payload = null;
        sourcePath = null;
        return false;
    }

    public static void FlushToDisk(global::System.IO.FileStream stream)
    {
    }

    public static byte[] ComputeSha256(byte[] data)
    {
        return null;
    }

    public static uint ComputeCrc32(byte[] data)
    {
        return 0u;
    }

    private static void WriteDurably(string path, byte[] data, int offset, int count)
    {
    }

    private static string GetRawSequencePath(string dataPath)
    {
        return null;
    }

    private static long GetNextRawSequence(string primaryPath, string backupPath)
    {
        return 0L;
    }

    private static bool TryFindRawSequence(string primaryPath, string backupPath, byte[] data, out long sequence)
    {
        sequence = default;
        return false;
    }

    private static global::System.Collections.Generic.IEnumerable<string> EnumerateRawSequencePaths(string primaryPath, string backupPath)
    {
        return null;
    }

    private static void WriteRawSequenceFile(string path, long sequence, byte[] data)
    {
    }

    private static bool TryReadRawSequenceFile(string path, out long sequence, out byte[] hash)
    {
        sequence = default;
        hash = null;
        return false;
    }

    private static bool HashesEqual(byte[] left, byte[] right)
    {
        return false;
    }

    private static bool Matches(byte[] expected, int offset, int count, byte[] actual)
    {
        return false;
    }

    private static void ReplacePrimary(string tempPath, string primaryPath, string backupPath)
    {
    }

    private static void MoveReplacing(string sourcePath, string destinationPath)
    {
    }

    private static bool PathsEqual(string left, string right)
    {
        return false;
    }

    private static global::System.Collections.Generic.IEnumerable<string> EnumerateCandidates(string primaryPath, string backupPath)
    {
        return null;
    }

    private static byte[] BuildEnvelope(long sequence, byte[] payload)
    {
        return null;
    }

    private static bool IsValidEnvelope(byte[] envelope)
    {
        return false;
    }

    private static long ReadEnvelopeSequence(byte[] envelope)
    {
        return 0L;
    }

    private static bool TryUnwrapEnvelope(byte[] envelope, out long sequence, out byte[] payload)
    {
        sequence = default;
        payload = null;
        return false;
    }
}
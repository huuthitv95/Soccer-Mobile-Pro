namespace Unity.SharpZipLib.Core
{
    public class FileSystemScanner
    {
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.EventHandler<global::Unity.SharpZipLib.Core.DirectoryEventArgs> m_ProcessDirectory;
        public global::Unity.SharpZipLib.Core.ProcessFileHandler ProcessFile;
        public global::Unity.SharpZipLib.Core.DirectoryFailureHandler DirectoryFailure;
        public global::Unity.SharpZipLib.Core.FileFailureHandler FileFailure;
        private global::Unity.SharpZipLib.Core.IScanFilter fileFilter_;
        private global::Unity.SharpZipLib.Core.IScanFilter directoryFilter_;
        private bool alive_;
        public event global::System.EventHandler<global::Unity.SharpZipLib.Core.DirectoryEventArgs> ProcessDirectory
        {
            [global::System.Runtime.CompilerServices.CompilerGenerated]
            add
            {
            }

            [global::System.Runtime.CompilerServices.CompilerGenerated]
            remove
            {
            }
        }

        public FileSystemScanner(string fileFilter, string directoryFilter)
        {
        }

        private bool OnDirectoryFailure(string directory, global::System.Exception e)
        {
            return false;
        }

        private bool OnFileFailure(string file, global::System.Exception e)
        {
            return false;
        }

        private void OnProcessFile(string file)
        {
        }

        private void OnProcessDirectory(string directory, bool hasMatchingFiles)
        {
        }

        public void Scan(string directory, bool recurse)
        {
        }

        private void ScanDir(string directory, bool recurse)
        {
        }
    }
}
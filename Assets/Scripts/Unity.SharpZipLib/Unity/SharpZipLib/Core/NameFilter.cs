namespace Unity.SharpZipLib.Core
{
    public class NameFilter : global::Unity.SharpZipLib.Core.IScanFilter
    {
        private string filter_;
        private global::System.Collections.Generic.List<global::System.Text.RegularExpressions.Regex> inclusions_;
        private global::System.Collections.Generic.List<global::System.Text.RegularExpressions.Regex> exclusions_;
        public NameFilter(string filter)
        {
        }

        public static string[] SplitQuoted(string original)
        {
            return null;
        }

        public override string ToString()
        {
            return null;
        }

        public bool IsIncluded(string name)
        {
            return false;
        }

        public bool IsExcluded(string name)
        {
            return false;
        }

        public bool IsMatch(string name)
        {
            return false;
        }

        private void Compile()
        {
        }
    }
}
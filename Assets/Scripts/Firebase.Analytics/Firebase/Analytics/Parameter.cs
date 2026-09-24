namespace Firebase.Analytics
{
    public class Parameter : global::System.IDisposable
    {
        internal string Name { get; set; }
        internal object Value { get; set; }

        public Parameter(string parameterName, string parameterValue)
        {
        }

        public Parameter(string parameterName, long parameterValue)
        {
        }

        public Parameter(string parameterName, double parameterValue)
        {
        }

        [global::System.Obsolete]
        public void Dispose()
        {
        }
    }
}
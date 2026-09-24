namespace AdjustSdk
{
    public class AdjustSessionFailure
    {
        public string Adid { get; set; }
        public string Message { get; set; }
        public string Timestamp { get; set; }
        public bool WillRetry { get; set; }
        public global::System.Collections.Generic.Dictionary<string, object> JsonResponse { get; set; }

        public AdjustSessionFailure()
        {
        }

        public AdjustSessionFailure(global::System.Collections.Generic.Dictionary<string, string> sessionFailureDataMap)
        {
        }

        public AdjustSessionFailure(string jsonString)
        {
        }

        public void BuildJsonResponseFromString(string jsonResponseString)
        {
        }

        public string GetJsonResponseAsString()
        {
            return null;
        }
    }
}
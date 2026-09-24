namespace AdjustSdk
{
    public class AdjustEventFailure
    {
        public string Adid { get; set; }
        public string Message { get; set; }
        public string Timestamp { get; set; }
        public string EventToken { get; set; }
        public string CallbackId { get; set; }
        public bool WillRetry { get; set; }
        public global::System.Collections.Generic.Dictionary<string, object> JsonResponse { get; set; }

        public AdjustEventFailure()
        {
        }

        public AdjustEventFailure(global::System.Collections.Generic.Dictionary<string, string> eventFailureDataMap)
        {
        }

        public AdjustEventFailure(string jsonString)
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
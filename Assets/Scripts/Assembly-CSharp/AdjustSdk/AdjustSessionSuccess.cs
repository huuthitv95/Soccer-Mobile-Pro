namespace AdjustSdk
{
    public class AdjustSessionSuccess
    {
        public string Adid { get; set; }
        public string Message { get; set; }
        public string Timestamp { get; set; }
        public global::System.Collections.Generic.Dictionary<string, object> JsonResponse { get; set; }

        public AdjustSessionSuccess()
        {
        }

        public AdjustSessionSuccess(global::System.Collections.Generic.Dictionary<string, string> sessionSuccessDataMap)
        {
        }

        public AdjustSessionSuccess(string jsonString)
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
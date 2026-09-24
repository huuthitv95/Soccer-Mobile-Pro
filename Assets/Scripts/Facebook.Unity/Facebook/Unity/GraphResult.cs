namespace Facebook.Unity
{
    internal class GraphResult : global::Facebook.Unity.ResultBase, global::Facebook.Unity.IGraphResult, global::Facebook.Unity.IResult
    {
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::System.Collections.Generic.IList<object> ResultList__BackingField;
        [global::System.Runtime.CompilerServices.CompilerGenerated]
        private global::UnityEngine.Texture2D Texture__BackingField;
        private global::System.Collections.Generic.IList<object> ResultList
        {
            [global::System.Runtime.CompilerServices.CompilerGenerated]
            set
            {
                ResultList__BackingField = value;
            }
        }

        private global::UnityEngine.Texture2D Texture
        {
            [global::System.Runtime.CompilerServices.CompilerGenerated]
            set
            {
                Texture__BackingField = value;
            }
        }

        internal GraphResult(global::UnityEngine.WWW result) : base(null)
        {
        }

        private void Init(string rawResult)
        {
        }
    }
}
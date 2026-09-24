namespace LitJson
{
    internal class OrderedDictionaryEnumerator : global::System.Collections.IDictionaryEnumerator, global::System.Collections.IEnumerator
    {
        private global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, global::LitJson.JsonData>> list_enumerator;
        public object Current => null;
        public global::System.Collections.DictionaryEntry Entry => default;
        public object Key => null;
        public object Value => null;

        public OrderedDictionaryEnumerator(global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, global::LitJson.JsonData>> enumerator)
        {
        }

        public bool MoveNext()
        {
            return false;
        }

        public void Reset()
        {
        }
    }
}
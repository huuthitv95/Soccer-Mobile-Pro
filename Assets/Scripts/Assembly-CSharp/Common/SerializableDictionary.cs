namespace Common
{
    public class SerializableDictionary<TKey, TValue> : global::System.Collections.Generic.Dictionary<TKey, TValue>, global::UnityEngine.ISerializationCallbackReceiver
    {
        [global::UnityEngine.SerializeField]
        public global::System.Collections.Generic.List<TKey> keys;
        [global::UnityEngine.SerializeField]
        public global::System.Collections.Generic.List<TValue> vals;
        public void OnAfterDeserialize()
        {
        }

        public void OnBeforeSerialize()
        {
        }
    }
}
namespace TMPro
{
    [global::System.Serializable]
    [global::UnityEngine.ExcludeFromPreset]
    public class TMP_StyleSheet : global::UnityEngine.ScriptableObject
    {
        [global::UnityEngine.SerializeField]
        private global::System.Collections.Generic.List<global::TMPro.TMP_Style> m_StyleList;
        private global::System.Collections.Generic.Dictionary<int, global::TMPro.TMP_Style> m_StyleLookupDictionary;
        internal global::System.Collections.Generic.List<global::TMPro.TMP_Style> styles => null;

        private void Reset()
        {
        }

        public global::TMPro.TMP_Style GetStyle(int hashCode)
        {
            return null;
        }

        public global::TMPro.TMP_Style GetStyle(string name)
        {
            return null;
        }

        public void RefreshStyles()
        {
        }

        private void LoadStyleDictionaryInternal()
        {
        }
    }
}
namespace TMPro
{
    [global::System.Serializable]
    public class TMP_Style
    {
        internal static global::TMPro.TMP_Style k_NormalStyle;
        [global::UnityEngine.SerializeField]
        private string m_Name;
        [global::UnityEngine.SerializeField]
        private int m_HashCode;
        [global::UnityEngine.SerializeField]
        private string m_OpeningDefinition;
        [global::UnityEngine.SerializeField]
        private string m_ClosingDefinition;
        [global::UnityEngine.SerializeField]
        private int[] m_OpeningTagArray;
        [global::UnityEngine.SerializeField]
        private int[] m_ClosingTagArray;
        [global::UnityEngine.SerializeField]
        internal uint[] m_OpeningTagUnicodeArray;
        [global::UnityEngine.SerializeField]
        internal uint[] m_ClosingTagUnicodeArray;
        public static global::TMPro.TMP_Style NormalStyle => null;

        public string name
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public int hashCode
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public string styleOpeningDefinition => null;
        public string styleClosingDefinition => null;
        public int[] styleOpeningTagArray => null;
        public int[] styleClosingTagArray => null;

        internal TMP_Style(string styleName, string styleOpeningDefinition, string styleClosingDefinition)
        {
        }

        public void RefreshStyle()
        {
        }
    }
}
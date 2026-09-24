namespace LitJson
{
    public class JsonReader
    {
        private static readonly global::System.Collections.Generic.IDictionary<int, global::System.Collections.Generic.IDictionary<int, int[]>> parse_table;
        private global::System.Collections.Generic.Stack<int> automaton_stack;
        private int current_input;
        private int current_symbol;
        private bool end_of_json;
        private bool end_of_input;
        private global::LitJson.Lexer lexer;
        private bool parser_in_string;
        private bool parser_return;
        private bool read_started;
        private global::System.IO.TextReader reader;
        private bool reader_is_owned;
        private bool skip_non_members;
        private object token_value;
        private global::LitJson.JsonToken token;
        public bool AllowComments
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool AllowSingleQuotedStrings
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool SkipNonMembers
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public bool EndOfInput => false;
        public bool EndOfJson => false;
        public global::LitJson.JsonToken Token => global::LitJson.JsonToken.None;
        public object Value => null;

        static JsonReader()
        {
        }

        public JsonReader(string json_text)
        {
        }

        public JsonReader(global::System.IO.TextReader reader)
        {
        }

        private JsonReader(global::System.IO.TextReader reader, bool owned)
        {
        }

        private static global::System.Collections.Generic.IDictionary<int, global::System.Collections.Generic.IDictionary<int, int[]>> PopulateParseTable()
        {
            return null;
        }

        private static void TableAddCol(global::System.Collections.Generic.IDictionary<int, global::System.Collections.Generic.IDictionary<int, int[]>> parse_table, global::LitJson.ParserToken row, int col, params int[] symbols)
        {
        }

        private static void TableAddRow(global::System.Collections.Generic.IDictionary<int, global::System.Collections.Generic.IDictionary<int, int[]>> parse_table, global::LitJson.ParserToken rule)
        {
        }

        private void ProcessNumber(string number)
        {
        }

        private void ProcessSymbol()
        {
        }

        private bool ReadToken()
        {
            return false;
        }

        public void Close()
        {
        }

        public bool Read()
        {
            return false;
        }
    }
}
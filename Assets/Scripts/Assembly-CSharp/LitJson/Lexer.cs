namespace LitJson
{
    internal class Lexer
    {
        private delegate bool StateHandler(global::LitJson.FsmContext ctx);
        private static readonly int[] fsm_return_table;
        private static readonly global::LitJson.Lexer.StateHandler[] fsm_handler_table;
        private bool allow_comments;
        private bool allow_single_quoted_strings;
        private bool end_of_input;
        private global::LitJson.FsmContext fsm_context;
        private int input_buffer;
        private int input_char;
        private global::System.IO.TextReader reader;
        private int state;
        private global::System.Text.StringBuilder string_buffer;
        private string string_value;
        private int token;
        private int unichar;
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

        public bool EndOfInput => false;
        public int Token => 0;
        public string StringValue => null;

        static Lexer()
        {
        }

        public Lexer(global::System.IO.TextReader reader)
        {
        }

        private static int HexValue(int digit)
        {
            return 0;
        }

        private static void PopulateFsmTables(out global::LitJson.Lexer.StateHandler[] fsm_handler_table, out int[] fsm_return_table)
        {
            fsm_handler_table = null;
            fsm_return_table = null;
        }

        private static char ProcessEscChar(int esc_char)
        {
            return '\0';
        }

        private static bool State1(global::LitJson.FsmContext ctx)
        {
            return false;
        }

        private static bool State2(global::LitJson.FsmContext ctx)
        {
            return false;
        }

        private static bool State3(global::LitJson.FsmContext ctx)
        {
            return false;
        }

        private static bool State4(global::LitJson.FsmContext ctx)
        {
            return false;
        }

        private static bool State5(global::LitJson.FsmContext ctx)
        {
            return false;
        }

        private static bool State6(global::LitJson.FsmContext ctx)
        {
            return false;
        }

        private static bool State7(global::LitJson.FsmContext ctx)
        {
            return false;
        }

        private static bool State8(global::LitJson.FsmContext ctx)
        {
            return false;
        }

        private static bool State9(global::LitJson.FsmContext ctx)
        {
            return false;
        }

        private static bool State10(global::LitJson.FsmContext ctx)
        {
            return false;
        }

        private static bool State11(global::LitJson.FsmContext ctx)
        {
            return false;
        }

        private static bool State12(global::LitJson.FsmContext ctx)
        {
            return false;
        }

        private static bool State13(global::LitJson.FsmContext ctx)
        {
            return false;
        }

        private static bool State14(global::LitJson.FsmContext ctx)
        {
            return false;
        }

        private static bool State15(global::LitJson.FsmContext ctx)
        {
            return false;
        }

        private static bool State16(global::LitJson.FsmContext ctx)
        {
            return false;
        }

        private static bool State17(global::LitJson.FsmContext ctx)
        {
            return false;
        }

        private static bool State18(global::LitJson.FsmContext ctx)
        {
            return false;
        }

        private static bool State19(global::LitJson.FsmContext ctx)
        {
            return false;
        }

        private static bool State20(global::LitJson.FsmContext ctx)
        {
            return false;
        }

        private static bool State21(global::LitJson.FsmContext ctx)
        {
            return false;
        }

        private static bool State22(global::LitJson.FsmContext ctx)
        {
            return false;
        }

        private static bool State23(global::LitJson.FsmContext ctx)
        {
            return false;
        }

        private static bool State24(global::LitJson.FsmContext ctx)
        {
            return false;
        }

        private static bool State25(global::LitJson.FsmContext ctx)
        {
            return false;
        }

        private static bool State26(global::LitJson.FsmContext ctx)
        {
            return false;
        }

        private static bool State27(global::LitJson.FsmContext ctx)
        {
            return false;
        }

        private static bool State28(global::LitJson.FsmContext ctx)
        {
            return false;
        }

        private bool GetChar()
        {
            return false;
        }

        private int NextChar()
        {
            return 0;
        }

        public bool NextToken()
        {
            return false;
        }

        private void UngetChar()
        {
        }
    }
}
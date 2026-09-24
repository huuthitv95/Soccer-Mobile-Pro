namespace Google.Protobuf
{
    internal abstract class JsonTokenizer
    {
        private class JsonReplayTokenizer : global::Google.Protobuf.JsonTokenizer
        {
            private readonly global::System.Collections.Generic.IList<global::Google.Protobuf.JsonToken> tokens;
            private readonly global::Google.Protobuf.JsonTokenizer nextTokenizer;
            private int nextTokenIndex;
            internal JsonReplayTokenizer(global::System.Collections.Generic.IList<global::Google.Protobuf.JsonToken> tokens, global::Google.Protobuf.JsonTokenizer nextTokenizer)
            {
            }

            protected override global::Google.Protobuf.JsonToken NextImpl()
            {
                return null;
            }
        }

        private sealed class JsonTextTokenizer : global::Google.Protobuf.JsonTokenizer
        {
            private enum ContainerType
            {
                Document = 0,
                Object = 1,
                Array = 2
            }

            [global::System.Flags]
            private enum State
            {
                StartOfDocument = 1,
                ExpectedEndOfDocument = 2,
                ReaderExhausted = 4,
                ObjectStart = 8,
                ObjectBeforeColon = 0x10,
                ObjectAfterColon = 0x20,
                ObjectAfterProperty = 0x40,
                ObjectAfterComma = 0x80,
                ArrayStart = 0x100,
                ArrayAfterValue = 0x200,
                ArrayAfterComma = 0x400
            }

            private class PushBackReader
            {
                private readonly global::System.IO.TextReader reader;
                private char? nextChar;
                internal PushBackReader(global::System.IO.TextReader reader)
                {
                }

                internal char? Read()
                {
                    return null;
                }

                internal char ReadOrFail(string messageOnFailure)
                {
                    return '\0';
                }

                internal void PushBack(char c)
                {
                }

                internal global::Google.Protobuf.InvalidJsonException CreateException(string message)
                {
                    return null;
                }
            }

            private static readonly global::Google.Protobuf.JsonTokenizer.JsonTextTokenizer.State ValueStates;
            private readonly global::System.Collections.Generic.Stack<global::Google.Protobuf.JsonTokenizer.JsonTextTokenizer.ContainerType> containerStack;
            private readonly global::Google.Protobuf.JsonTokenizer.JsonTextTokenizer.PushBackReader reader;
            private global::Google.Protobuf.JsonTokenizer.JsonTextTokenizer.State state;
            internal JsonTextTokenizer(global::System.IO.TextReader reader)
            {
            }

            protected override global::Google.Protobuf.JsonToken NextImpl()
            {
                return null;
            }

            private void ValidateState(global::Google.Protobuf.JsonTokenizer.JsonTextTokenizer.State validStates, string errorPrefix)
            {
            }

            private string ReadString()
            {
                return null;
            }

            private char ReadEscapedCharacter()
            {
                return '\0';
            }

            private char ReadUnicodeEscape()
            {
                return '\0';
            }

            private void ConsumeLiteral(string text)
            {
            }

            private double ReadNumber(char initialCharacter)
            {
                return 0.0;
            }

            private char? ReadInt(global::System.Text.StringBuilder builder)
            {
                return null;
            }

            private char? ReadFrac(global::System.Text.StringBuilder builder)
            {
                return null;
            }

            private char? ReadExp(global::System.Text.StringBuilder builder)
            {
                return null;
            }

            private char? ConsumeDigits(global::System.Text.StringBuilder builder, out int count)
            {
                count = default;
                return null;
            }

            private void ValidateAndModifyStateForValue(string errorPrefix)
            {
            }

            private void PopContainer()
            {
            }
        }

        private global::Google.Protobuf.JsonToken bufferedToken;
        internal int ObjectDepth { get; private set; }

        internal static global::Google.Protobuf.JsonTokenizer FromTextReader(global::System.IO.TextReader reader)
        {
            return null;
        }

        internal static global::Google.Protobuf.JsonTokenizer FromReplayedTokens(global::System.Collections.Generic.IList<global::Google.Protobuf.JsonToken> tokens, global::Google.Protobuf.JsonTokenizer continuation)
        {
            return null;
        }

        internal void PushBack(global::Google.Protobuf.JsonToken token)
        {
        }

        internal global::Google.Protobuf.JsonToken Next()
        {
            return null;
        }

        protected abstract global::Google.Protobuf.JsonToken NextImpl();
        internal void SkipValue()
        {
        }
    }
}
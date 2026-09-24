namespace AdjustSdk
{
    public class JSONClass : global::AdjustSdk.JSONNode, global::System.Collections.IEnumerable
    {
        private global::System.Collections.Generic.Dictionary<string, global::AdjustSdk.JSONNode> m_Dict;
        // C# has no syntax for parameterized property 'Item'.
        public override global::AdjustSdk.JSONNode this[string aKey]
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        // C# has no syntax for parameterized property 'Item'.
        public override global::AdjustSdk.JSONNode this[int aIndex]
        {
            get
            {
                return null;
            }

            set
            {
            }
        }

        public override int Count => 0;
        public override global::System.Collections.Generic.IEnumerable<global::AdjustSdk.JSONNode> Childs => null;

        public override void Add(string aKey, global::AdjustSdk.JSONNode aItem)
        {
        }

        public override global::AdjustSdk.JSONNode Remove(string aKey)
        {
            return null;
        }

        public override global::AdjustSdk.JSONNode Remove(int aIndex)
        {
            return null;
        }

        public override global::AdjustSdk.JSONNode Remove(global::AdjustSdk.JSONNode aNode)
        {
            return null;
        }

        public global::System.Collections.IEnumerator GetEnumerator()
        {
            return null;
        }

        public override string ToString()
        {
            return null;
        }

        public override string ToString(string aPrefix)
        {
            return null;
        }

        public override void Serialize(global::System.IO.BinaryWriter aWriter)
        {
        }
    }
}
namespace AdjustSdk
{
    internal class JSONLazyCreator : global::AdjustSdk.JSONNode
    {
        private global::AdjustSdk.JSONNode m_Node;
        private string m_Key;
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

        public override int AsInt
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public override float AsFloat
        {
            get
            {
                return 0f;
            }

            set
            {
            }
        }

        public override double AsDouble
        {
            get
            {
                return 0.0;
            }

            set
            {
            }
        }

        public override bool AsBool
        {
            get
            {
                return false;
            }

            set
            {
            }
        }

        public override global::AdjustSdk.JSONArray AsArray => null;
        public override global::AdjustSdk.JSONClass AsObject => null;

        public JSONLazyCreator(global::AdjustSdk.JSONNode aNode)
        {
        }

        public JSONLazyCreator(global::AdjustSdk.JSONNode aNode, string aKey)
        {
        }

        private void Set(global::AdjustSdk.JSONNode aVal)
        {
        }

        public override void Add(global::AdjustSdk.JSONNode aItem)
        {
        }

        public override void Add(string aKey, global::AdjustSdk.JSONNode aItem)
        {
        }

        public static bool operator ==(global::AdjustSdk.JSONLazyCreator a, object b)
        {
            return false;
        }

        public static bool operator !=(global::AdjustSdk.JSONLazyCreator a, object b)
        {
            return false;
        }

        public override bool Equals(object obj)
        {
            return false;
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public override string ToString()
        {
            return null;
        }

        public override string ToString(string aPrefix)
        {
            return null;
        }
    }
}
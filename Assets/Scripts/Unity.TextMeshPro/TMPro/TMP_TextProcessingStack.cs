namespace TMPro
{
    public struct TMP_TextProcessingStack<T>
    {
        public T[] itemStack;
        public int index;
        private T m_DefaultItem;
        private int m_Capacity;
        private int m_RolloverSize;
        private int m_Count;
        private const int k_DefaultCapacity = 4;
        public int Count => 0;
        public T current => default;

        public int rolloverSize
        {
            get
            {
                return 0;
            }

            set
            {
            }
        }

        public TMP_TextProcessingStack(T[] stack)
        {
            itemStack = null;
            index = 0;
            m_DefaultItem = default;
            m_Capacity = 0;
            m_RolloverSize = 0;
            m_Count = 0;
        }

        public TMP_TextProcessingStack(int capacity)
        {
            itemStack = null;
            index = 0;
            m_DefaultItem = default;
            m_Capacity = 0;
            m_RolloverSize = 0;
            m_Count = 0;
        }

        public TMP_TextProcessingStack(int capacity, int rolloverSize)
        {
            itemStack = null;
            index = 0;
            m_DefaultItem = default;
            m_Capacity = 0;
            m_RolloverSize = 0;
            m_Count = 0;
        }

        internal static void SetDefault(global::TMPro.TMP_TextProcessingStack<T>[] stack, T item)
        {
        }

        public void Clear()
        {
        }

        public void SetDefault(T item)
        {
        }

        public void Add(T item)
        {
        }

        public T Remove()
        {
            return default;
        }

        public void Push(T item)
        {
        }

        public T Pop()
        {
            return default;
        }

        public T Peek()
        {
            return default;
        }

        public T CurrentItem()
        {
            return default;
        }

        public T PreviousItem()
        {
            return default;
        }
    }
}
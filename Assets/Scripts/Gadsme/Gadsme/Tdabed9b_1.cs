namespace Gadsme
{
    internal struct Tdabed9b_1<T>
    {
        private readonly global::System.DateTime DateTime;
        private readonly T Item;
        public global::System.DateTime P1 => get_DateTime();
        public T P2 => get_Item();

        public Tdabed9b_1(T item, global::System.DateTime dateTime)
        {
            this.DateTime = default;
            this.Item = default;
        }

        public global::System.DateTime get_DateTime()
        {
            return this.DateTime;
        }

        public T get_Item()
        {
            return this.Item;
        }
    }
}
namespace TMPro
{
    public class FastAction
    {
        private global::System.Collections.Generic.LinkedList<global::System.Action> delegates;
        private global::System.Collections.Generic.Dictionary<global::System.Action, global::System.Collections.Generic.LinkedListNode<global::System.Action>> lookup;
        public void Add(global::System.Action rhs)
        {
        }

        public void Remove(global::System.Action rhs)
        {
        }

        public void Call()
        {
        }
    }

    public class FastAction<A>
    {
        private global::System.Collections.Generic.LinkedList<global::System.Action<A>> delegates;
        private global::System.Collections.Generic.Dictionary<global::System.Action<A>, global::System.Collections.Generic.LinkedListNode<global::System.Action<A>>> lookup;
        public void Add(global::System.Action<A> rhs)
        {
        }

        public void Remove(global::System.Action<A> rhs)
        {
        }

        public void Call(A a)
        {
        }
    }

    public class FastAction<A, B>
    {
        private global::System.Collections.Generic.LinkedList<global::System.Action<A, B>> delegates;
        private global::System.Collections.Generic.Dictionary<global::System.Action<A, B>, global::System.Collections.Generic.LinkedListNode<global::System.Action<A, B>>> lookup;
        public void Add(global::System.Action<A, B> rhs)
        {
        }

        public void Remove(global::System.Action<A, B> rhs)
        {
        }

        public void Call(A a, B b)
        {
        }
    }

    public class FastAction<A, B, C>
    {
        private global::System.Collections.Generic.LinkedList<global::System.Action<A, B, C>> delegates;
        private global::System.Collections.Generic.Dictionary<global::System.Action<A, B, C>, global::System.Collections.Generic.LinkedListNode<global::System.Action<A, B, C>>> lookup;
        public void Add(global::System.Action<A, B, C> rhs)
        {
        }

        public void Remove(global::System.Action<A, B, C> rhs)
        {
        }

        public void Call(A a, B b, C c)
        {
        }
    }
}
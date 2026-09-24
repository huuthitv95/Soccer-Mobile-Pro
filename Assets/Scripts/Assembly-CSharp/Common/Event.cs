namespace Common
{
    public class Event : global::Common.EventBase
    {
        public void Invoke()
        {
        }

        public static global::Common.Event operator +(global::Common.Event e, global::System.Action action)
        {
            return null;
        }

        public static global::Common.Event operator -(global::Common.Event e, global::System.Action action)
        {
            return null;
        }
    }

    public class Event<T> : global::Common.EventBase
    {
        public bool HaveListener => false;

        public void Invoke(T value)
        {
        }

        public static global::Common.Event<T> operator +(global::Common.Event<T> e, global::System.Action<T> action)
        {
            return null;
        }

        public static global::Common.Event<T> operator -(global::Common.Event<T> e, global::System.Action<T> action)
        {
            return null;
        }
    }

    public class Event<T1, T2> : global::Common.EventBase
    {
        public void Invoke(T1 value1, T2 value2)
        {
        }

        public static global::Common.Event<T1, T2> operator +(global::Common.Event<T1, T2> e, global::System.Action<T1, T2> action)
        {
            return null;
        }

        public static global::Common.Event<T1, T2> operator -(global::Common.Event<T1, T2> e, global::System.Action<T1, T2> action)
        {
            return null;
        }
    }

    public class Event<T1, T2, T3> : global::Common.EventBase
    {
        public void Invoke(T1 value1, T2 value2, T3 value3)
        {
        }

        public static global::Common.Event<T1, T2, T3> operator +(global::Common.Event<T1, T2, T3> e, global::System.Action<T1, T2, T3> action)
        {
            return null;
        }

        public static global::Common.Event<T1, T2, T3> operator -(global::Common.Event<T1, T2, T3> e, global::System.Action<T1, T2, T3> action)
        {
            return null;
        }
    }

    public class Event<T1, T2, T3, T4> : global::Common.EventBase
    {
        public void Invoke(T1 value1, T2 value2, T3 value3, T4 value4)
        {
        }

        public static global::Common.Event<T1, T2, T3, T4> operator +(global::Common.Event<T1, T2, T3, T4> e, global::System.Action<T1, T2, T3, T4> action)
        {
            return null;
        }

        public static global::Common.Event<T1, T2, T3, T4> operator -(global::Common.Event<T1, T2, T3, T4> e, global::System.Action<T1, T2, T3, T4> action)
        {
            return null;
        }
    }
}
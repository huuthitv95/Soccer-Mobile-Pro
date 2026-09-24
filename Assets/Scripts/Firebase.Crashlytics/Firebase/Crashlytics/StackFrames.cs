namespace Firebase.Crashlytics
{
    internal class StackFrames : global::System.IDisposable, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerable<global::Firebase.Crashlytics.FirebaseCrashlyticsFrame>
    {
        public sealed class StackFramesEnumerator : global::System.Collections.IEnumerator, global::System.Collections.Generic.IEnumerator<global::Firebase.Crashlytics.FirebaseCrashlyticsFrame>, global::System.IDisposable
        {
            private global::Firebase.Crashlytics.StackFrames collectionRef;
            private int currentIndex;
            private object currentObject;
            private int currentSize;
            public global::Firebase.Crashlytics.FirebaseCrashlyticsFrame Current => null;

            object global::System.Collections.IEnumerator.Current => global_003A_003ASystem_002ECollections_002EIEnumerator_002Eget_Current();

            public StackFramesEnumerator(global::Firebase.Crashlytics.StackFrames collection)
            {
            }

            private object global_003A_003ASystem_002ECollections_002EIEnumerator_002Eget_Current()
            {
                return null;
            }

            public bool MoveNext()
            {
                return false;
            }

            public void Reset()
            {
            }

            public void Dispose()
            {
            }
        }

        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;
        // C# has no syntax for parameterized property 'Item'.
        public global::Firebase.Crashlytics.FirebaseCrashlyticsFrame this[int index]
        {
            get
            {
                return null;
            }
        }

        public int Count => 0;

        internal StackFrames(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(global::Firebase.Crashlytics.StackFrames obj)
        {
            return default;
        }

        ~StackFrames()
        {
        }

        public void Dispose()
        {
        }

        public virtual void Dispose(bool disposing)
        {
        }

        global::System.Collections.Generic.IEnumerator<global::Firebase.Crashlytics.FirebaseCrashlyticsFrame> global::System.Collections.Generic.IEnumerable<global::Firebase.Crashlytics.FirebaseCrashlyticsFrame>.GetEnumerator()
        {
            return null;
        }

        global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
        {
            return null;
        }

        public StackFrames()
        {
        }

        public void Add(global::Firebase.Crashlytics.FirebaseCrashlyticsFrame x)
        {
        }

        private uint size()
        {
            return 0u;
        }

        private global::Firebase.Crashlytics.FirebaseCrashlyticsFrame getitem(int index)
        {
            return null;
        }
    }
}
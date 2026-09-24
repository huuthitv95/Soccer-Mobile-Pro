namespace Motvin.Collections
{
    public class FastHashSet<T> : global::System.Collections.Generic.ICollection<T>, global::System.Collections.Generic.IEnumerable<T>, global::System.Collections.IEnumerable, global::System.Collections.Generic.IReadOnlyCollection<T>, global::System.Collections.Generic.ISet<T>
    {
        internal enum FoundType
        {
            FoundFirstTime = 0,
            FoundNotFirstTime = 1,
            NotFound = 2
        }

        internal struct TNode
        {
            public int hashOrNextIndexForBlanks;
            public int nextIndex;
            public T item;
            public TNode(T elem, int nextIndex, int hash)
            {
                hashOrNextIndexForBlanks = 0;
                this.nextIndex = 0;
                item = default;
            }
        }

        private class FastHashSetEqualityComparer : global::System.Collections.Generic.IEqualityComparer<global::Motvin.Collections.FastHashSet<T>>
        {
            public bool Equals(global::Motvin.Collections.FastHashSet<T> x, global::Motvin.Collections.FastHashSet<T> y)
            {
                return false;
            }

            public int GetHashCode(global::Motvin.Collections.FastHashSet<T> set)
            {
                return 0;
            }
        }

        private class FastHashSetEnumerator<T2> : global::System.Collections.Generic.IEnumerator<T2>, global::System.Collections.IEnumerator, global::System.IDisposable
        {
            private global::Motvin.Collections.FastHashSet<T2> set;
            private int currentIndex;
            private bool isDisposed;
            private int incrementForEverySetModification;
            public T2 Current => default;

            public ref T2 CurrentRef
            {
                get
                {
                    throw null;
                }
            }

            public bool IsCurrentValid => false;

            object global::System.Collections.IEnumerator.Current => null;

            public FastHashSetEnumerator(global::Motvin.Collections.FastHashSet<T2> set)
            {
            }

            public bool MoveNext()
            {
                return false;
            }

            public void Reset()
            {
            }

            void global::System.IDisposable.Dispose()
            {
            }
        }

        public static class FastHashSetUtil
        {
            public static int GetEqualOrClosestHigherPrime(int n)
            {
                return 0;
            }
        }

        private const int MaxSlotsArraySize = 2147483645;
        private const int InitialArraySize = 8;
        private const int InitialSlotsArraySize = 17;
        private const int NullIndex = 0;
        private const int BlankNextIndexIndicator = int.MaxValue;
        private const int HighBitNotSet = int.MaxValue;
        private const int MarkNextIndexBitMask = int.MinValue;
        private const int MarkNextIndexBitMaskInverted = int.MaxValue;
        private const int LargestPrimeLessThanMaxInt = 2147483629;
        private static readonly int[] bucketsSizeArray;
        private static readonly int[] bucketsSizeArrayForCacheOptimization;
        private const double LoadFactorConst = 0.75;
        private int currentIndexIntoBucketsSizeArray;
        private int bucketsModSize;
        private int incrementForEverySetModification;
        private int resizeBucketsCountThreshold;
        private int count;
        private int nextBlankIndex;
        private int firstBlankAtEndIndex;
        private global::System.Collections.Generic.IEqualityComparer<T> comparer;
        private int[] buckets;
        private global::Motvin.Collections.FastHashSet<T>.TNode[] slots;
        bool global::System.Collections.Generic.ICollection<T>.IsReadOnly => false;
        public global::System.Collections.Generic.IEqualityComparer<T> Comparer => null;
        public int Count => 0;
        public double LoadFactor => 0.0;
        public int ExcessCapacity => 0;
        public int Capacity => 0;
        public int NextCapacityIncreaseSize => 0;
        public int NextCapacityIncreaseAtCount => 0;

        public FastHashSet()
        {
        }

        public FastHashSet(global::System.Collections.Generic.IEnumerable<T> collection)
        {
        }

        public FastHashSet(global::System.Collections.Generic.IEqualityComparer<T> comparer)
        {
        }

        public FastHashSet(int capacity)
        {
        }

        public FastHashSet(global::System.Collections.Generic.IEnumerable<T> collection, global::System.Collections.Generic.IEqualityComparer<T> comparer)
        {
        }

        public FastHashSet(int capacity, global::System.Collections.Generic.IEqualityComparer<T> comparer)
        {
        }

        private void AddInitialUniqueValuesEnumerable(global::System.Collections.Generic.IEnumerable<T> collection)
        {
        }

        private void AddInitialEnumerableWithEnoughCapacity(global::System.Collections.Generic.IEnumerable<T> collection)
        {
        }

        private void AddInitialEnumerable(global::System.Collections.Generic.IEnumerable<T> collection)
        {
        }

        private void SetInitialCapacity(int capacity)
        {
        }

        private void InitHashing(int capacity = -1)
        {
        }

        private void CalcUsedItemsLoadFactorThreshold()
        {
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
        }

        public void CopyTo(T[] array)
        {
        }

        public void CopyTo(T[] array, int arrayIndex, int count)
        {
        }

        public int EnsureCapacity(int capacity)
        {
            return 0;
        }

        private bool CheckForModSizeIncrease()
        {
            return false;
        }

        private int GetNewSlotsArraySizeIncrease(out int oldArraySize)
        {
            oldArraySize = default;
            return 0;
        }

        private int GetNewBucketsArraySize()
        {
            return 0;
        }

        private void IncreaseCapacity(int capacityIncrease = -1)
        {
        }

        private global::Motvin.Collections.FastHashSet<T>.TNode[] IncreaseCapacityNoCopy(int capacityIncrease = -1)
        {
            return null;
        }

        private void ResizeBucketsArrayForward(int newBucketsArraySize)
        {
        }

        private void ResizeBucketsArrayForwardKeepMarks(int newBucketsArraySize)
        {
        }

        public void Clear()
        {
        }

        public void TrimExcess()
        {
        }

        void global::System.Collections.Generic.ICollection<T>.Add(T item)
        {
        }

        public bool Add(in T item)
        {
            return false;
        }

        public bool Add(T item)
        {
            return false;
        }

        private int AddToHashSetIfNotFound(in T item, int hash, out bool isFound)
        {
            isFound = default;
            return 0;
        }

        private int AddToHashSetIfNotFoundAndMark(in T item, int hash)
        {
            return 0;
        }

        public bool Contains(in T item)
        {
            return false;
        }

        public bool Contains(T item)
        {
            return false;
        }

        public bool Remove(T item)
        {
            return false;
        }

        public bool RemoveIf(in T item, global::System.Predicate<T> removeIfPredIsTrue)
        {
            return false;
        }

        public ref T FindOrAdd(in T item, out bool isFound)
        {
            throw null;
        }

        public ref T Find(in T item, out bool isFound)
        {
            throw null;
        }

        public ref T FindAndRemoveIf(in T item, global::System.Predicate<T> removeIfPredIsTrue, out bool isFound, out bool isRemoved)
        {
            throw null;
        }

        private void FindInSlotsArray(in T item, out int foundNodeIndex, out int priorNodeIndex, out int bucketsIndex)
        {
            foundNodeIndex = default;
            priorNodeIndex = default;
            bucketsIndex = default;
        }

        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private bool FindInSlotsArray(in T item, int hash)
        {
            return false;
        }

        private void UnmarkAllNextIndexValues(int maxNodeIndex)
        {
        }

        private void UnmarkAllNextIndexValuesAndRemoveAnyMarkedOrUnmarked(bool removeMarked)
        {
        }

        private global::Motvin.Collections.FastHashSet<T>.FoundType FindInSlotsArrayAndMark(in T item, out int foundNodeIndex)
        {
            foundNodeIndex = default;
            return default;
        }

        public global::System.Collections.Generic.List<global::Motvin.Collections.ChainLevelAndCount> GetChainLevelsCounts(out double avgNodeVisitsPerChain)
        {
            avgNodeVisitsPerChain = default;
            return null;
        }

        public void ReorderChainedNodesToBeAdjacent()
        {
        }

        public bool TryGetValue(T equalValue, out T actualValue)
        {
            actualValue = default;
            return false;
        }

        public void UnionWith(global::System.Collections.Generic.IEnumerable<T> other)
        {
        }

        public void ExceptWith(global::System.Collections.Generic.IEnumerable<T> other)
        {
        }

        public void IntersectWith(global::System.Collections.Generic.IEnumerable<T> other)
        {
        }

        public bool IsProperSubsetOf(global::System.Collections.Generic.IEnumerable<T> other)
        {
            return false;
        }

        public bool IsSubsetOf(global::System.Collections.Generic.IEnumerable<T> other)
        {
            return false;
        }

        public bool IsProperSupersetOf(global::System.Collections.Generic.IEnumerable<T> other)
        {
            return false;
        }

        public bool IsSupersetOf(global::System.Collections.Generic.IEnumerable<T> other)
        {
            return false;
        }

        public bool Overlaps(global::System.Collections.Generic.IEnumerable<T> other)
        {
            return false;
        }

        public bool SetEquals(global::System.Collections.Generic.IEnumerable<T> other)
        {
            return false;
        }

        public void SymmetricExceptWith(global::System.Collections.Generic.IEnumerable<T> other)
        {
        }

        private void RemoveIfNotMarked(in T item)
        {
        }

        public int RemoveWhere(global::System.Predicate<T> match)
        {
            return 0;
        }

        public static global::System.Collections.Generic.IEqualityComparer<global::Motvin.Collections.FastHashSet<T>> CreateSetComparer()
        {
            return null;
        }

        public global::System.Collections.Generic.IEnumerator<T> GetEnumerator()
        {
            return null;
        }

        global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
        {
            return null;
        }
    }
}
public class PairwiseConstraintChecker<T>
    where T : global::System.IComparable<T>, global::System.IEquatable<T>
{
    private global::System.Collections.Generic.HashSet<(T, T)> constrainedPairs;
    public void AddConstraint(T element1, T element2)
    {
    }

    public bool AreElementsConstrained(T element1, T element2)
    {
        return false;
    }

    public bool IsGroupConstrained(global::System.Collections.Generic.List<T> group)
    {
        return false;
    }

    public bool IsGroupConstrained(T[] group)
    {
        return false;
    }

    public bool IsGroupConstrained(T item, T[] group)
    {
        return false;
    }
}
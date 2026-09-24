public class TempField<T>
{
    private T value;
    public T Value => default;

    public void ChangeValue(T v)
    {
    }

    public void UsingTempValue(T v, global::System.Action action)
    {
    }
}
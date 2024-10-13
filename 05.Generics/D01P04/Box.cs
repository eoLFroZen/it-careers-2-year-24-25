namespace D01P04;

public class Box<T>
{
    private T value;

    public Box(T element)
    {
        value = element;
    }

    public override string ToString()
    {
        return $"{typeof(T).FullName}: {value}";
    }
}

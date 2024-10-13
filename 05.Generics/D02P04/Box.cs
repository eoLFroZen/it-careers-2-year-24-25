namespace D02P04;

public class Box<T> : IComparable<Box<T>> where T : IComparable<T>
{
    private T element;

    public Box(T element)
    {
        this.element = element;
    }

    public int CompareTo(Box<T>? other)
    {
        return this.element.CompareTo(other.element);
    }
}

namespace D01P01;

public class Box<T>
{
    private List<T> values;

    public Box()
    {
        values = new List<T>();
    }

    public int Count => values.Count;

    public void Add(T element){
        values.Add(element);
    }

    public T Remove()
    {
        if(Count == 0)
        {
            return default;
        }

        T element = values.Last();
        values.RemoveAt(Count - 1);

        return element;
    }
}

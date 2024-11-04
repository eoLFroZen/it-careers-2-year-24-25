using System.Collections;

namespace D01P01;

public class LibraryIterator<T> : IEnumerator<T>
{
    private int index;
    private List<T> collection;

    public LibraryIterator(List<T> collection)
    {
        this.collection = collection;
        this.Reset();
    }

    public T Current => collection[index];

    object IEnumerator.Current => Current;

    public void Dispose()
    {
        
    }

    public bool MoveNext()
    {
        return ++index < collection.Count;
    }

    public void Reset()
    {
        index = -1;
    }
}

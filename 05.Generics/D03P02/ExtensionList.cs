using System.Text;

namespace D03P02;

public class ExtensionList<T> where T : IComparable<T>
{
    private List<T> data;

    public ExtensionList()
    {
        data = new List<T>();
    }

    public void Add(T element)
    {
        data.Add(element);
    }

    public T Remove(int index)
    {
        T element = data[index];
        data.RemoveAt(index);
        return element;
    }

    public bool Contains(T element)
    {
        return data.Contains(element);
    }

    public void Swap(int index1, int index2)
    {
        T element  = data[index1];
        data[index1] = data[index2];
        data[index2] = element;
    }

    public int CountGreaterThan(T element)
    {
        int count = 0;

        data.ForEach(currentElement => 
        {
            if(currentElement.CompareTo(element)> 0)
            {
                count++;
            }
        });

        return count;
    }

    public T Max()
    {
        return data.Max();
    }

    public T Min()
    {
        return data.Min();
    }

    public string PrintStr()
    {
        StringBuilder stringBuilder = new StringBuilder();

        data.ForEach(element => stringBuilder.AppendLine(element.ToString()));

        return stringBuilder.ToString().TrimEnd();
    }
}

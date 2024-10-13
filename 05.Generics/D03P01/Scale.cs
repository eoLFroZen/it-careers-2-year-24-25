namespace D03P01;

public class Scale<T> where T : IComparable<T>
{
    private T left;
    private T right;

    public Scale(T left, T right)
    {
        this.left = left;
        this.right = right;
    }

    public T GetHeavier()
    {
        int score = left.CompareTo(right);

        if(score > 0)
        {
            return left;
        }
        else if(score < 0)
        {
            return right;
        }
        else 
        {
            return default;
        }
    }
}
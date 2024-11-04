namespace D02P01;

public class BookComparer : IComparer<Book>
{
    public int Compare(Book x, Book y)
    {
        if (x.Title.CompareTo(y.Title) != 0)
        {
            return x.Title.CompareTo(y.Title);
        }

        return y.Year - x.Year;
    }
}

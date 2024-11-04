namespace D02P01;

public class Book : IComparable<Book>
{
    public Book(string title, int year, params string[] authors)
    {
        Title = title;
        Year = year;
        Authors = authors.ToList();
    }

    public string Title { get; set; }
    public int Year { get; set; }
    public List<string> Authors { get; set; }

    public int CompareTo(Book other)
    {
        // if(Title.CompareTo(other.Title) != 0)
        //     return Title.CompareTo(other.Title);

        // return other.Year - Year;

        if (Year != other.Year)
            return Year - other.Year;

        return Title.CompareTo(other.Title);
    }

    public override string ToString()
    {
        return $"{Title} - {Year}";
    }
}

namespace Demo;

public class Book
{
    private int privateField;
    protected int protectedField;
    internal int internalField;
    public int publicField;

    public Book()
    {
    }

    public Book(string title)
    {
        Title = title;
    }

    public string Title { get; set; }
    public int Year { get; set; }
    public List<string> Authors { get; set; }

    public override string ToString()
    {
        return $"{Title}-{Year}{Environment.NewLine}{string.Join(", ", Authors)}";
    }

    private static void Test() 
    {
        System.Console.WriteLine("Test called");
    }
}

namespace D01P01;

using System.Collections;

public class Library : IEnumerable<Book>
{
    private List<Book> books;

    public Library(params Book[] books)
    {
        this.books = books.ToList();
    }

    public IEnumerator<Book> GetEnumerator()
    {
        //Case 1
        return new LibraryIterator<Book>(books);

        //Case 2
        // for (int i = 0; i < books.Count; i++)
        // {
        //     yield return books[i];
        // }

        //Case 3
        // return books.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}

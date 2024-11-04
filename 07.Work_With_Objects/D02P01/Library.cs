namespace D02P01;

using System.Collections;
using System.Collections.Generic;

public class Library : IEnumerable<Book>
{
    private SortedSet<Book> books;

    public Library(IComparer<Book> comparer, params Book[] books)
    {
        this.books = new SortedSet<Book>(books, comparer);
    }

    public IEnumerator<Book> GetEnumerator()
    {
        return books.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}

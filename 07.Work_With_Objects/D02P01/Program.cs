
using System.Text;
using D02P01;

Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
Book bookThree = new Book("The Documents in the Case", 1930);

IComparer<Book> comparer = new BookComparer();

Library libraryTwo = new Library(comparer, bookOne, bookTwo, bookThree); 

foreach (Book book in libraryTwo)
{
    Console.WriteLine(book);
}

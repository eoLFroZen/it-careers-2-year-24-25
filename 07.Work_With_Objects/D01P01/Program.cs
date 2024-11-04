using D01P01;

Book book1 = new Book("Title", 1999, "Gosho", "Pesho" );
Book book2 = new Book("Title2", 1923);

Library library = new Library(book1, book2);

foreach (Book book in library)
{
    Console.WriteLine(book);
}

// Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
// Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
// Book bookThree = new Book("The Documents in the Case", 1930);

// Library libraryOne = new Library();
// Library libraryTwo = new Library(bookOne, bookTwo, bookThree); 


// foreach (Book book in libraryOne)
// {
//     Console.WriteLine(book);
// }

// Console.WriteLine();

// foreach (Book book in libraryTwo)
// {
//     Console.WriteLine(book);
// }
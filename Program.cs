using LibraryPractise.Classes;
namespace LibraryOvning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library bookShelf1 = new Library();

     
            Console.WriteLine("Hello, welcome to the library!");
            Console.WriteLine("Wht do you want to do?");
            bool isInLibrary = true;
            Console.ForegroundColor = ConsoleColor.Green;
            // Prints the menu, could and maybe should be in the while loop
            Console.WriteLine("If you want to add a book type add");
            Console.WriteLine("If you want to see all the books type show");
            Console.WriteLine("If you want to loan a book type loan");
            Console.WriteLine("If you want to return a book type return");
            Console.WriteLine("If you want to search for a book type search");
            Console.WriteLine("If you want to exit the library type anything else");


            while (isInLibrary) // This is a simple while loop that runs the whole program
            {
                var input = Console.ReadLine();
                switch (input.ToLower()) // This switch case checks what the user choose to do
                {

                    case "add": // Adds new books
                        Book book1 = new Book();
                        book1.CreateBook();
                        bookShelf1.AddBooks(book1);
                        break;

                    case "show": // Shows all the books
                        bookShelf1.Showbooks();
                        break;

                    case "loan": // Loans a book or does nothing
                        bookShelf1.LoanBook();
                        break;

                    case "return": // Returns a book or does nothing
                        bookShelf1.ReturnBook();
                        break;

                    case "search": //Searches by author or title, by asking user which one it wants to search by
                        Console.WriteLine("Do you want to search by author or title?");
                        var searchBy = Console.ReadLine();
                        if (searchBy.ToLower() == "title") // This searches by title and prints the book
                        {
                            Console.WriteLine("Please write the title of the book");
                            var searchedTitle = Console.ReadLine();
                            var foundBook = bookShelf1.SearchBookByTitle(searchedTitle);
                            foundBook.PrintInfo();

                        }
                        else if (searchBy.ToLower() == "author") // This searches by author and prints every book with that author
                        {
                            Console.WriteLine("Please write the author of the book");
                            var searchedAuthor = Console.ReadLine();
                            List<Book> foundBooks = new List<Book>();
                            foundBooks = bookShelf1.SearchBookByAuthor(searchedAuthor);
                            foreach (Book book in foundBooks)
                            {
                                book.PrintInfo();
                            }
                        }
                        else // if nothing is choosen it returns to the start
                        {
                            Console.WriteLine("Wrong input");
                            break;
                        }
                        break;
                    default: // Exits the application
                        isInLibrary = false;
                        break;
                }
            }
        }
    }
}

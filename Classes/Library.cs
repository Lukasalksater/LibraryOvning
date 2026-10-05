namespace LibraryPractise.Classes
{
    public class Library
    {
        // Attributes
        public List<Book>? BookShelves = new List<Book>();


        // Methods
        public void AddBooks(params Book[] books) // this adds books to the list bookShelves. This methods thanks ot params accepts multiple books at the same time.
        {
            foreach (Book book in books)
            {
                BookShelves.Add(book); // Adds a book to the list

            }
        }

        public void Showbooks() // This method prints out every book
        {
            foreach (Book book in BookShelves)
            {
                book.PrintInfo();
            }
        }

        public Book SearchBookByTitle(string title) // This method finds a specific book based on its title
        {
            var FoundBook = BookShelves.Find(book => book.Title.ToLower() == title.ToLower()); // Searched for books in the list with the same title
            return FoundBook;
        }
        public List<Book> SearchBookByAuthor(string author) // This method finds all the books with a specifik author
        {
            return BookShelves.FindAll(book => book.Author.ToLower() == author.ToLower()); // this looks for every book with the inputted author and returns it
        } 

        public void LoanBook() // This changes the IsLoaned variable in the book class

        {
            Console.WriteLine("What book do you want to loan?");
            Console.WriteLine("Please enter the title of the book");
            string bookTile = Console.ReadLine();
            var loanedBook = SearchBookByTitle(bookTile);


            if (loanedBook.IsLoaned == true) // checks if book is already loaned
            {
                Console.WriteLine("Sorry this book is already loaned");
            }
            else
            {
                Console.WriteLine($"The {loanedBook.Title} has been loaned");
                loanedBook.IsLoaned = true;
            }
        }

        public void ReturnBook() // This method returns the book which means changing the book variable IsLoaned to false

        {
            Console.WriteLine("What book do you want to return?");
            Console.WriteLine("Please enter the title of the book");
            string bookTile = Console.ReadLine();
            var returnedBook = SearchBookByTitle(bookTile);


            if (returnedBook.IsLoaned == false) // Checks if the book is loaned
            {
                Console.WriteLine("Sorry this book is not loaned and can't be returned");


            }
            else
            {
                returnedBook.IsLoaned = false;
                Console.WriteLine($"{returnedBook.Title} has been returned");
            }
        }
    }
}
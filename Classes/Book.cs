namespace LibraryPractise.Classes
{
    public class Book
    {
        // Attributes
        public string Title { get; set; }
        public string Author { get; set; }

        public int YearPublished { get; set; }

        public bool IsLoaned { get; set; }


        // Method

        public void CreateBook() // This method creates the book
        {
            Console.WriteLine("Please write the title of the book");
            Title = Console.ReadLine();
            Console.WriteLine("Please write the author of the book");
            Author = Console.ReadLine();
            Console.WriteLine("Please write the year the book was published");
            YearPublished = int.Parse(Console.ReadLine());

        }

        public void PrintInfo() // This method prints the information about the book
        {
            Console.WriteLine($"The title is: {Title}, the author is {Author}, and it was publised {YearPublished}");
        }
    }
}


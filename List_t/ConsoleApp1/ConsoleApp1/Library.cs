namespace ZeroToMaster;

public class Library
{
    public string LibraryName { get; set; } = "Library";
    public List<Book> Books = new List<Book>();

    public class Book
    {
        public string BookName { get; set; } = "Book";
        public Book(string bookName) => BookName = bookName;
    }
}

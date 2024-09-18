using Library_Management_System2._0;

internal class Program
{
    private static void Main(string[] args)
    {
        Librarian x = new Librarian();

        //x.DisplayBooks();

        x.BarrowBook(1);

        x.ReturnBook(2);
    }
}
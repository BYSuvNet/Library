//--------------------
// USER INTERFACE OSV
//--------------------

class UI
{
    Library _library;

    public UI(Library library)
    {
        _library = library;
    }

    public void Run()
    {
        while (true)
        {
            Console.Write("Sök: ");
            string searchInput = Console.ReadLine();
            List<Book> searchResult = _library.SearchForBooks(searchInput);

            foreach (var book in searchResult)
            {
                Console.WriteLine(book.Title);
            }
        }
    }
}
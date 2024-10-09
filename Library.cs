class Library
{
    List<Book> _books = [new Book() { Title = "LOTR", Authors = [new Author(){Name = "Tolkien"}] },
                         new Book() { Title = "LOTR 2", Authors = [new Author(){Name = "Tolkien"}]},
                         new Book() { Title = "Bamse", Authors = [new Author(){Name = "Rune"}]}];

    public List<Book> SearchForBooks(string searchInput)
    {
        List<Book> searchResults = new();

        foreach (var book in _books)
        {
            if (book.Contains(searchInput))
            {
                searchResults.Add(book);
            }
        }

        return searchResults;
    }
}

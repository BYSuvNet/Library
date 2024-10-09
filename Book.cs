class Book
{
    public string Title { get; set; }
    public List<Author> Authors { get; set; }

    public bool Contains(string searchInput)
    {
        if (Title.Contains(searchInput, StringComparison.InvariantCultureIgnoreCase))
        {
            return true;
        }

        foreach (var author in Authors)
        {
            if (author.Name.Contains(searchInput, StringComparison.InvariantCultureIgnoreCase))
            {
                return true;
            }
        }

        return false;
    }
}

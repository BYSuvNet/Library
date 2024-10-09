class Program
{
    static void Main()
    {
        Library library = new();
        UI ui = new(library);
        ui.Run();
    }
}

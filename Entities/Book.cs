namespace DesafioBiblioteca.Entities;

public class Book
{
    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Author { get; set; } = string.Empty;

    public string Gender { get; set; } = string.Empty;

    public double Price { get; set; } = 0.0;

    public int Stock { get; set; } = 1;
}

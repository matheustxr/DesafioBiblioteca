namespace DesafioBiblioteca.Entities;

public class Book
{
    public Guid Id { get; private set; } = Guid.NewGuid();

    public string Title { get; set; } = string.Empty;

    public string Gender { get; set; } = string.Empty;

    public double Price { get; set; } = 0.0;

    public int Stock { get; set; } = 1;
}

using DesafioBiblioteca.Entities;
using Microsoft.EntityFrameworkCore;

public class DbBooksContext : DbContext
{
    public DbBooksContext(DbContextOptions<DbBooksContext> options) : base(options) { }

    public DbSet<Book> Books { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>()
            .HasKey(b => b.Id);

        modelBuilder.Entity<Book>()
            .Property(b => b.Id)
            .ValueGeneratedOnAdd();
    }
}

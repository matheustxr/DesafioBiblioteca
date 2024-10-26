using Microsoft.EntityFrameworkCore;
using DesafioBiblioteca.Entities; // Certifique-se de que este namespace está correto

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Registre o DbBooksContext com a string de conexão SQLite
builder.Services.AddDbContext<DbBooksContext>(options =>
    options.UseSqlite("Data Source=db-books.db"));

builder.Services.AddControllers();
// Configuração do Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

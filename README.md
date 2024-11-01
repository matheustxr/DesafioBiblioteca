EN
# Online Bookstore API 📚

This project aims to develop an API for managing an online bookstore, allowing users to create, view, edit, and delete books within the system.

## 🚀 Features

The API offers the following features:

- **Create a book**: Allows the registration of a new book with information such as title, author, genre, price, and stock quantity.
- **View all books**: Displays a list of all books registered in the system.
- **Edit a book**: Allows updating the data of a specific book.
- **Delete a book**: Removes a registered book from the system.

## 📋 Requirements

### 📝 Book Data

A book should include the following fields:

- **id**: Unique identifier for each book (automatically generated).
- **title**: Name of the book.
- **author**: Author of the book.
- **genre**: Literary genre of the book. Examples: `fiction`, `romance`, `mystery`, etc.
- **price**: Sale price of the book.
- **stock quantity**: Number of available units.

### 🔗 Required Endpoints

The API should provide the following endpoints:

1. **POST /livros**: Creates a new book.
2. **GET /livros/{id}**: Returns a specific book.
3. **PUT /livros/{id}**: Updates information of an existing book.
4. **DELETE /livros/{id}**: Deletes a book by its identifier.
5. **GET /livros**: Returns all registered books.

## 🛠️ Technologies Used

- **C#**: Main language of the project.
- **ASP.NET Core**: Framework for building the API.
- **Entity Framework**: ORM for database management.
- **SQLite**: Relational database used to store book information.

## 📦 How to Run the Project

1. Clone this repository:

   ```bash
   git clone https://github.com/usuario/repo-livraria-api.git

2. Navigate to the project folder::

   ```bash
   cd repo-livraria-api

3. Restore dependencies:

   ```bash
   dotnet restore
   
4. Apply database migrations:

   ```bash
   dotnet ef database update
   
5. Run the project:

   ```bash
   dotnet run



PT-Br
# API Livraria Online 📚

Este projeto tem como objetivo desenvolver uma API para gerenciar uma livraria online, permitindo que os usuários criem, visualizem, editem e excluam livros no sistema.

## 🚀 Funcionalidades

A API oferece as seguintes funcionalidades:

- **Criar um livro**: Permite cadastrar um novo livro com as informações de título, autor, gênero, preço e quantidade em estoque.
- **Visualizar todos os livros**: Exibe uma lista de todos os livros cadastrados no sistema.
- **Editar um livro**: Possibilita a alteração dos dados de um livro específico.
- **Excluir um livro**: Remove um livro cadastrado no sistema.

## 📋 Requisitos

### 📝 Dados do Livro

Um livro deve conter os seguintes campos:

- **id**: Identificador único para cada livro (gerado automaticamente).
- **título**: Nome do livro.
- **autor**: Nome do autor do livro.
- **gênero**: Gênero literário do livro. Exemplos: `ficção`, `romance`, `mistério`, etc.
- **preço**: Preço de venda do livro.
- **quantidade em estoque**: Número de unidades disponíveis.

### 🔗 Endpoints Necessários

A API deve disponibilizar os seguintes endpoints:

1. **POST /livros**: Cria um novo livro.
2. **GET /livros/{id}**: Retorna um livro específico.
3. **PUT /livros/{id}**: Atualiza as informações de um livro existente.
4. **DELETE /livros/{id}**: Exclui um livro pelo seu identificador.
5. **GET /livros**: Retorna todos os livros cadastrados.

## 🛠️ Tecnologias Utilizadas

- **C#**: Linguagem principal do projeto.
- **ASP.NET Core**: Framework para construção da API.
- **Entity Framework**: ORM para gerenciamento do banco de dados.
- **SQLite**: Banco de dados relacional utilizado para armazenar as informações dos livros.

## 📦 Como Executar o Projeto

1. Clone este repositório:

   ```bash
   git clone https://github.com/usuario/repo-livraria-api.git

2. Navegue até o diretório do projeto:

   ```bash
   cd repo-livraria-api

3. Restaure os pacotes NuGet:

   ```bash
   dotnet restore
   
4. Execute as migrações para configurar o banco de dados:

   ```bash
   dotnet ef database update
   
5. Inicie a aplicação:

   ```bash
   dotnet run

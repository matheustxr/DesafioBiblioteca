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

2. Clone este repositório:

   ```bash
   cd repo-livraria-api

3. Clone este repositório:

   ```bash
   dotnet restore

3. Clone este repositório:

   ```bash
   dotnet restore
   
4. Clone este repositório:

   ```bash
   dotnet ef database update
   
5. Clone este repositório:

   ```bash
   dotnet run

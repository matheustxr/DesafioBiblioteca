using DesafioBiblioteca.Communication.Requests;
using DesafioBiblioteca.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DesafioBiblioteca.Controllers;

[ApiController]
[Route("[controller]")]
public class BookController : ControllerBase
{
    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(Book), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult GetById ([FromRoute]string id)
    {
        return Ok();
    }

    [HttpPost]
    [ProducesResponseType(typeof(RequestCreateBookJson), StatusCodes.Status201Created)]
    public IActionResult CreateBook ([FromBody] RequestCreateBookJson request)
    {
        var response = new RequestCreateBookJson
        {
            Title = request.Title,
            Gender = request.Gender,
            Price = request.Price,
            Stock = request.Stock,
        };

        return Created(string.Empty, response);
    }



}
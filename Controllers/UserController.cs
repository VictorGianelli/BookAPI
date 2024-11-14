using BookAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(Book), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public IActionResult Get() 
        {
            var book = new Book
            {
                Title = "Livro 1",
                Author = "João",
                Description = "Lorem ipsum",
                MyProperty = 1
            };

            return Ok(book);
        }
    }
}

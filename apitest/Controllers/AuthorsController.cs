using apiTest.Services.AuthorDta;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apitest.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private IauthorRepository _author;
        public AuthorsController(IauthorRepository author)
        {
            _author = author;
        }
        [HttpGet]
        public IActionResult AuthorGet()
        {

            var authors = _author.GetAllAuthors();
            return Ok(authors);
        }

        [HttpGet("{id}")]
        public IActionResult GetauthorById(int id)
        {
            var author = _author.GetAuthorById(id);
            return Ok(author);
        }
    }
}

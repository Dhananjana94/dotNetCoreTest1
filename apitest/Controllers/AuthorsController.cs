using apiTest.Services.AuthorDta;
using apiTest.Services.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.ObjectModel;

namespace apitest.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private IauthorRepository _author;
        private IMapper _mapper;
        public AuthorsController(IauthorRepository author,IMapper mapper)
        {
            _author = author;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult<ICollection<AuthorDto>> AuthorGet()
        {

            var authors = _author.GetAllAuthors();
           // var authorsDto = new List<AuthorDto>();

            //foreach (var author in authors)
            //{
            //    //Normal way to map data
            //    authorsDto.Add(new AuthorDto
            //    {
            //        Id = author.Id,
            //        Name = author.Name,
            //        Address = $"{author.Address},{author.Street},{author.City}"
            //    });
            //}
            var mappedAuthors = _mapper.Map<ICollection<AuthorDto>>(authors);
            return Ok(mappedAuthors);
        }

        [HttpGet("{id}")]
        public IActionResult GetauthorById(int id)
        {
            var author = _author.GetAuthorById(id);
            if(author == null)
            {
                return NotFound();
            }

            var mappedAuthor = _mapper.Map<AuthorDto>(author);
            return Ok(mappedAuthor);
        }
    }
}

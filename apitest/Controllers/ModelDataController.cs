
using apiTest.Models;
using apiTest.Services.Tsts;
using apiTest.Services.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apitest.Controllers
{
    [Route("api/authors/{authorID}/tests")]
    [ApiController]
    public class ModelDataController : ControllerBase
    {
        // private TstService _stService; // this is private attribute it only access inside this class

        private ItstRepository _tstRepository;
        private IMapper _mapper;
        public ModelDataController(ItstRepository repo, IMapper mapper)
        {
            _tstRepository = repo;
            _mapper = mapper;
        }

        //[HttpGet("{id}")]
        //public IActionResult Modelget(int id)
        //{
        //    //TstService obj = new TstService();
        //    var tstModel = _tstRepository.AllTstModels().Where(t => t.Id == id); 
        //    return Ok(tstModel); 
        //}

        [HttpGet]
        public ActionResult<ICollection<TestsDto>>GetAllTest(int authorID)
        {
            var tstMdls = _tstRepository.AllTstModels( authorID);

            var mapTests = _mapper.Map<ICollection<TestsDto>>(tstMdls);
            return Ok(mapTests);
        }

        [HttpGet("{id}")]
        public IActionResult GetTestById(int authorID, int id) { 
            
            var tstMdl = _tstRepository.GetTstById(authorID, id);

            var mapTest = _mapper.Map<TestsDto>(tstMdl);
            return Ok(mapTest);
        }
        
    }
}

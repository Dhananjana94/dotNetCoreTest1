
using apiTest.Services.Tsts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apitest.Controllers
{
    [Route("api/tests")]
    [ApiController]
    public class ModelDataController : ControllerBase
    {
       // private TstService _stService; // this is private attribute it only access inside this class

        private ItstRepository _tstRepository;

        public ModelDataController(ItstRepository repo)
        {
            _tstRepository = repo;
        }

        [HttpGet("{id}")]
        public IActionResult Modelget(int id)
        {
            //TstService obj = new TstService();
            var tstModel = _tstRepository.AllTstModels().Where(t => t.Id == id); 
            return Ok(tstModel); 
        }
        
    }
}

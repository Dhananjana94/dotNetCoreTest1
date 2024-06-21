using apitest.Models;
using apitest.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apitest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelDataController : ControllerBase
    {
        private TstService _stService; // this is private attribute it only access inside this class

        public ModelDataController()
        {
            _stService = new TstService();
        }

        [HttpGet("{id}")]
        public IActionResult Modelget(int id)
        {
            //TstService obj = new TstService();
            var tstModel = _stService.AllTstModels().Where(t => t.Id == id);
            return Ok(tstModel); 
        }
        
    }
}

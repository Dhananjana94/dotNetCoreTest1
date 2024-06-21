 using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace apitest.Controllers
{
    [Route("api/[controller]")]
    [ApiController] //class level attribute
    public class TestsController : ControllerBase
     {
        //action method in api
        [HttpGet]// method level attribute
        public IActionResult tasks()
        {
            //IActionResault can use to return resault as well as status code

            var test = new string[] { "tst1", "tst2", "tst3" };
            return Ok(test);
        }

        [HttpPost]
        public IActionResult TaskPost()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult TaskDelete()
        {
            var Badresault = true;  
            if (Badresault)
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using WebAPI_Endpoint.Models;

namespace WebAPI_Endpoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestApiController : ControllerBase
    {
        // 1. GET: api/testapi/hello
        [HttpGet("hello")]
        public IActionResult GetHello()
        {
            Console.WriteLine("Hello from API!");
            return Ok(new { message = "Hello Hussain Saabri!" });
        }

        // 2. POST: api/testapi/echo
        [HttpPost("echo")]
        public IActionResult Echo([FromBody] object data)
        {
            Console.WriteLine(data);
           
            if (data == null)
            {
                return BadRequest("Data is null");
            }
            return Ok(data);
        }

        // 3. GET: api/testapi/details/{id}
        [HttpGet("details/{id}")]
        public IActionResult GetDetails(int id)
        {
           
            var user = new UserViewModel
            {
                Id = id,
                Name = "Hussain Saabri",
                Email = "hussain@gmail.com",
                Status = "Active"
            };
            return Ok(user);
        }
    }
}

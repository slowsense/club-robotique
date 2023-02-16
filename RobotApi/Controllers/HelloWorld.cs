using Microsoft.AspNetCore.Mvc;

namespace RobotApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorld : ControllerBase
    {
        public HelloWorld()
        {
        }

        [HttpGet]
        public string Get()
        {
            return "Hello";
        }
    }
}
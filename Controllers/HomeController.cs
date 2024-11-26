using Microsoft.AspNetCore.Mvc;

namespace AspNetMVCTodo.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet("/home")]
        public string Get()
        {
            return "Meu nome e Alyson";
        }
    }
}
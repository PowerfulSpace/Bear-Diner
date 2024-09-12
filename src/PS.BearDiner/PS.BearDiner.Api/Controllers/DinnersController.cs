using Microsoft.AspNetCore.Mvc;

namespace PS.BearDiner.Api.Controllers
{
    [Route("[controller]")]
    public class DinnersController : ApiController
    {
        [HttpGet]
        public IActionResult ListDinners()
        {
            var user = HttpContext.User;
            return Ok(Array.Empty<string>());
        }
    }
}

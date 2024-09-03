using Microsoft.AspNetCore.Mvc;

namespace PS.BearDiner.Api.Controllers
{
    public class ErrorsController : ControllerBase
    {
        [Route("/error")]
        public IActionResult Error()
        {
            return Problem();
        }
    }
}

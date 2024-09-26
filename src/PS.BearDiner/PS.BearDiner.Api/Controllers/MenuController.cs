using Microsoft.AspNetCore.Mvc;
using PS.BearDiner.Contracts.Menus;

namespace PS.BearDiner.Api.Controllers
{
    //[Route("hosts/{hostId}/menu")]
    [Route("[controller]")]
    public class MenuController : ApiController
    {
        [HttpPost("{hostId}")]
        public IActionResult CreateMenu([FromBody] CreateMenuRequest request, string hostId)
        {
            return Ok(request);
        }
    }
}

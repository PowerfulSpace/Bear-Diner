using Microsoft.AspNetCore.Mvc;
using PS.BearDiner.Contracts.Menus;

namespace PS.BearDiner.Api.Controllers
{
    //[Route("hosts/{hostId}/menu")]
    [Route("[controller]")]
    public class MenuController : ApiController
    {
        [HttpPost]
        public IActionResult CreateMenu(CreateMenuRequest request, string hostId)
        {
            return Ok();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using PS.BearDiner.Contracts.Menus;

namespace PS.BearDiner.Api.Controllers
{
    [Route("hosts/{hostId}/menu")]
    public class MenuController : ApiController
    {
        public IActionResult CreateMenu(CreateMenuRequest request, string hostId)
        {
            return Ok();
        }
    }
}

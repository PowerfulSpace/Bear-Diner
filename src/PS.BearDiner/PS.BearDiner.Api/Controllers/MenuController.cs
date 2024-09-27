using ErrorOr;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PS.BearDiner.Application.Menus.Commands.CreateMenu;
using PS.BearDiner.Contracts.Menus;
using PS.BearDiner.Domain.Menus;

namespace PS.BearDiner.Api.Controllers
{
    //[Route("hosts/{hostId}/menu")]
    [Route("[controller]")]
    public class MenuController : ApiController
    {
        private readonly ISender _mediator;
        private readonly IMapper _mapper;

        public MenuController(ISender mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpPost("{hostId}")]
        public async Task<IActionResult> CreateMenu([FromBody] CreateMenuRequest request, string hostId)
        {
            CreateMenuCommand command = _mapper.Map<CreateMenuCommand>((request, hostId));

            ErrorOr<Menu> menuResult = await _mediator.Send(command);

            return menuResult.Match(
                menuResult => Ok(_mapper.Map<MenuResponse>(menuResult)),
                errors => Problem(errors));
        }
    }
}

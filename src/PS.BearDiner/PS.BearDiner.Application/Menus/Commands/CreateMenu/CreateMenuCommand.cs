using ErrorOr;
using MediatR;
using PS.BearDiner.Domain.Menus;

namespace PS.BearDiner.Application.Menus.Commands.CreateMenu
{
    public record CreateMenuCommand(
      Guid HostId,
      string Name,
      string Description,
      List<CreateMenuSectionCommand> Sections) :IRequest<ErrorOr<Menu>>;

    public record CreateMenuSectionCommand(
        string Name,
        string Description,
        List<CreateMenuItemCommand> Items);

    public record CreateMenuItemCommand(
        string Name,
        string Description);
}
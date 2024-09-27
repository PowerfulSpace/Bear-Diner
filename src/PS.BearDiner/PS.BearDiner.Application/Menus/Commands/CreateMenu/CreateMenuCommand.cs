using ErrorOr;
using MediatR;
using PS.BearDiner.Domain.Menus;

namespace PS.BearDiner.Application.Menus.Commands.CreateMenu
{
    public record CreateMenuCommand(
      Guid HostId,
      string Name,
      string Description,
      List<MenuSectionCommand> Sections) :IRequest<ErrorOr<Menu>>;

    public record MenuSectionCommand(
        string Name,
        string Description,
        List<MenuItemCommand> Items);

    public record MenuItemCommand(
        string Name,
        string Description);
}
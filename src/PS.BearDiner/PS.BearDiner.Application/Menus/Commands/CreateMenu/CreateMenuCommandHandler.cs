using ErrorOr;
using MediatR;
using PS.BearDiner.Domain.Hosts.ValueObjects;
using PS.BearDiner.Domain.Menus;
using PS.BearDiner.Domain.Menus.Entities;

namespace PS.BearDiner.Application.Menus.Commands.CreateMenu
{
    public class CreateMenuCommandHandler : IRequestHandler<CreateMenuCommand, ErrorOr<Menu>>
    {
        public async Task<ErrorOr<Menu>> Handle(CreateMenuCommand request, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;

            var menu = Menu.Create(
                hostId: HostId.Create(request.HostId),
                name: request.Name,
                description: request.Description,
                sections: request.Sections.ConvertAll(section => MenuSection.Create(
                    section.Name,
                    section.Description,
                    section.Items.ConvertAll(item => MenuItem.Create(
                        item.Name,
                        item.Description)))));

            return default!;
        }
    }
}

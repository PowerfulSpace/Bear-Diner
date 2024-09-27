using ErrorOr;
using MediatR;
using PS.BearDiner.Domain.Menus;

namespace PS.BearDiner.Application.Menus.Commands.CreateMenu
{
    public class CreateMenuCommandHandler : IRequestHandler<CreateMenuCommand, ErrorOr<Menu>>
    {
        public async Task<ErrorOr<Menu>> Handle(CreateMenuCommand request, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;

            var menu = Menu.Create(
                request.HistId,
                request.Name,
                request.Description);

            return default!;
        }
    }
}

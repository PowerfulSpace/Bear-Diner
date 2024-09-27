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

            var menu = Menu.Create()

            return default!;
        }
    }
}

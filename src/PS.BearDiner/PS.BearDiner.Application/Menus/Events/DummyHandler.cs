using MediatR;
using PS.BearDiner.Domain.Menus.Events;

namespace PS.BearDiner.Application.Menus.Events
{
    public class DummyHandler : INotificationHandler<MenuCreated>
    {
        public Task Handle(MenuCreated notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}

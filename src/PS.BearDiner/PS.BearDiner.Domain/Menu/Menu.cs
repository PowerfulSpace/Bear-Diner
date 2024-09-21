using PS.BearDiner.Domain.Common.Models;
using PS.BearDiner.Domain.Dinner.ValueObjects;
using PS.BearDiner.Domain.Host.ValueObjects;
using PS.BearDiner.Domain.Menu.Entities;
using PS.BearDiner.Domain.Menu.ValueObjects;
using PS.BearDiner.Domain.MenuReview.ValueObjects;

namespace PS.BearDiner.Domain.Menu
{
    public sealed class Menu : AggregateRoot<MenuId>
    {
        public string Name { get; }
        public string Description { get; }
        public float AverageRating { get; }

        public HostId HostId { get; }

        private readonly List<MenuSection> _sections = new List<MenuSection>();
        private readonly List<DinnerId> _dinnersIds = new List<DinnerId>();
        private readonly List<MenuReviewId> _menuReviewId = new List<MenuReviewId>();

        public IReadOnlyList<MenuSection> Sections => _sections.AsReadOnly();
        public IReadOnlyList<DinnerId> DinnersIds => _dinnersIds.AsReadOnly();
        public IReadOnlyList<MenuReviewId> MenuReviewIds => _menuReviewId.AsReadOnly();

        public DateTime CreatedDateTime { get; }
        public DateTime UpdatedDateTime { get; }


        private Menu(MenuId menuId, string name, string description, HostId hostId, DateTime createdDateTime, DateTime updatedDateTime)
            : base(menuId)
        {
            Name = name;
            Description = description;
            HostId = hostId;
            CreatedDateTime = createdDateTime;
            UpdatedDateTime = updatedDateTime;
        }

        public static Menu Create(string name, string description, HostId hostId)
        {
            return new(MenuId.CreateUnique(), name, description, hostId, DateTime.UtcNow, DateTime.UtcNow);
        }
    }
}
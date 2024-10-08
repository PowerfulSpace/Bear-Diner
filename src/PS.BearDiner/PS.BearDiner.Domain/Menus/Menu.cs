﻿using PS.BearDiner.Domain.Common.Models;
using PS.BearDiner.Domain.Common.Valueobjects;
using PS.BearDiner.Domain.Dinners.ValueObjects;
using PS.BearDiner.Domain.Hosts.ValueObjects;
using PS.BearDiner.Domain.Menus.Entities;
using PS.BearDiner.Domain.Menus.Events;
using PS.BearDiner.Domain.Menus.ValueObjects;
using PS.BearDiner.Domain.MenuReviews.ValueObjects;

namespace PS.BearDiner.Domain.Menus
{
    public sealed class Menu : AggregateRoot<MenuId, Guid>
    {
        private readonly List<MenuSection> _sections = new();
        private readonly List<DinnerId> _dinnerIds = new();
        private readonly List<MenuReviewId> _menuReviewIds = new();

        public string Name { get; private set; }
        public string Description { get; private set; }
        public AverageRating AverageRating { get; private set; }
        public HostId HostId { get; private set; }

        public IReadOnlyList<MenuSection> Sections => _sections.AsReadOnly();        
        public IReadOnlyList<DinnerId> DinnerIds => _dinnerIds.AsReadOnly();
        public IReadOnlyList<MenuReviewId> MenuReviewIds => _menuReviewIds.AsReadOnly();

        public DateTime CreatedDateTime { get; private set; }
        public DateTime UpdatedDateTime { get; private set; }


        private Menu(
            MenuId menuId,
            HostId hostId,
            string name,
            string description,
            AverageRating averageRating,
            List<MenuSection>? sections)
            : base(menuId)
        {
            HostId = hostId;
            Name = name;
            Description = description;
            _sections = sections;
            AverageRating = averageRating;
        }

        public static Menu Create(
            HostId hostId,
            string name,
            string description,
            List<MenuSection>? sections = null)
        {
            var menu = new Menu(
                MenuId.CreateUnique(),
                hostId,
                name,
                description,
                AverageRating.CreateNew(0),
                sections ?? new());

            menu.AddDomainEvent(new MenuCreated(menu));

            return menu;
        }

#pragma warning disable CS8618
        private Menu() { }
#pragma warning restore CS8618
    }
}
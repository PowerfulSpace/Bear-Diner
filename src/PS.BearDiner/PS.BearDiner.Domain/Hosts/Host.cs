﻿using PS.BearDiner.Domain.Common.Models;
using PS.BearDiner.Domain.Common.Valueobjects;
using PS.BearDiner.Domain.Dinners.ValueObjects;
using PS.BearDiner.Domain.Hosts.ValueObjects;
using PS.BearDiner.Domain.Menus.ValueObjects;
using PS.BearDiner.Domain.Users.ValueObjects;

namespace PS.BearDiner.Domain.Hosts
{
    public sealed class Host : AggregateRoot<HostId, Guid>
    {
        private readonly List<MenuId> _menuIds = new();
        private readonly List<DinnerId> _dinnerIds = new();

        public string FirstName { get; }
        public string LastName { get; }
        public string ProfileImage { get; }
        public AverageRating AverageRating { get; }
        public UserId UserId { get; }

        public IReadOnlyList<MenuId> MenuIds => _menuIds.AsReadOnly();
        public IReadOnlyList<DinnerId> DinnerIds => _dinnerIds.AsReadOnly();

        public DateTime CreatedDateTime { get; }
        public DateTime UpdatedDateTime { get; }

        private Host(
            HostId hostId,
            string firstName,
            string lastName,
            string profileImage,
            AverageRating averageRating,
            UserId userId,
            DateTime createdDateTime,
            DateTime updatedDateTime)
            : base(hostId)
        {
            FirstName = firstName;
            LastName = lastName;
            ProfileImage = profileImage;
            AverageRating = averageRating;
            UserId = userId;
            CreatedDateTime = createdDateTime;
            UpdatedDateTime = updatedDateTime;
        }

        public static Host Create(
            string firstName,
            string lastName,
            string profileImage,
            AverageRating averageRating,
            UserId userId)
        {
            return new(
                HostId.CreateUnique(),
                firstName,
                lastName,
                profileImage,
                averageRating,
                userId,
                DateTime.UtcNow,
                DateTime.UtcNow);
        }

#pragma warning disable CS8618
        private Host() { }
#pragma warning restore CS8618
    }
}

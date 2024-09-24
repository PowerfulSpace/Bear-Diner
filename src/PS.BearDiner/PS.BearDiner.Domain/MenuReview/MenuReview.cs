﻿using PS.BearDiner.Domain.Common.Models;
using PS.BearDiner.Domain.Common.Valueobjects;
using PS.BearDiner.Domain.Dinner.ValueObjects;
using PS.BearDiner.Domain.Guest.ValueObjects;
using PS.BearDiner.Domain.Host.ValueObjects;
using PS.BearDiner.Domain.Menu.ValueObjects;
using PS.BearDiner.Domain.MenuReview.ValueObjects;

namespace PS.BearDiner.Domain.MenuReview
{
    public sealed class MenuReview : AggregateRoot<MenuReviewId, Guid>
    {
        public Rating Rating { get; }
        public string Comment { get; }
        public HostId HostId { get; }
        public MenuId MenuId { get; }
        public GuestId GuestId { get; }
        public DinnerId DinnerId { get; }
        public DateTime CreatedDateTime { get; }
        public DateTime UpdatedDateTime { get; }

        private MenuReview(
            MenuReviewId menuReviewId,
            string comment,
            HostId hostId,
            MenuId menuId,
            GuestId guestId,
            DinnerId dinnerId,
            DateTime createdDateTime,
            DateTime updatedDateTime)
       : base(menuReviewId)
        {
            Comment = comment;
            HostId = hostId;
            MenuId = menuId;
            GuestId = guestId;
            DinnerId = dinnerId;
            CreatedDateTime = createdDateTime;
            UpdatedDateTime = updatedDateTime;
        }

        public static MenuReview Create(
            string comment,
            HostId hostId,
            MenuId menuId,
            GuestId guestId,
            DinnerId dinnerId)
        {
            return new(
                MenuReviewId.CreateUnique(),
                comment,
                hostId,
                menuId,
                guestId,
                dinnerId,
                DateTime.UtcNow,
                DateTime.UtcNow);
        }

#pragma warning disable CS8618
        private MenuReview() { }
#pragma warning restore CS8618
    }
}

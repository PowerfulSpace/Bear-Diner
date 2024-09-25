﻿using PS.BearDiner.Domain.BillAggregate.ValueObjects;
using PS.BearDiner.Domain.Common.Models;
using PS.BearDiner.Domain.DinnerAggregate.ValueObjects;
using PS.BearDiner.Domain.GuestAggregate.ValueObjects;

namespace PS.BearDiner.Domain.DinnerAggregate.Entities
{
    public sealed class Reservation : Entity<ReservationId>
    {
        public int GuestCount { get; }
        public string ReservationStatus { get; }
        public GuestId GuestId { get; }
        public BillId BillId { get; }
        public DateTime? ArrivalDateTime { get; private set; }
        public DateTime CreatedDateTime { get; }
        public DateTime UpdatedDateTime { get; }

        private Reservation(
            ReservationId reservationId,
            int guestCount,
            string reservationStatus,
            GuestId guestId,
            BillId billId,
            DateTime createdDateTime,
            DateTime updatedDateTime)
        : base(reservationId)
        {
            GuestCount = guestCount;
            ReservationStatus = reservationStatus;
            GuestId = guestId;
            BillId = billId;
            CreatedDateTime = createdDateTime;
            UpdatedDateTime = updatedDateTime;
        }

        public static Reservation Create(
            int guestCount,
            string reservationStatus,
            GuestId guestId,
            BillId billId)
        {
            return new(
                ReservationId.CreateUnique(),
                guestCount,
                reservationStatus,
                guestId,
                billId,
                DateTime.UtcNow,
                DateTime.UtcNow);
        }

#pragma warning disable CS8618
        private Reservation() { }
#pragma warning restore CS8618
    }
}

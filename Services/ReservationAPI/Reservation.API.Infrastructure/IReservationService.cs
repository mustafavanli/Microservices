using Reservation.API.Models;
using System;

namespace Reservation.API.Infrastructure
{
    public interface IReservationService
    {
        public ReservationDTO ReservationGetById(int Id); 
    }
}

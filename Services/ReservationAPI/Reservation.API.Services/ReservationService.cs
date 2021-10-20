using Reservation.API.Infrastructure;
using Reservation.API.Models;
using System;

namespace Reservation.API.Services
{
    public class ReservationService : IReservationService
    {
        public ReservationDTO ReservationGetById(int Id)
        {
            return new ReservationDTO {
                Id = Id,
                Amount = 100,
                ReservationDate = DateTime.Now,
                CheckingDate = DateTime.Now.Date.AddDays(30),
                CheckOutDate = DateTime.Now.Date.AddDays(37),
                ReservationNumber = 15024
            
            
            };
        }
    }
}

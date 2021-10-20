
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using P2LBookingSystem.Models;

namespace P2LBookingSystem.Web.Services
{
    public interface IBookingService
    {
        Task<IEnumerable<Booking>> GetBookings();
        public Task<ActionResult<Booking>> AddBooking(Booking booking);
    }
}

using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using P2LBookingSystem.Models;

namespace P2LBookingSystem.Web.Services
{
    public class BookingService : IBookingService
    {
        private readonly HttpClient _httpClient;
        
        public BookingService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        
        public async Task<IEnumerable<Booking>> GetBookings()
        {
            return await _httpClient.GetJsonAsync<Booking[]>("bookings");
        }

        public async Task<ActionResult<Booking>> AddBooking(Booking booking)
        {
            return await _httpClient.PostJsonAsync<Booking>("bookings", booking);
        }
    }
}
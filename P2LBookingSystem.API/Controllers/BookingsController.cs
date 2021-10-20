using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using P2LBookingSystem.API.Repositories;
using P2LBookingSystem.Models;

namespace P2LBookingSystem.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly IBookingRepository _bookingRepository;

        public BookingsController(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Booking>> GetBookings()
        {
            return await _bookingRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Booking>> GetBookings(int id)
        {
            return await _bookingRepository.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<Booking>> PostBookings(Booking booking)
        {
            var newBooking = await _bookingRepository.Create(booking);
            return CreatedAtAction(nameof(GetBookings), new { id = newBooking.Id }, newBooking);
        }

        [HttpPut]
        public async Task<ActionResult> PutBookings(int id, [FromBody] Booking booking)
        {
            if (id != booking.Id)
            {
                return BadRequest();
            }

            await _bookingRepository.Update(booking);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteBooking(int id)
        {
            var bookingToDelete = await _bookingRepository.Get(id);
            if (bookingToDelete == null)
            {
                return NotFound();
            }

            await _bookingRepository.Delete(bookingToDelete.Id);
            return NoContent();
        }
    }
}
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace P2LBookingSystem.Models
{
    public class Booking
    {
        public int Id { get; set; }
        [Required]
        public DateTime DateFrom { get; set; } = DateTime.Now;

        [Required] public DateTime DateTo { get; set; } = DateTime.Now;

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Provide number bigger than 0")]
        public int BookedQuantity { get; set; }
        public int ResourceId { get; set; }

    }
}
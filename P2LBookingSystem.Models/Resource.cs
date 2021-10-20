using System;
using System.ComponentModel.DataAnnotations;
using System.Threading;

namespace P2LBookingSystem.Models
{
    public class Resource
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }
    }
}
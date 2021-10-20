using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using P2LBookingSystem.Models;

namespace P2LBookingSystem.API.Models
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Resource> Resources { get; set; }
    }
}
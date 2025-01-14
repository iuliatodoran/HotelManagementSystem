using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HotelAPI.Models;
using HotelAPI;

namespace HotelAPI.Data
{
    public class HotelAPIContext : DbContext
    {
        public HotelAPIContext (DbContextOptions<HotelAPIContext> options)
            : base(options)
        {
        }

        public DbSet<HotelAPI.Models.Booking> Booking { get; set; } = default!;
        public DbSet<HotelAPI.Models.Notification> Notification { get; set; } = default!;
        public DbSet<HotelAPI.Models.Review> Review { get; set; } = default!;
        public DbSet<HotelAPI.Models.Room> Room { get; set; } = default!;
        public DbSet<HotelAPI.User> User { get; set; } = default!;
    }
}

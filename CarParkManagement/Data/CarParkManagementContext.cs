using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarParkManagement.Domain;

namespace CarParkManagement.Data
{
    public class CarParkManagementContext : DbContext
    {
        public CarParkManagementContext (DbContextOptions<CarParkManagementContext> options)
            : base(options)
        {
        }

        public DbSet<CarParkManagement.Domain.Booking> Booking { get; set; } = default!;
        public DbSet<CarParkManagement.Domain.ParkingSlot> ParkingSlot { get; set; } = default!;
        public DbSet<CarParkManagement.Domain.Location> Location { get; set; } = default!;
        public DbSet<CarParkManagement.Domain.Payment> Payment { get; set; } = default!;
        public DbSet<CarParkManagement.Domain.User> User { get; set; } = default!;
        public DbSet<CarParkManagement.Domain.Vehicle> Vehicle { get; set; } = default!;
    }
}

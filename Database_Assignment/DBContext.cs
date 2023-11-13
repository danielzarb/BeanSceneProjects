using Database_Assignment;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace Database_Assignment
{
    public class ReservationSystemContext : DbContext
    {
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Sitting> Sittings { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<RestaurantTable> Tables { get; set; }
        public DbSet<Area> Areas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //CONNECTION STRING WILL GO BELOW HERE
            optionsBuilder.UseSqlServer("ConnectionString");
        }
    }

}





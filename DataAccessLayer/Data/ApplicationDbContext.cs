using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
       public DbSet<RoomType> RoomTypes { get; set; }   
       public DbSet<Room> Rooms { get; set; }   
       public DbSet<Hotel> Hotels { get; set; }   
       public DbSet<Emplyees> Emplyees { get; set; }   
       public DbSet<Booking> Bookings { get; set; }   
       public DbSet<Customer> Customers { get; set; }   
       public DbSet<Payment> Payments { get; set; }   
    }
}

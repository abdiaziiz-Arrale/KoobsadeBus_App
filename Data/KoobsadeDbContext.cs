
using Microsoft.EntityFrameworkCore;
using Models;
using Microsoft.AspNetCore.Mvc;
namespace Data;
public class KoobsadeDbContext:DbContext
{
      public KoobsadeDbContext(DbContextOptions <KoobsadeDbContext> options)
      :base (options)
      {
            
      }

     public DbSet<User> Users {get;set;}
     public DbSet<BusDriver> BusDrivers {get;set;}

//      public DbSet<Booking> Bookings {get;set;}
//      public DbSet<Schedule> schedules {get;set;}

      
}
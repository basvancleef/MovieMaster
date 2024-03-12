using MovieMaster.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace MovieMaster.Database;

public class ApplicationDbContext() : DbContext
{
    // Movie
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<Coupon> Coupons { get; set; }
    public DbSet<Icon> Icons { get; set; }
    public DbSet<Show> Shows { get; set; }
    
    // User
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<Payment> Payments { get; set; }
    
    // Cinema
    public DbSet<Hall> Halls { get; set; }
    public DbSet<Seat> Seats { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Configure the SQL Server connection string here.
        optionsBuilder.UseSqlServer(@"");
    }
}

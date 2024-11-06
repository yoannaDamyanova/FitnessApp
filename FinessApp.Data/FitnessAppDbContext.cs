using FitnessApp.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace FitnessApp.Data
{
    public class FitnessAppDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public FitnessAppDbContext()
        {

        }

        public FitnessAppDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public virtual DbSet<FitnessClass> Classes { get; set; } = null!;

        public virtual DbSet<Booking> Bookings { get; set; } = null!;

        public virtual DbSet<Category> Categories { get; set; } = null!;

        public virtual DbSet<Review> Reviews { get; set; } = null!;

        public virtual DbSet<Status> Statuses { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Yoga" },
            new Category { Id = 2, Name = "Pilates" },
            new Category { Id = 3, Name = "Strength Training" },
            new Category { Id = 4, Name = "Cardio" },
            new Category { Id = 5, Name = "Dance" },
            new Category { Id = 6, Name = "HIIT" },
            new Category { Id = 7, Name = "Cycling" },
            new Category { Id = 8, Name = "Meditation" },
            new Category { Id = 9, Name = "Bootcamp" },
            new Category { Id = 10, Name = "Family Fitness" },
            new Category { Id = 11, Name = "Stretching" });

            modelBuilder.Entity<Status>().HasData(
                new Status { Id = 1, Name = "Active" },
                new Status { Id = 2, Name = "Cancled" });

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}

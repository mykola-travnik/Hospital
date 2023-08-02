using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Contexts
{
    public class MainContext : DbContext
    {
        public DbSet<Hospital> Hospital { get; set; }

        public DbSet<City> City { get; set; }

        public DbSet<Doctor> Doctor { get; set; } 

        public DbSet<Hospital_Doctor> Hospital_Doctor { get; set; }

        public DbSet<Specialisation> Specialisation { get; set; }

        public DbSet<Specialisation_Doctor> Specialisation_Doctor { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5400;Database=project;Username=postgres;Password=docker");
        }

    }
}

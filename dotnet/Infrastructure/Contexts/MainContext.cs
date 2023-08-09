﻿using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Contexts
{
    public class MainContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }

        public DbSet<Hospital> Hospital { get; set; }

        public DbSet<City> City { get; set; }

        public DbSet<Doctor> Doctor { get; set; } 

        public DbSet<HospitalDoctor> Hospital_Doctor { get; set; }

        public DbSet<Specialisation> Specialisation { get; set; }

        public DbSet<SpecialisationDoctor> Specialisation_Doctor { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5400;Database=project;Username=postgres;Password=docker");
        }

    }
}

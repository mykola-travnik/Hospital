﻿using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Contexts;

public class MainContext : DbContext
{
    private readonly IConfiguration configuration;

    public DbSet<Country> Countries { get; set; }

    public DbSet<Hospital> Hospital { get; set; }

    public DbSet<City> City { get; set; }

    public DbSet<Doctor> Doctor { get; set; }

    public DbSet<HospitalDoctor> Hospital_Doctor { get; set; }

    public DbSet<Specialisation> Specialisation { get; set; }

    public DbSet<SpecialisationDoctor> Specialisation_Doctor { get; set; }

    public DbSet<User> Users { get; set; }

    public DbSet<Role> Roles { get; set; }

    public DbSet<RecordToDoctor> RecordsToDoctor { get; set; }

    public MainContext(IConfiguration configuration)
    {
        this.configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<City>().Navigation(entity => entity.Country).AutoInclude();

        modelBuilder.Entity<Hospital>().Navigation(entity => entity.City).AutoInclude();

        modelBuilder.Entity<HospitalDoctor>().Navigation(entity => entity.Doctor).AutoInclude();
        modelBuilder.Entity<HospitalDoctor>().Navigation(entity => entity.Specialisation).AutoInclude();
        modelBuilder.Entity<HospitalDoctor>().Navigation(entity => entity.Hospital).AutoInclude();

        modelBuilder.Entity<SpecialisationDoctor>().Navigation(entity => entity.Doctor).AutoInclude();
        modelBuilder.Entity<SpecialisationDoctor>().Navigation(entity => entity.Specialisation).AutoInclude();

        modelBuilder.Entity<User>().Navigation(entity => entity.Roles).AutoInclude();

        modelBuilder.Entity<RecordToDoctor>().Navigation(entity => entity.HospitalDoctor).AutoInclude();
        modelBuilder.Entity<RecordToDoctor>().Navigation(entity => entity.User).AutoInclude();
    }
}
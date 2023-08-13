using Data.Repositories;
using Microsoft.VisualBasic;
using System;
using System.Data;
using Domain.Models;

namespace Business.DataSeedService
{
    public class SpecialisationDataSeedService : IDataSeedService, ISpecialisationDataSeedService
    {
        private readonly ISpecialisationRepository repository;

        public static Specialisation Specialisation0 = new Specialisation()
        {
            Id = Guid.Parse("D6E3D50E-4A7A-4B6E-8A8E-07C6AC1AAA49"),
            Name = "Проктолог",
            IsDeleted = false,
            CreationTimestamp = DateTime.Now.ToUniversalTime(),
            ModifiedTimestamp = DateTime.Now.ToUniversalTime(),
            DeletedTimestamp = null
        };
        public static Specialisation Specialisation1 = new Specialisation()
        {
            Id = Guid.Parse("F6575316-4555-4C46-9A00-74331B8AF2B1"),
            Name = "Венеролог",
            IsDeleted = false,
            CreationTimestamp = DateTime.Now.ToUniversalTime(),
            ModifiedTimestamp = DateTime.Now.ToUniversalTime(),
            DeletedTimestamp = null
        };

        public static Specialisation Specialisation2 = new Specialisation()
        {
            Id = Guid.Parse("50968BF5-4F07-443A-9DB6-9F295DF03A53"),
            Name = "Уролог",
            IsDeleted = false,
            CreationTimestamp = DateTime.Now.ToUniversalTime(),
            ModifiedTimestamp = DateTime.Now.ToUniversalTime(),
            DeletedTimestamp = null
        };

        public static Specialisation Specialisation3 = new Specialisation()
        {
            Id = Guid.Parse("BA20E078-220F-45CC-A300-B6684513D610"),
            Name = "Дерматолог",
            IsDeleted = false,
            CreationTimestamp = DateTime.Now.ToUniversalTime(),
            ModifiedTimestamp = DateTime.Now.ToUniversalTime(),
            DeletedTimestamp = null
        };

        public static Specialisation Specialisation4 = new Specialisation()
        {
            Id = Guid.Parse("1112296D-99AB-4AC7-98A0-FDB7A8A1F81F"),
            Name = "Гинеколог",
            IsDeleted = false,
            CreationTimestamp = DateTime.Now.ToUniversalTime(),
            ModifiedTimestamp = DateTime.Now.ToUniversalTime(),
            DeletedTimestamp = null
        };

        public SpecialisationDataSeedService(ISpecialisationRepository repository)
        {
            this.repository = repository;
        }

        public async Task DataSeedAsync()
        {
            await repository.CreateOrUpdateRangeAsync(new List<Specialisation> { Specialisation0, Specialisation1, Specialisation2, Specialisation3, Specialisation4 });
        }
    }
}
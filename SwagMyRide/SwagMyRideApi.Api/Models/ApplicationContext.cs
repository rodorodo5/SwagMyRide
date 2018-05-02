using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SwagMyRideApi.Api.Models.VehicleComponents;

namespace SwagMyRideApi.Api.Models
{
    public class ApplicationContext: DbContext
    {
        public ApplicationContext(DbContextOptions opts) : base(opts)
        {
        }

        public DbSet<City> City { get; set; }
        public DbSet<BodyWorkCatalogue> BodyWorkCatalogue { get; set; }
        public DbSet<BrandCatalogue> BrandCatalogue { get; set; }
        public DbSet<BreakCatalogue> BreakCatalogue { get; set; }
        public DbSet<CombustibleType> CombustibleType { get; set; }
        public DbSet<ElectricSystemCatalogue> ElectricSystemCatalogue { get; set; }
        public DbSet<MotorCatalogue> MotorCatalogue { get; set; }
        public DbSet<SuspensionCatalogue> SuspensionCatalogue { get; set; }
        public DbSet<TiresCatalogue> TiresCatalogue { get; set; }
        public DbSet<WheelCatalogue> WheelCatalogue { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<State> State { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
    }
}

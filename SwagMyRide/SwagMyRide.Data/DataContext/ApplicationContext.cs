using Microsoft.EntityFrameworkCore;
using SwagMyRide.Data.Models;
using SwagMyRide.Data.Models.GlobalData;
using SwagMyRide.Data.Models.UserData;
using SwagMyRide.Data.Models.VehicleComponents;

namespace SwagMyRide.Data.DataContext
{
    public class ApplicationContext: DbContext
    {
        
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
        public DbSet<UserProfile> UserProfile { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = BERENICE\ISAAC; Database = SwagMyRideDB; Trusted_Connection = True;");
        }
    }
}

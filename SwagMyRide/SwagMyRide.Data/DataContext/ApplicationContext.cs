using Microsoft.EntityFrameworkCore;
using SwagMyRide.Data.Models;
using SwagMyRide.Data.Models.GlobalData;
using SwagMyRide.Data.Models.StoreComponents;
using SwagMyRide.Data.Models.UserData;
using SwagMyRide.Data.Models.VehicleComponents;
using SwagMyRide.Data.Models.VehicleData;
using SwagMyRide.Data.Models.Vehicles;

namespace SwagMyRide.Data.DataContext
{
    public class ApplicationContext: DbContext
    {
        public ApplicationContext()
        {

        }

        public ApplicationContext(DbContextOptions<ApplicationContext> dbContextOptions): base(dbContextOptions)
        {

        }

        public DbSet<City> City { get; set; }
        public DbSet<BodyWorkCatalogue> BodyWorkCatalogue { get; set; }
        public DbSet<BrandCatalogue> BrandCatalogue { get; set; }
        public DbSet<BrakeCatalogue> BreakCatalogue { get; set; }
        public DbSet<CombustibleType> CombustibleType { get; set; }
        public DbSet<ElectricSystemCatalogue> ElectricSystemCatalogue { get; set; }
        public DbSet<MotorCatalogue> MotorCatalogue { get; set; }
        public DbSet<SuspensionCatalogue> SuspensionCatalogue { get; set; }
        public DbSet<TiresCatalogue> TiresCatalogue { get; set; }
        public DbSet<WheelCatalogue> WheelCatalogue { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<UserProfile> UserProfile { get; set; }
        public DbSet<VehicleLand> Vehicles { get; set; }
        public DbSet<VehicleBrand> VehicleBrands { get; set; }
        public DbSet<VehicleModel> VehicleModels { get; set; }
        public DbSet<VehicleWater> VehicleWater { get; set; }
        public DbSet<VehicleAir> VehicleAir { get; set; }
        public DbSet<VehicleLand> VehicleLand { get; set; }
        public DbSet<BoatBladesCatalogue> BoatBladesCatalogue { get; set; }
        public DbSet<TurbinesCatalogue> TurbinesCatalogue { get; set; }
        public DbSet<VehicleBase> VehicleBase { get; set; }
        public DbSet<ProvidersComponents> ProvidersComponents { get; set; }
        public DbSet<MethodProvider> MethodProvider { get; set; }
        public DbSet<OrderList> OrderList { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:swagmyridedb.database.windows.net,1433;Initial Catalog=SwagMyRideDB;Persist Security Info=False;User ID='SwagMyRideDB';Password='polloFrito1';MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            //optionsBuilder.UseSqlServer(@"Server = BERENICE\ISAAC; Database = SwagMyRideDB; Trusted_Connection = True;");
        }
    }
}

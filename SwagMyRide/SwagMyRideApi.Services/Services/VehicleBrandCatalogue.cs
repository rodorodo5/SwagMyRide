using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SwagMyRide.Data.DataContext;
using SwagMyRide.Data.Models.VehicleData;
using SwagMyRideApi.Services.Services.Interfaces;

namespace SwagMyRideApi.Services.Services
{
    public class VehicleBrandCatalogue:IVehicleBrand
    {
        private readonly ApplicationContext _db;
        public VehicleBrandCatalogue()
        {
            _db= new ApplicationContext();
        }
        public List<VehicleBrand> GetVehicleBrands()
        {
            return _db.VehicleBrands.ToList();
        }

        public List<VehicleBrand> GetVehicleBrand(int id)
        {
            return _db.VehicleBrands.Where(x => x.VehicleTypeId == id).ToList();
        }
    }
}

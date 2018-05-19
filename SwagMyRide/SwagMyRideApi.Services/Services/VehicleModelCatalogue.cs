using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SwagMyRide.Data.DataContext;
using SwagMyRide.Data.Models.VehicleData;
using SwagMyRideApi.Services.Services.Interfaces;

namespace SwagMyRideApi.Services.Services
{
    public class VehicleModelCatalogue: IVehicleModel
    {
        private readonly ApplicationContext _db;

        public VehicleModelCatalogue()
        {
            _db = new ApplicationContext();
        }
        public List<VehicleModel> GetVehicleModels()
        {
            return _db.VehicleModels.ToList();
        }

        public List<VehicleModel> GetVehicleModel(int id)
        {
            return _db.VehicleModels.Where(x => x.VehicleTypeId == id).ToList();
        }

        public List<VehicleModel> GetVehicleModelType(int id)
        {
            return _db.VehicleModels.Where(x => x.VehicleTypeId == id).ToList();
        }
    }
}

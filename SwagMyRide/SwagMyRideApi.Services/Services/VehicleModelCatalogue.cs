﻿using System;
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
            return _db.VehicleModels.Where(x => x.VehicleModelId == id).ToList();
        }

        public List<VehicleModel> GetVehicleModelType(int id)
        {
            return _db.VehicleModels.Where(x => x.VehicleTypeId == id).ToList();
        }

        public List<short> GetYearModels()
        {
            return _db.VehicleModels.Select(x => x.VehicleYearModel).ToList();
        }

        public int GetVehicleModelIdByYear(int id)
        {
            return int.Parse(_db.VehicleModels.FirstOrDefault(x => x.VehicleYearModel == id)?.VehicleModelId.ToString());
        }

        public List<VehicleModel> GetVehicleModelsByBrandId(int id)
        {
            return _db.VehicleModels.Where(x => x.VehicleBrandlId == id).ToList();
        }
    }
}

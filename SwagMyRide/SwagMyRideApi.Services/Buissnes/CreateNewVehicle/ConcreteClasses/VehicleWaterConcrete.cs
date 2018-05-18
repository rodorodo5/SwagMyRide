using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SwagMyRide.Data.Models.Vehicles;
using SwagMyRideApi.Services.Buissnes.CreateNewVehicle.Base;
using SwagMyRideApi.Services.Services.Interfaces;

namespace SwagMyRideApi.Services.Buissnes.CreateNewVehicle.ConcreteClasses
{
    public class VehicleWaterConcrete:VehicleBuisness
    {
        private SwagMyRide.Data.Models.Vehicles.VehicleWater _vehicleWaterN;
        public VehicleWaterConcrete(SwagMyRide.Data.Models.Vehicles.VehicleWater vehicleWater)
        {
            _vehicleWaterN = vehicleWater;
        }

       
    }
}

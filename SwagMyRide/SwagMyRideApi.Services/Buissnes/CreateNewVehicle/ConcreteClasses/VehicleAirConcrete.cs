using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SwagMyRide.Data.Models.Vehicles;
using SwagMyRideApi.Services.Buissnes.CreateNewVehicle.Base;
namespace SwagMyRideApi.Services.Buissnes.CreateNewVehicle.ConcreteClasses
{
    public class VehicleAirConcrete:VehicleBuisness
    {
        private readonly SwagMyRide.Data.Models.Vehicles.VehicleAir _vehicleN;
        public VehicleAirConcrete(SwagMyRide.Data.Models.Vehicles.VehicleAir vehicle)
        {
            _vehicleN = vehicle;
            
        }

        

    }

}

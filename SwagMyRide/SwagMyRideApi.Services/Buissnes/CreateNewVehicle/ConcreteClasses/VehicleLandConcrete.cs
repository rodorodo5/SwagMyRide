using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SwagMyRide.Data.Models.Vehicles;
using SwagMyRideApi.Services.Buissnes.CreateNewVehicle.Base;
namespace SwagMyRideApi.Services.Buissnes.CreateNewVehicle.ConcreteClasses
{
    
    public class VehicleLandConcrete: VehicleBuisness
    {
        private SwagMyRide.Data.Models.Vehicles.VehicleLand _vehicleLandN;
        public VehicleLandConcrete(SwagMyRide.Data.Models.Vehicles.VehicleLand vehicle)
        {
            _vehicleLandN = vehicle;
        }



     
    }
}

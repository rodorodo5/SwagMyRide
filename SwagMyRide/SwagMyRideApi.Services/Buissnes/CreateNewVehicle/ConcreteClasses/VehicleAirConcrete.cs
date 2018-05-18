using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using SwagMyRide.Data.Models.Vehicles;
using SwagMyRideApi.Services.Buissnes.CreateNewVehicle.Base;
namespace SwagMyRideApi.Services.Buissnes.CreateNewVehicle.ConcreteClasses
{
    public class VehicleAirConcrete:VehicleBuisness
    {
        private readonly SwagMyRide.Data.Models.Vehicles.VehicleAir _vehicleN;
        public VehicleAirConcrete(FormCollection vehicle)
        {
            _vehicleN = vehicle;
            
        }

      

        

    }

}

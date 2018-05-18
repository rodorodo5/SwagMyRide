using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SwagMyRide.Data.Models.Vehicles;
using SwagMyRideApi.Services.Buissnes.CreateNewVehicle.ConcreteClasses;

namespace SwagMyRideApi.Services.Services.Interfaces
{
   public interface IVehicle
    {
        HttpResponseMessage SavedVehicleAir(VehicleAir vehicle);
        HttpResponseMessage SavedVehicleLand(VehicleLand vehicle);
        HttpResponseMessage SavedVehicleWater(VehicleWater vehicle);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using SwagMyRide.Data.Models.Vehicles;
using SwagMyRideApi.Services.Buissnes.CreateNewVehicle.ConcreteClasses;

namespace SwagMyRideApi.Services.Services.Interfaces
{
   public interface IVehicle
    {
        HttpResponseMessage SavedVehicle(JObject vehicleObject);
        HttpResponseMessage UpdateVehicle(SwagMyRide.Data.Models.Vehicles.VehicleBase vehicleObject);
        List<SwagMyRide.Data.Models.Vehicles.VehicleBase> GetAllData();
        List<SwagMyRide.Data.Models.Vehicles.VehicleBase> GetDataPerId(int id);
        List<SwagMyRide.Data.Models.Vehicles.VehicleBase> GetDataPerUser(int id);
        List<SwagMyRide.Data.Models.Vehicles.VehicleBase> GetDataPerTypeUser(int id,int userid);
        List<SwagMyRide.Data.Models.Vehicles.VehicleBase> GetDataPerBaseId(int id);
    }
}

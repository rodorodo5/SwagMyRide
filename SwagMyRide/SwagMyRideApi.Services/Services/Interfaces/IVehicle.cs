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
     
       
    }
}

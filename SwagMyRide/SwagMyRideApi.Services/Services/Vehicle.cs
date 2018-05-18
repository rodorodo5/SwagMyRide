using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using SwagMyRide.Data.DataContext;
using SwagMyRide.Data.Models.VehicleData;
using SwagMyRide.Data.Models.Vehicles;
using SwagMyRideApi.Services.Buissnes.CreateNewVehicle.Base;
using SwagMyRideApi.Services.Buissnes.CreateNewVehicle.ConcreteClasses;
using SwagMyRideApi.Services.Services.Interfaces;

namespace SwagMyRideApi.Services.Services
{
    public class Vehicle:IVehicle
    {
        private readonly ApplicationContext _db;
        public Vehicle()
        {
            _db = new ApplicationContext();


        }

        public HttpResponseMessage SavedVehicleAir(VehicleAir vehicle)
        {
            VehicleBuisness vehicleBuisness = new Buissnes.CreateNewVehicle.ConcreteClasses.VehicleAirConcrete(vehicle);
            return new HttpResponseMessage(HttpStatusCode.Created);
        }
        
        public HttpResponseMessage SavedVehicleLand(VehicleLand vehicle)
        { 
            VehicleBuisness vehicleBuisness = new Buissnes.CreateNewVehicle.ConcreteClasses.VehicleLandConcrete(vehicle);
            return new HttpResponseMessage(HttpStatusCode.Created);
        }

        public HttpResponseMessage SavedVehicleWater(VehicleWater vehicle)
        {
            VehicleBuisness vehicleBuisness = new Buissnes.CreateNewVehicle.ConcreteClasses.VehicleWaterConcrete(vehicle);
            return new HttpResponseMessage(HttpStatusCode.Created);
        }
    }
}
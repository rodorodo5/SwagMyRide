using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json.Linq;
using SwagMyRide.Data.DataContext;
using SwagMyRide.Data.Models.VehicleData;
using SwagMyRide.Data.Models.Vehicles;
using SwagMyRideApi.Services.Buissnes.CreateNewVehicle.Base;
using SwagMyRideApi.Services.Buissnes.CreateNewVehicle.ConcreteClasses;
using SwagMyRideApi.Services.Buissnes.CreateNewVehicle.Enum;
using SwagMyRideApi.Services.Buissnes.CreateNewVehicle.Interfaces;
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



        public HttpResponseMessage SavedVehicle(JObject vehicleObject)
        {
            IVehicleBuilder vehicleBuilder;
            Director director = new Director();
            VehicleBase vehicleBase = null;
            if ((short) vehicleObject["ProvideVehicleType"] == (short) EnumVehicleType.VehicleType.Air)
            {
                vehicleBuilder = new VehicleAirConcrete(vehicleObject);
                director.Construct(vehicleBuilder);
                 vehicleBase = (VehicleAir)vehicleBuilder.VehicleService();
            }
            if ((short)vehicleObject["ProvideVehicleType"] == (short)EnumVehicleType.VehicleType.Land)
            {
                vehicleBuilder = new VehicleLandConcrete(vehicleObject);
                director.Construct(vehicleBuilder);
                vehicleBase = (VehicleLand)vehicleBuilder.VehicleService();
            }
            if ((short)vehicleObject["ProvideVehicleType"] == (short)EnumVehicleType.VehicleType.Water)
            {
                vehicleBuilder = new VehicleLandConcrete(vehicleObject);
                director.Construct(vehicleBuilder);
                vehicleBase = (VehicleWater)vehicleBuilder.VehicleService();
            }

             _db.VehicleBase.Add(vehicleBase ?? throw new InvalidOperationException());
            return new HttpResponseMessage(HttpStatusCode.Created);
        }
    }
}
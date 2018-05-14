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
using SwagMyRideApi.Services.Buissnes.CreateNewVehicle.ConcreteClasses;
using SwagMyRideApi.Services.Buissnes.CreateNewVehicle.ConcreteDecorators;
using SwagMyRideApi.Services.Services.Interfaces;

namespace SwagMyRideApi.Services.Services
{
    public class Vehicle:IVehicle
    {
        private readonly ApplicationContext _db;
        private SwagMyRide.Data.Models.Vehicles.Vehicle newVehicle;
        public Vehicle()
        {
            _db = new ApplicationContext();


        }
      
        HttpResponseMessage IVehicle.SavedVehicle(SwagMyRide.Data.Models.Vehicles.Vehicle vehicle)
        {
            

            if (vehicle.VechileTypeId == (int) VehicleType.VechicleTypes.Air)
            {
                newVehicle = new VehicleAir();
            }
            if (vehicle.VechileTypeId == (int) VehicleType.VechicleTypes.Land)
            {
                 newVehicle = new VehicleLand();
            }
            if (vehicle.VechileTypeId == (int)VehicleType.VechicleTypes.Water)
            {
                newVehicle = new VehicleWater();

            }
           
            newVehicle = new DecoratorBodyWork(vehicle);
            newVehicle = new DecoratorBreak(vehicle);
            newVehicle = new DecoratorElectricSystem(vehicle);
            newVehicle = new DecoratorMotor(vehicle);
            newVehicle = new DecoratorSuspension(vehicle);
            newVehicle = new DecoratorTires(vehicle);
            newVehicle = new DecoratorWheel(vehicle);
            newVehicle.Color = vehicle.Color;
            newVehicle.LastModifyTime = vehicle.LastModifyTime;
            newVehicle.UserProfileId = vehicle.UserProfileId;
            newVehicle.VehicleYear = vehicle.VehicleYear;
            newVehicle.VehicleType = vehicle.VehicleType;


            _db.Vehicles.Add(newVehicle);
            _db.SaveChanges();
            return new HttpResponseMessage(HttpStatusCode.Created);
        }
    }
}
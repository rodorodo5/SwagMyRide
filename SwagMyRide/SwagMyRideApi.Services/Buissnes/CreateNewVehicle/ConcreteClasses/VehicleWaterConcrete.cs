﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json.Linq;
using SwagMyRide.Data.Models.Vehicles;
using SwagMyRideApi.Services.Buissnes.CreateNewVehicle.Base;
using SwagMyRideApi.Services.Buissnes.CreateNewVehicle.Interfaces;
using SwagMyRideApi.Services.Services.Interfaces;

namespace SwagMyRideApi.Services.Buissnes.CreateNewVehicle.ConcreteClasses
{
    public class VehicleWaterConcrete: IVehicleBuilder
    {
        private readonly JObject _collection;
        private readonly VehicleWater _vehicleWater;
        public VehicleWaterConcrete(JObject vehicleObject)
        {
            _vehicleWater = new VehicleWater();
            _collection = vehicleObject;
            _vehicleWater.BoatBladesCount = (long)_collection["BoatBladesCount"];
            _vehicleWater.MotorId = (long)_collection["MotorId"];
            _vehicleWater.BoatBladesId = (long)_collection["BoatBladesId"];
        }

        public VehicleBase VehicleService()
        {
            return _vehicleWater;
        }

        public void ProvideVehicleBase()
        {
            _vehicleWater.VehicleBaseId = (long)_collection["ProvideVehicleBase"];
        }

        public void ProvideUser()
        {
            _vehicleWater.UserProfileId = (long)_collection["ProvideUser"];
        }

        public void VehicleType()
        {
            _vehicleWater.VechileTypeId = (short)_collection["VehicleTypeId"];
        }

        public void ProvideColor()
        {
            _vehicleWater.Color = (string)_collection["ProvideColor"];
        }



        public void ProvideBodyWork()
        {
            _vehicleWater.Color = (string)_collection["ProvideBodyWork"];
        }

        public void ProvideElectrySystem()
        {
            _vehicleWater.ElecticSystemId = (long)_collection["ProvideElectrySystem"];
        }

        public void ProvideLastModifyTime()
        {
            _vehicleWater.LastModifyTime = (DateTime)_collection["ProvideLastModifyTime"];
        }

        public void ProvideCombustibleId()
        {
            _vehicleWater.CombustibleId = (long)_collection["ProvideCombustibleId"];
        }

        public void ProvideModel()
        {
            _vehicleWater.CombustibleId = (long)_collection["ProvideCombustibleId"];
        }

        public void ProvideBrand()
        {
            _vehicleWater.VehicleBrandId = (long)_collection["ProvideBrand"];
        }

        public void ProvideVehicleYear()
        {
            _vehicleWater.VehicleYear = (long)_collection["ProvideVehicleYear"];
        }


    }
}

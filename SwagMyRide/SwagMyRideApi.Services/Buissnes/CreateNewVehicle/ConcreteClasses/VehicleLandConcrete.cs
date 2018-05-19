﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json.Linq;
using SwagMyRide.Data.Models.Vehicles;
using SwagMyRideApi.Services.Buissnes.CreateNewVehicle.Base;
using SwagMyRideApi.Services.Buissnes.CreateNewVehicle.Interfaces;

namespace SwagMyRideApi.Services.Buissnes.CreateNewVehicle.ConcreteClasses
{
    
    public class VehicleLandConcrete: IVehicleBuilder
    {
        private readonly JObject _collection;
        private readonly VehicleLand _vehicleLand;
        public VehicleLandConcrete(JObject vehicleObject)
        {
            _vehicleLand = new VehicleLand();
            _collection = vehicleObject;
            _vehicleLand.TiresId = (long)(_collection["TiresId"]);
            _vehicleLand.SuspensionId = (long)(_collection["SuspensionId"]);
            _vehicleLand.WheelId = (long)(_collection["WheelId"]);
            _vehicleLand.BrakeId = (long)(_collection["BrakeId"]);
            _vehicleLand.MotorId = (long)(_collection["MotorId"]);

        }

        public VehicleBase VehicleService()
        {
            return _vehicleLand;
        }
        public void ProvideVehicleBase()
        {
            _vehicleLand.VehicleBaseId = (long)(_collection["VehicleBaseId"]);
        }

        public void ProvideUser()
        {
            _vehicleLand.UserProfileId = (long)(_collection["ProvideUser"]);
        }

        public void VehicleType()
        {
            _vehicleLand.VechileTypeId = (short)(_collection["VehicleTypeId"]);
        }

        public void ProvideColor()
        {
            _vehicleLand.Color = (string)_collection["ProvideColor"];
        }



        public void ProvideBodyWork()
        {
            _vehicleLand.BodyWorkId = (long)(_collection["ProvideBodyWork"]);
        }

        public void ProvideElectrySystem()
        {
            _vehicleLand.ElecticSystemId = (long)(_collection["ProvideElectrySystem"]);
        }

        public void ProvideLastModifyTime()
        {
            _vehicleLand.LastModifyTime = (DateTime)(_collection["ProvideLastModifyTime"]);
        }

        public void ProvideCombustibleId()
        {
            _vehicleLand.CombustibleId = (long)(_collection["ProvideCombustibleId"]);
        }

        public void ProvideModel()
        {
            _vehicleLand.MotorId = (long)(_collection["ProvideModel"]);
        }

        public void ProvideBrand()
        {
            _vehicleLand.VehicleBrandId = (long)(_collection["ProvideBrand"]);
        }

        public void ProvideVehicleYear()
        {
            _vehicleLand.VehicleYear = (long)(_collection["ProvideVehicleYear"]);
        }



    }
}

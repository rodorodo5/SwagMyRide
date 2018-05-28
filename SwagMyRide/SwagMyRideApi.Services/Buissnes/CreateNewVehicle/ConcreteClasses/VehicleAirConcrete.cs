using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json.Linq;
using SwagMyRide.Data.Models.Vehicles;
using SwagMyRide.Data.Services;
using SwagMyRideApi.Services.Buissnes.CreateNewVehicle.Base;
using SwagMyRideApi.Services.Buissnes.CreateNewVehicle.Interfaces;
using SwagMyRideApi.Services.Services;

namespace SwagMyRideApi.Services.Buissnes.CreateNewVehicle.ConcreteClasses
{
    public class VehicleAirConcrete:IVehicleBuilder
    {
        private readonly JObject _collection;
        private readonly VehicleAir _vehicleAir;
        public VehicleAirConcrete(JObject vehicle)
        {
            _vehicleAir = new VehicleAir();
            _collection = vehicle;
            _vehicleAir.TurbinesId = (long)(_collection["Turbines"]);
            _vehicleAir.TurbinesCount = (short)(_collection["TurbinesCount"]);
            _vehicleAir.SuspensionId = (short)(_collection["SuspensionId"]);
            _vehicleAir.WheelId = (short)(_collection["WheelId"]);
        }


        public void ProvideVehicleBase()
        {
            //
            
        }

        public VehicleBase VehicleService()
        {
            return _vehicleAir;
        }

        public void ProvideUser()
        {
            _vehicleAir.UserProfileId = (long)(_collection["ProvideUser"]);
        }

        public void VehicleType()
        {
            _vehicleAir.VechileTypeId = (short)(_collection["ProvideVehicleType"]);
        }

        public void ProvideColor()
        {
            _vehicleAir.Color = (string)_collection["Color"];
        }
    
      

        public void ProvideBodyWork()
        {
            _vehicleAir.BodyWorkId = (long)_collection["ProvideBodyWork"];
        }

        public void ProvideElectrySystem()
        {
            _vehicleAir.ElecticSystemId = (long)(_collection["ProvideElectrySystem"]);
        }

        public void ProvideLastModifyTime()
        {
            _vehicleAir.LastModifyTime = (DateTime)(_collection["ProvideLastModifyTime"]);
        }

        public void ProvideCombustibleId()
        {
            _vehicleAir.CombustibleId =(long)(_collection["ProvideCombustibleId"]);
        }

        public void ProvideModel()
        {
            _vehicleAir.VehicleModelId = (long)(_collection["ProvideModelId"]);
        }

        public void ProvideBrand()
        {
            _vehicleAir.VehicleBrandId = (long)(_collection["ProvideVehicleBrandId"]);
        }

        public void ProvideVehicleYear()
        {
            _vehicleAir.VehicleYear = (long)(_collection["ProvideVehicleYear"]);
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using SwagMyRide.Data.Models.Vehicles;
using SwagMyRideApi.Services.Buissnes.CreateNewVehicle.Base;
using SwagMyRideApi.Services.Buissnes.CreateNewVehicle.ConcreteClasses;
using SwagMyRideApi.Services.Buissnes.CreateNewVehicle.Enum;
using SwagMyRideApi.Services.Buissnes.CreateNewVehicle.Interfaces;

namespace SwagMyRideApi.Services.Buissnes.CreateNewVehicle
{
    public static class SavedVehicle
    {
        public static VehicleBase SaVehicleBase(JObject vehicleJObject)
        {
            IVehicleBuilder vehicleBuilder;
            Director director = new Director();
            VehicleBase vehicleBase = null;
            if ((short)vehicleJObject["ProvideVehicleType"] == (short)EnumVehicleType.VehicleType.Air)
            {
                vehicleBuilder = new VehicleAirConcrete(vehicleJObject);
                director.Construct(vehicleBuilder);
                vehicleBase = (VehicleAir)vehicleBuilder.VehicleService();
            }
            if ((short)vehicleJObject["ProvideVehicleType"] == (short)EnumVehicleType.VehicleType.Land)
            {
                vehicleBuilder = new VehicleLandConcrete(vehicleJObject);
                director.Construct(vehicleBuilder);
                vehicleBase = (VehicleLand)vehicleBuilder.VehicleService();

            }
            if ((short)vehicleJObject["ProvideVehicleType"] == (short)EnumVehicleType.VehicleType.Water)
            {
                vehicleBuilder = new VehicleWaterConcrete(vehicleJObject);
                director.Construct(vehicleBuilder);
                vehicleBase = (VehicleWater)vehicleBuilder.VehicleService();
            }

            return vehicleBase;
        }
    }
}

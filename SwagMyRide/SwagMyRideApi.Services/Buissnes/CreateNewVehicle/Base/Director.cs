using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SwagMyRide.Data.Models.Vehicles;
using SwagMyRide.Data.Services;
using SwagMyRideApi.Services.Buissnes.CreateNewVehicle.Interfaces;

namespace SwagMyRideApi.Services.Buissnes.CreateNewVehicle.Base
{
    public class Director
    {
        public void Construct(IVehicleBuilder builder)
        {
            builder.ProvideBodyWork();
            builder.ProvideColor();
            builder.ProvideCombustibleId();
            builder.ProvideElectrySystem();
            builder.ProvideLastModifyTime();
            builder.VehicleType();
            builder.ProvideModel();
            builder.ProvideBrand();
            builder.ProvideVehicleYear();
            builder.ProvideUser();
            builder.ProvideVehicleBase();
            builder.ProvideVehicleBrandName();
            builder.ProvideVehicleModelName();
        }
    }
}

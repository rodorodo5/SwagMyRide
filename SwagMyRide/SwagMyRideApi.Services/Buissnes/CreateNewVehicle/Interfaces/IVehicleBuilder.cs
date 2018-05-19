using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SwagMyRide.Data.Models.Vehicles;
using SwagMyRide.Data.Services;

namespace SwagMyRideApi.Services.Buissnes.CreateNewVehicle.Interfaces
{
    public interface IVehicleBuilder
    {
        void VehicleType();
        void ProvideColor();
        void ProvideBodyWork();
        void ProvideElectrySystem();
        void ProvideLastModifyTime();
        void ProvideCombustibleId();
        void ProvideModel();
        void ProvideBrand();
        void ProvideVehicleYear();
        void ProvideUser();
        void ProvideVehicleBase();
        VehicleBase VehicleService();
    }
}

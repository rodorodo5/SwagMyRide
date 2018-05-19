using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwagMyRideApi.Services.Services.Interfaces
{
    public interface IVehicleBrand
    {
        List<SwagMyRide.Data.Models.VehicleData.VehicleBrand> GetVehicleBrands();
        List<SwagMyRide.Data.Models.VehicleData.VehicleBrand> GetVehicleBrand(int id);
        List<SwagMyRide.Data.Models.VehicleData.VehicleBrand> GetVehicleBrandsType(int id);

    }
}

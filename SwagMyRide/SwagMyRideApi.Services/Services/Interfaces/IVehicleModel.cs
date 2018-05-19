using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwagMyRideApi.Services.Services.Interfaces
{
public interface IVehicleModel
    {
        List<SwagMyRide.Data.Models.VehicleData.VehicleModel> GetVehicleModels();
        List<SwagMyRide.Data.Models.VehicleData.VehicleModel> GetVehicleModel(int id);
        List<SwagMyRide.Data.Models.VehicleData.VehicleModel> GetVehicleModelType(int id);
        List<short> GetYearModels();

    }
}

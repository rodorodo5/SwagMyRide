using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SwagMyRideApi.Services.Services.Interfaces
{
   public interface ICombustibleType
    {
        List<SwagMyRide.Data.Models.VehicleComponents.CombustibleType> GetCombustibleTypes();
        List<SwagMyRide.Data.Models.VehicleComponents.CombustibleType> GetCombustibleTypesId(int id);
        HttpResponseMessage SaveComponent(SwagMyRide.Data.Models.VehicleComponents.CombustibleType combustibleType);
    }
}

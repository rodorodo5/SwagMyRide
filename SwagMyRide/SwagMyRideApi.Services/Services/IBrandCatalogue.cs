using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwagMyRideApi.Services.Services
{
    public interface IBrandCatalogue
    {
        List<SwagMyRide.Data.Models.VehicleComponents.BrandCatalogue> GetAllData();
        List<SwagMyRide.Data.Models.VehicleComponents.BrandCatalogue> GetData(int index);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace SwagMyRideApi.Services.Services
{
   public interface IBodyWorkCatalogue
    {
        List<SwagMyRide.Data.Models.VehicleComponents.BodyWorkCatalogue> GetAllData();
        List<SwagMyRide.Data.Models.VehicleComponents.BodyWorkCatalogue> GetData(int index);
    }
}

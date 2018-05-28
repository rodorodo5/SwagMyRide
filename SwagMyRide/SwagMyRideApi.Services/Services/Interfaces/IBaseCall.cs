using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using SwagMyRide.Data.Services;

namespace SwagMyRideApi.Services.Services.Interfaces
{
    public interface IBaseCall
    {
      
        IEnumerable<Service> GetData(int id);
        IEnumerable<Service> GetAllData();
        IEnumerable<Service> GetPerVehicleType(int id);
        IEnumerable<Service> GetDataPerVehicleModel(int id);
        HttpResponseMessage SaveComponent(Service serive);

    }
}

using System.Collections.Generic;
using SwagMyRide.Data.Services;

namespace SwagMyRideApi.Services.Services.Interfaces
{
    public interface IBaseCall
    {
      
        IEnumerable<Service> GetData(int id);
        IEnumerable<Service> GetAllData();
        IEnumerable<Service> GetPerVehicleType(int id);

    }
}

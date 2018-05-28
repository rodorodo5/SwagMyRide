using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwagMyRideApi.Services.Services.Interfaces
{
    public interface IMethodProvider
    {
        List<SwagMyRide.Data.Models.StoreComponents.MethodProvider> GetAllData();
        List<SwagMyRide.Data.Models.StoreComponents.MethodProvider> GetData(int id);
        
    }
}

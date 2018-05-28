using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwagMyRideApi.Services.Services.Interfaces
{
    public interface IProviders
    {
        List<SwagMyRide.Data.Models.StoreComponents.ProvidersComponents> GetAllProviders();
        List<SwagMyRide.Data.Models.StoreComponents.ProvidersComponents> GetProvider(int id);
        List<SwagMyRide.Data.Models.StoreComponents.ProvidersComponents> GetProviderByBrand(int id);
    }
}

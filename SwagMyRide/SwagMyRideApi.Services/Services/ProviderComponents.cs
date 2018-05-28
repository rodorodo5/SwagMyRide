using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SwagMyRide.Data.DataContext;
using SwagMyRide.Data.Models.StoreComponents;
using SwagMyRideApi.Services.Services.Interfaces;

namespace SwagMyRideApi.Services.Services
{
    public class ProviderComponents:IProviders
    {
        private readonly ApplicationContext _db;
        public ProviderComponents()
        {
            _db = new ApplicationContext();
        }
        public List<ProvidersComponents> GetAllProviders()
        {
            return _db.ProvidersComponents.ToList();
        }

        public List<ProvidersComponents> GetProvider(int id)
        {
            return _db.ProvidersComponents.Where(x => x.ProvidersId==id).ToList();
        }

        public List<ProvidersComponents> GetProviderByBrand(int id)
        {
            return _db.ProvidersComponents.Where(x => x.Brand == id).ToList();
        }
    }
}

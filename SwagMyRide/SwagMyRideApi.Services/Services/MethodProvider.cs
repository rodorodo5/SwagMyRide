using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SwagMyRide.Data.DataContext;
using SwagMyRideApi.Services.Services.Interfaces;

namespace SwagMyRideApi.Services.Services
{
    public class MethodProvider:IMethodProvider
    {
        private readonly ApplicationContext _db;
        public MethodProvider()
        {
            _db = new ApplicationContext();
        }
        public List<SwagMyRide.Data.Models.StoreComponents.MethodProvider> GetAllData()
        {
            return _db.MethodProvider.ToList();
        }

        public List<SwagMyRide.Data.Models.StoreComponents.MethodProvider> GetData(int id)
        {
            return _db.MethodProvider.Where(x => x.MethodProviderId == id).ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SwagMyRide.Data.DataContext;
using SwagMyRide.Data.Services;
using SwagMyRideApi.Services.Services.Interfaces;

namespace SwagMyRideApi.Services.Services
{
    public class SuspensionCatalogue: IBaseCall
    {
        private readonly ApplicationContext _db;

        public SuspensionCatalogue()
        {
            _db = new ApplicationContext();
        }

        IEnumerable<Service> IBaseCall.GetAllData()
        {
            return _db.SuspensionCatalogue.ToList();
        }

        IEnumerable<Service> IBaseCall.GetData(int id)
        {
            return _db.SuspensionCatalogue.Where(x => x.SuspensionId == id).ToList();
        }
    }
}

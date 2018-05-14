using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SwagMyRide.Data.DataContext;
using SwagMyRide.Data.Services;
using SwagMyRideApi.Services.Services.Interfaces;

namespace SwagMyRideApi.Services.Services
{
    public class WheelCatalogue:IBaseCall
    {
        private readonly ApplicationContext _db;

        public WheelCatalogue()
        {
            _db = new ApplicationContext();
        }
        IEnumerable<Service> IBaseCall.GetAllData()
        {
            return _db.WheelCatalogue.ToList();
        }

        IEnumerable<Service> IBaseCall.GetData(int id)
        {
            return _db.WheelCatalogue.Where(x => x.WheelId == id).ToList();
        }
    }
}

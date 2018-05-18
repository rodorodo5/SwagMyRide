using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SwagMyRide.Data.DataContext;
using SwagMyRide.Data.Services;
using SwagMyRideApi.Services.Services.Interfaces;

namespace SwagMyRideApi.Services.Services
{
    public class TurbinesCatalogue:IBaseCall
    {
        private readonly ApplicationContext _db;

        public TurbinesCatalogue()
        {
            _db = new ApplicationContext();
        }
        public IEnumerable<Service> GetData(int id)
        {
            return _db.TurbinesCatalogue.Where(x => x.TurbinesId==id).ToList();

        }

        public IEnumerable<Service> GetAllData()
        {
            return _db.TurbinesCatalogue.ToList();

        }

        public IEnumerable<Service> GetPerVehicleType(int id)
        {
            return _db.BreakCatalogue.Where(x => x.VechileTypeId == id).ToList();
        }
    }
}

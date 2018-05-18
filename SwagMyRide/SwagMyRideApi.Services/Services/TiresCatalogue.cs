using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SwagMyRide.Data.DataContext;
using SwagMyRide.Data.Services;
using SwagMyRideApi.Services.Services.Interfaces;

namespace SwagMyRideApi.Services.Services
{
    public class TiresCatalogue:IBaseCall
    {

        private readonly ApplicationContext _db;

        public TiresCatalogue()
        {
            _db = new ApplicationContext();
        }

        IEnumerable<Service> IBaseCall.GetAllData()
        {
            return _db.TiresCatalogue.ToList();
        }

        public IEnumerable<Service> GetPerVehicleType(int id)
        {
            return _db.BreakCatalogue.Where(x => x.VechileTypeId == id).ToList();
        }

        IEnumerable<Service> IBaseCall.GetData(int id)
        {
            return _db.TiresCatalogue.Where(x => x.TiresId == id).ToList();
        }
    }
}

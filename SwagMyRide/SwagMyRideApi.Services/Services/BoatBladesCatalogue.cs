using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SwagMyRide.Data.DataContext;
using SwagMyRide.Data.Services;
using SwagMyRideApi.Services.Services.Interfaces;

namespace SwagMyRideApi.Services.Services
{
    public class BoatBladesCatalogue: IBaseCall
    {
        private readonly ApplicationContext _db;
        public BoatBladesCatalogue()
        {
            _db = new ApplicationContext();

        }
        public IEnumerable<Service> GetData(int id)
        {
            return _db.BoatBladesCatalogue.Where(x => x.BoatBladesId == id).ToList();
        }

        public IEnumerable<Service> GetAllData()
        {
            return _db.BoatBladesCatalogue.ToList();
        }

        public IEnumerable<Service> GetPerVehicleType(int id)
        {
            return _db.BoatBladesCatalogue.Where(x => x.VechileTypeId == id).ToList();
        }
    }
}

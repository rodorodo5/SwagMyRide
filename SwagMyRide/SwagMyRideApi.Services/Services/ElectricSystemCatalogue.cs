using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SwagMyRide.Data.DataContext;
using SwagMyRide.Data.Services;
using SwagMyRideApi.Services.Services.Interfaces;

namespace SwagMyRideApi.Services.Services
{
    public class ElectricSystemCatalogue:IBaseCall
    {
        private readonly ApplicationContext _db;

        public ElectricSystemCatalogue()
        {
            _db = new ApplicationContext();
        }

        IEnumerable<Service> IBaseCall.GetAllData()
        {
            return _db.ElectricSystemCatalogue.ToList();
        }

        public IEnumerable<Service> GetPerVehicleType(int id)
        {
            return _db.BreakCatalogue.Where(x => x.VechileTypeId == id).ToList();
        }

        IEnumerable<Service> IBaseCall.GetData(int id)
        {
            return _db.ElectricSystemCatalogue.Where(x => x.ElecticSystemId == id).ToList();
        }
    }
}


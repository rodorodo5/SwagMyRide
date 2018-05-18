using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SwagMyRide.Data.DataContext;
using SwagMyRide.Data.Services;
using SwagMyRide.Data.Models.VehicleComponents;
using SwagMyRideApi.Services.Services.Interfaces;

namespace SwagMyRideApi.Services.Services
{
    public class BodyWorkCatalogue:IBaseCall
    {
        private readonly ApplicationContext _db;
        public BodyWorkCatalogue()
        {
            _db =new ApplicationContext();
           
        }
      

        IEnumerable<Service> IBaseCall.GetData(int id)
        {
            return _db.BodyWorkCatalogue.Where(x => x.BodyWorkId == id).ToList();
        }

        public IEnumerable<Service> GetAllData()
        {
            return _db.BodyWorkCatalogue.ToList();
        }

        public IEnumerable<Service> GetPerVehicleType(int id)
        {
            return _db.BrandCatalogue.Where(x => x.VechileTypeId == id).ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
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
            return _db.TiresCatalogue.Where(x => x.VechileTypeId == id).ToList();
        }

        public IEnumerable<Service> GetDataPerVehicleModel(int id)
        {
            return _db.TiresCatalogue.Where(x => x.VehicleModelId == id).ToList();
        }

        public HttpResponseMessage SaveComponent(Service service)
        {
            var data = (SwagMyRide.Data.Models.VehicleComponents.TiresCatalogue)service;
            if (data == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NotAcceptable);
            }
            _db.TiresCatalogue.Add(data);
            try
            {
                _db.SaveChanges();
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
        }

        IEnumerable<Service> IBaseCall.GetData(int id)
        {
            return _db.TiresCatalogue.Where(x => x.TiresId == id).ToList();
        }
    }
}

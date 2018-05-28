using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
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
            return _db.BodyWorkCatalogue.Where(x => x.VechileTypeId == id).ToList();
        }

        public IEnumerable<Service> GetDataPerVehicleModel(int id)
        {
            return _db.BodyWorkCatalogue.Where(x => x.VehicleModelId == id).ToList();
        }

        public HttpResponseMessage SaveComponent(Service service)
        {
            var data = (SwagMyRide.Data.Models.VehicleComponents.BodyWorkCatalogue)service;
            if (data == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NotAcceptable);
            }
            _db.BodyWorkCatalogue.Add(data);
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
    }
}

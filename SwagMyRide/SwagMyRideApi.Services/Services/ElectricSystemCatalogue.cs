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
            return _db.ElectricSystemCatalogue.Where(x => x.VechileTypeId == id).ToList();
        }

        public IEnumerable<Service> GetDataPerVehicleModel(int id)
        {
            return _db.ElectricSystemCatalogue.Where(x => x.VehicleModelId == id).ToList();
        }

        public HttpResponseMessage SaveComponent(Service service)
        {
            var data = (SwagMyRide.Data.Models.VehicleComponents.ElectricSystemCatalogue)service;
            if (data == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NotAcceptable);
            }
            _db.ElectricSystemCatalogue.Add(data);
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
            return _db.ElectricSystemCatalogue.Where(x => x.ElecticSystemId == id).ToList();
        }
    }
}


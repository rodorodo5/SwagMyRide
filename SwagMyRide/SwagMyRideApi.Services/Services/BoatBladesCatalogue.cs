using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.Language.CodeGeneration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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

        public IEnumerable<Service> GetDataPerVehicleModel(int id)
        {
            return _db.BoatBladesCatalogue.Where(x => x.VehicleModelId == id).ToList();
        }

        public HttpResponseMessage SaveComponent(Service service)
        {
            var data = (SwagMyRide.Data.Models.VehicleComponents.BoatBladesCatalogue) service;
            if (data == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NotAcceptable);
            }
            _db.BoatBladesCatalogue.Add(data);
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

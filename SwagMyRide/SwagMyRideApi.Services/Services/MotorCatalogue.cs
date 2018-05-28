using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using SwagMyRide.Data.DataContext;
using SwagMyRide.Data.Services;
using SwagMyRideApi.Services.Services.Interfaces;

namespace SwagMyRideApi.Services.Services
{
    public class MotorCatalogue:IBaseCall
    {
        private readonly ApplicationContext _db;

        public MotorCatalogue()
        {
            _db= new ApplicationContext();
        }

        IEnumerable<Service> IBaseCall.GetAllData()
        {
            return _db.MotorCatalogue.ToList();
        }

        public IEnumerable<Service> GetPerVehicleType(int id)
        {
            return _db.MotorCatalogue.Where(x => x.VechileTypeId == id).ToList();
        }

        public IEnumerable<Service> GetDataPerVehicleModel(int id)
        {
            return _db.MotorCatalogue.Where(x => x.VehicleModelId == id).ToList();
        }

        public HttpResponseMessage SaveComponent(Service service)
        {
            var data = (SwagMyRide.Data.Models.VehicleComponents.MotorCatalogue)service;
            if (data == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NotAcceptable);
            }
            _db.MotorCatalogue.Add(data);
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
            return _db.MotorCatalogue.Where(x => x.MotorId == id).ToList();
        }
    }
}

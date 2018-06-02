using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SwagMyRide.Data.DataContext;
using SwagMyRide.Data.Models.VehicleData;
using SwagMyRide.Data.Models.Vehicles;
using SwagMyRideApi.Services.Buissnes.CreateNewVehicle;
using SwagMyRideApi.Services.Buissnes.CreateNewVehicle.Base;
using SwagMyRideApi.Services.Buissnes.CreateNewVehicle.ConcreteClasses;
using SwagMyRideApi.Services.Buissnes.CreateNewVehicle.Enum;
using SwagMyRideApi.Services.Buissnes.CreateNewVehicle.Interfaces;
using SwagMyRideApi.Services.Services.Interfaces;

namespace SwagMyRideApi.Services.Services
{
    public class Vehicle:IVehicle
    {
        private readonly ApplicationContext _db;
        public Vehicle()
        {
            _db = new ApplicationContext();


        }

        public HttpResponseMessage SavedVehicle(JObject vehicleObject)
        {
            var vehicleBase = Buissnes.CreateNewVehicle.SavedVehicle.SaVehicleBase(vehicleObject);
            vehicleBase.LastModifyTime = DateTime.UtcNow;
            _db.VehicleBase.Add(vehicleBase);
            _db.SaveChanges();
            return new HttpResponseMessage(HttpStatusCode.Created);
        }

        public HttpResponseMessage UpdateVehicle(JObject vehicleObject)
        {
            var vehicleBase = Buissnes.CreateNewVehicle.SavedVehicle.SaVehicleBase(vehicleObject);
            vehicleBase.LastModifyTime = DateTime.UtcNow;
            var id = (long)vehicleObject["VehicleBaseId"];
            var entity = _db.VehicleBase.FirstOrDefault(x => x.VehicleBaseId==id);

            try
            {

                
                _db.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                _db.VehicleBase.Add(vehicleBase);
                _db.SaveChanges();
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent("Success")
                };
            }
            catch (Exception e)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }

        }

        public HttpResponseMessage DeleteVehicle(int vehicleId)
        {
            var vehicle = _db.VehicleBase.SingleOrDefault(x => x.VehicleBaseId == vehicleId);
            if (vehicle == null)
                return new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("Data Is Not Exist")
                };
            _db.Entry(vehicle).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _db.SaveChanges();

            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("Success"),
                ReasonPhrase = "Success"
            };

        }

        public List<VehicleBase> GetAllData()
        {
            return _db.VehicleBase.ToList();
        }

        public List<VehicleBase> GetDataPerId(int id)
        {
            return _db.VehicleBase.Where(x => x.VehicleBaseId == id).ToList();
        }

        public List<VehicleBase> GetDataPerUser(int id)
        {
            return _db.VehicleBase.Where(x => x.UserProfileId == id).ToList();
        }

        public List<VehicleBase> GetDataPerTypeUser(int id,int userid)
        {
            return _db.VehicleBase.Where(x => x.VechileTypeId == id && x.UserProfileId == userid).ToList();
        }

        public List<VehicleBase> GetDataPerBaseId(int id)
        {
            return _db.VehicleBase.Where(x => x.VehicleBaseId == id).ToList();
        }
    }
}
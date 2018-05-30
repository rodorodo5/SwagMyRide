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
            var id = vehicleBase.VehicleBaseId;
            var entity = _db.VehicleBase.Find(id);
            try
            {
                entity.LastModifyTime = DateTime.UtcNow;
                _db.Entry(entity).CurrentValues.SetValues(vehicleObject); 
                _db.SaveChanges();
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            catch (Exception e)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }

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
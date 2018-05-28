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
using Newtonsoft.Json.Linq;
using SwagMyRide.Data.DataContext;
using SwagMyRide.Data.Models.VehicleData;
using SwagMyRide.Data.Models.Vehicles;
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
            IVehicleBuilder vehicleBuilder;
            Director director = new Director();
            VehicleBase vehicleBase = null;
            if ((short) vehicleObject["ProvideVehicleType"] == (short) EnumVehicleType.VehicleType.Air)
            {
                vehicleBuilder = new VehicleAirConcrete(vehicleObject);
                director.Construct(vehicleBuilder);
                 vehicleBase = (VehicleAir)vehicleBuilder.VehicleService();
            }
            if ((short)vehicleObject["ProvideVehicleType"] == (short)EnumVehicleType.VehicleType.Land)
            {
                vehicleBuilder = new VehicleLandConcrete(vehicleObject);
                director.Construct(vehicleBuilder);
                vehicleBase = (VehicleLand)vehicleBuilder.VehicleService();
                
            }
            if ((short)vehicleObject["ProvideVehicleType"] == (short)EnumVehicleType.VehicleType.Water)
            {
                vehicleBuilder = new VehicleLandConcrete(vehicleObject);
                director.Construct(vehicleBuilder);
                vehicleBase = (VehicleWater)vehicleBuilder.VehicleService();
            }

            _db.VehicleBase.Add(vehicleBase ?? throw new InvalidOperationException());
            _db.SaveChanges();
            return new HttpResponseMessage(HttpStatusCode.Created);
        }

        public HttpResponseMessage UpdateVehicle(SwagMyRide.Data.Models.Vehicles.VehicleBase vehicleObject)
        {
            var data = vehicleObject;
            if (data == null)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
            try
            {
                _db.Entry(data).State = EntityState.Modified;
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
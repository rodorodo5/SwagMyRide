using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using SwagMyRide.Data.DataContext;
using SwagMyRide.Data.Services;
using SwagMyRideApi.Services.Services.Interfaces;

namespace SwagMyRideApi.Services.Services
{
    public class CombustibleType:ICombustibleType
    {
        private readonly ApplicationContext _db; 

        public CombustibleType()
        {
            _db = new ApplicationContext();
        } 
    

        public List<SwagMyRide.Data.Models.VehicleComponents.CombustibleType> GetCombustibleTypes()
        {
            return _db.CombustibleType.ToList();
        }

        public List<SwagMyRide.Data.Models.VehicleComponents.CombustibleType> GetCombustibleTypesId(int id)
        {
            return _db.CombustibleType.Where(x => x.CombustibleId == id).ToList();
        }

        public HttpResponseMessage SaveComponent(SwagMyRide.Data.Models.VehicleComponents.CombustibleType combustibleType)
        {
            var data = combustibleType;
            if (data == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NotAcceptable);
            }
            _db.CombustibleType.Add(data);
            try
            {
                _db.SaveChanges();
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            catch (Exception e)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
        }
    }
}

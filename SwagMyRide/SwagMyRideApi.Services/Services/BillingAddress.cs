using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SwagMyRide.Data.DataContext;
using SwagMyRideApi.Services.Services.Interfaces;

namespace SwagMyRideApi.Services.Services
{
    public class BillingAddress:IBillingAddress
    {
        private readonly ApplicationContext _db;
        public BillingAddress()
        {
            _db = new ApplicationContext();
        }
        public HttpResponseMessage SaveBillingAddress(SwagMyRide.Data.Models.UserData.BillingAddress value)
        {
            var data = value;
            if (data == null)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }

            _db.BillingAddress.Add(data);
            try
            {
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }

            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        public IQueryable<SwagMyRide.Data.Models.UserData.BillingAddress> GetBillingAddressByUserId(int id)
        {
            return _db.BillingAddress.Where(x => x.UserProfileId == id);
        }
    }
}

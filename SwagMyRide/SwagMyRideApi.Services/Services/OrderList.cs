using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SwagMyRide.Data.DataContext;
using SwagMyRideApi.Services.Services.Interfaces;

namespace SwagMyRideApi.Services.Services
{
    public class OrderList:IOrderList
    {
        private readonly ApplicationContext _db;
        public OrderList()
        {
            _db = new ApplicationContext();
        }
        public List<SwagMyRide.Data.Models.UserData.OrderList> GetDataPerUserAndVehicle(int vehicleBaseId, int userId)
        {
            return _db.OrderList.Where(x => x.OrderListId == userId && x.UserVehicleBaseId == vehicleBaseId).ToList();

        }

        public List<SwagMyRide.Data.Models.UserData.OrderList> GetDataPerUser(int userId)
        {
            return _db.OrderList.Where(x => x.UserProfileId == userId).ToList();
        }

        public HttpResponseMessage SaveOrderList(SwagMyRide.Data.Models.UserData.OrderList orderList)
        {
            var data = orderList;
            data.LastOrderDate = DateTime.UtcNow;
            _db.OrderList.Add(data);
            try
            {
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                return  new HttpResponseMessage(HttpStatusCode.BadRequest);
            }

            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("Success")
            };
        }

        public HttpResponseMessage DeleteOrderList(int id)
        {
            var orderList = _db.OrderList.SingleOrDefault(x => x.OrderListId == id);
            if(orderList != null)
            try
            {
                _db.OrderList.Remove(orderList);
                _db.SaveChanges();
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            catch (Exception e)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        public HttpResponseMessage UpdateOrderList(int orderid, bool isBought)
        {
            var olData = _db.OrderList.SingleOrDefault(x => x.OrderListId == orderid);
            if (olData == null) return new HttpResponseMessage(HttpStatusCode.BadRequest);
          
            _db.Entry(olData).State = EntityState.Modified;
            olData.IsBought = isBought;
            _db.SaveChanges();

            return new HttpResponseMessage(HttpStatusCode.OK);
        }

    }
}

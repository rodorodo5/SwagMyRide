using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SwagMyRideApi.Services.Services.Interfaces
{
    public interface IOrderList
    {
        List<SwagMyRide.Data.Models.UserData.OrderList> GetDataPerUserAndVehicle(int vehicleBaseId,int userId);
        List<SwagMyRide.Data.Models.UserData.OrderList> GetDataPerUser(int userId);
        HttpResponseMessage SaveOrderList(SwagMyRide.Data.Models.UserData.OrderList orderList);
        HttpResponseMessage DeleteOrderList(int id);
        HttpResponseMessage UpdateOrderList(int orderid, bool isBought);


    }
}

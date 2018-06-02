using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwagMyRideApi.Services.Services;
using SwagMyRideApi.Services.Services.Interfaces;

namespace SwagMyRideApi.Api.Controllers
{
    [Produces("application/json")]
    public class OrderListController : Controller
    {
        private  readonly IOrderList _orderList = new OrderList();

        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("api/data/saveorderlist/")]
        public IActionResult SavedOrderList([FromBody]SwagMyRide.Data.Models.UserData.OrderList orderList)
        {
            var bodyData = _orderList.SaveOrderList(orderList);
            return Ok(bodyData);

        }

        [Microsoft.AspNetCore.Mvc.HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("api/data/orderlist/{vehicleBaseId}/{userId}")]
        public IActionResult GetOrderList(int vehicleBaseId,int userId)
        {
            var bodyData = _orderList.GetDataPerUserAndVehicle(vehicleBaseId,userId);
            return Ok(bodyData);

        }

        [Microsoft.AspNetCore.Mvc.HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("api/data/orderlist/{userId}")]
        public IActionResult GetOrderListByUser(int userId)
        {
            var bodyData = _orderList.GetDataPerUser(userId);
            return Ok(bodyData);

        }

        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("api/data/deleteorderlist/{id}")]
        public IActionResult DeleteOrderLystByUserId(int id)
        {
            var bodyData = _orderList.DeleteOrderList(id);
            return Ok(bodyData);

        }

        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("api/data/updateorderlist/{userid}/{isBought}")]
        public IActionResult UpdateOrderListByUserId(int userId,bool isBought)
        {
            var bodyData = _orderList.UpdateOrderList(userId,isBought);
            return Ok(bodyData);

        }
    }
}
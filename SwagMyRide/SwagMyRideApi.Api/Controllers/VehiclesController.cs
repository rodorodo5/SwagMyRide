using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SwagMyRide.Data.Models.Vehicles;
using SwagMyRideApi.Services.Buissnes.CreateNewVehicle.Enum;
using SwagMyRideApi.Services.Services;
using SwagMyRideApi.Services.Services.Interfaces;
namespace SwagMyRideApi.Api.Controllers
{
    [Produces("application/json")]
    public class VehiclesController : Controller
    {
        private readonly IVehicle _vehicles = new Vehicle();

        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("api/data/vehicle/{vehicleObject}")]
        public IActionResult SavedVehicle(HttpResponseMessage vehicleObject)
        {
            var content = vehicleObject.Content;
          
                  var data = JObject.Parse(content.ToString());
                var bodyData = _vehicles.SavedVehicle(data);
                if (bodyData == null)
                {
                    return Content(HttpStatusCode.BadRequest.ToString(), "Internal Error");
                }
            
          

            return Ok();
        }

        //[Microsoft.AspNetCore.Mvc.HttpPost]
        //[Microsoft.AspNetCore.Mvc.Route("api/data/VehicleLand/{vehicle}")]
        //public IActionResult SavedVehicleLand(VehicleLand vehicleLand)
        //{
        //    var bodyData = _vehicles.SavedVehicleLand(vehicleLand);
        //    if (bodyData == null)
        //    {
        //        return Content(HttpStatusCode.BadRequest.ToString(), "Internal Error");
        //    }

        //    return Ok();
        //}
        //[Microsoft.AspNetCore.Mvc.HttpPost]
        //[Microsoft.AspNetCore.Mvc.Route("api/data/VehicleWater/{vehicle}")]
        //public IActionResult SavedVehicleWater(VehicleWater vehicleWater)
        //{
        //    var bodyData = _vehicles.SavedVehicleWater(vehicleWater);
        //    if (bodyData == null)
        //    {
        //        return Content(HttpStatusCode.BadRequest.ToString(), "Internal Error");
        //    }

        //    return Ok();
        //}
    }
}
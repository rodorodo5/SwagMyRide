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
        [Microsoft.AspNetCore.Mvc.Route("api/data/vehicle/")]
        public IActionResult SavedVehicle([FromBody] string value)
        {
            dynamic json = JsonConvert.DeserializeObject(value);
          
                var bodyData = _vehicles.SavedVehicle(json);
                if (bodyData == null)
                {
                    return Content(HttpStatusCode.BadRequest.ToString(), "Internal Error");
                }
            
          

            return Ok();
        }

        [Microsoft.AspNetCore.Mvc.HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("api/data/vehicle/user/{id}")]
        public IActionResult GetDataPerUser(int id)
        {
            
            var bodyData = _vehicles.GetDataPerUser(id);
            if (bodyData == null)
            {
                return Content(HttpStatusCode.BadRequest.ToString(), "Internal Error");
            }
            return Ok(bodyData);
        }


        [Microsoft.AspNetCore.Mvc.HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("api/data/vehicle/{id}")]
        public IActionResult GetDataPerId(int id)
        {

            var bodyData = _vehicles.GetDataPerId(id);
            if (bodyData == null)
            {
                return Content(HttpStatusCode.BadRequest.ToString(), "Internal Error");
            }
            return Ok(bodyData);
        }

        [Microsoft.AspNetCore.Mvc.HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("api/data/vehicle/typeuser/{id}/{userid}/")]
        public IActionResult GetDataPerUserType(int id,int userid)
        {

            var bodyData = _vehicles.GetDataPerTypeUser(id,userid);
            if (bodyData == null)
            {
                return Content(HttpStatusCode.BadRequest.ToString(), "Internal Error");
            }
            return Ok(bodyData);
        }

        [Microsoft.AspNetCore.Mvc.HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("api/data/vehicle/base/{id}/")]
        public IActionResult GetDataPerBaseId(int id)
        {

            var bodyData = _vehicles.GetDataPerBaseId(id);
            if (bodyData == null)
            {
                return Content(HttpStatusCode.BadRequest.ToString(), "Internal Error");
            }
            return Ok(bodyData);
        }


    }
}
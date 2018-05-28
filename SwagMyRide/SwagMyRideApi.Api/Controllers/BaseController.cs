using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SwagMyRide.Data.Services;
using SwagMyRideApi.Services.Services;
using SwagMyRideApi.Services.Services.Interfaces;

namespace SwagMyRideApi.Api.Controllers
{
    [Produces("application/json")]
    public class BaseController : Controller
    {
        protected IBaseCall Ibase;

        [HttpGet]
        [Route("api/data/[controller]/")]
        public IActionResult GetBodyData()
        {

            var bodyData = Ibase.GetAllData();
            if (bodyData == null)
            {
                return Content(HttpStatusCode.BadRequest.ToString(), "Internal Error");
            }

            return Ok(bodyData);
        }

        [HttpGet]
        [Route("api/data/[controller]/{id}")]
        public IActionResult GetData(int id)
        {
            var bodyData = Ibase.GetData(id);
            if (bodyData == null)
            {
                return Content(HttpStatusCode.BadRequest.ToString(), "Internal Error");
            }

            return Ok(bodyData);

        }

        [HttpGet]
        [Route("api/data/[controller]/type/{id}")]
        public IActionResult GetPerVehicleType(int id)
        {
            var bodyData = Ibase.GetPerVehicleType(id);
            if (bodyData == null)
            {
                return Content(HttpStatusCode.BadRequest.ToString(), "Internal Error");
            }

            return Ok(bodyData);

        }

        [HttpGet]
        [Route("api/data/[controller]/component/{id}")]
        public IActionResult GetDataPerModel(int id)
        {
            var bodyData = Ibase.GetDataPerVehicleModel(id);
            if (bodyData == null)
            {
                return Content(HttpStatusCode.BadRequest.ToString(), "Internal Error");
            }

            return Ok(bodyData);

        }

        [HttpPost]
        [Route("api/data/[controller]/add/")]
        public IActionResult AddComponent([FromBody]string serivice)
        {
            dynamic json = JsonConvert.DeserializeObject(serivice);
            var bodyData = Ibase.SaveComponent(json);
            if (bodyData == null)
            {
                return Content(HttpStatusCode.BadRequest.ToString(), "Internal Error");
            }

            return Ok();

        }
    }
}
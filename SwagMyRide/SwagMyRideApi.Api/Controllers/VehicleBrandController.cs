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
   
    public class VehicleBrandController : Controller
    {
        private readonly IVehicleBrand _vehicleBrand = new VehicleBrandCatalogue();

        [Microsoft.AspNetCore.Mvc.HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("api/data/vehiclebrand/")]
        public IActionResult GetAllData()
        {
            var bodyData = _vehicleBrand.GetVehicleBrands();
            if (bodyData == null)
            {
                return Content(HttpStatusCode.BadRequest.ToString(), "Internal Error");
            }

           

            return Ok(bodyData);

        }

        [Microsoft.AspNetCore.Mvc.HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("api/data/vehiclebrand/{id}")]
        public IActionResult GetDataId(int id)
        {
            var bodyData = _vehicleBrand.GetVehicleBrand(id);
            if (bodyData == null)
            {
                return Content(HttpStatusCode.BadRequest.ToString(), "Internal Error");
            }



            return Ok(bodyData);

        }

        [Microsoft.AspNetCore.Mvc.HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("api/data/vehiclebrand/type/{id}")]
        public IActionResult GetType(int id)
        {
            var bodyData = _vehicleBrand.GetVehicleBrandsType(id);
            if (bodyData == null)
            {
                return Content(HttpStatusCode.BadRequest.ToString(), "Internal Error");
            }



            return Ok(bodyData);

        }
    }
}
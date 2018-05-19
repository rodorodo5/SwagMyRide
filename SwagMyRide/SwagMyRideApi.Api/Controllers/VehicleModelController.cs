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
    public class VehicleModelController : Controller
    {
        private readonly IVehicleModel _vehicleModel = new VehicleModelCatalogue();

        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("api/data/vehiclemodel/")]
        public IActionResult GetAllData()
        {
            var bodyData = _vehicleModel.GetVehicleModels();
            if (bodyData == null)
            {
                return Content(HttpStatusCode.BadRequest.ToString(), "Internal Error");
            }



            return Ok(bodyData);

        }

        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("api/data/vehiclemodel/{id}")]
        public IActionResult GetDataId(int id)
        {
            var bodyData = _vehicleModel.GetVehicleModel(id);
            if (bodyData == null)
            {
                return Content(HttpStatusCode.BadRequest.ToString(), "Internal Error");
            }



            return Ok(bodyData);

        }

        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("api/data/vehiclemodel/type/{id}")]
        public IActionResult GetType(int id)
        {
            var bodyData = _vehicleModel.GetVehicleModelType(id);
            if (bodyData == null)
            {
                return Content(HttpStatusCode.BadRequest.ToString(), "Internal Error");
            }



            return Ok(bodyData);

        }
    }
}
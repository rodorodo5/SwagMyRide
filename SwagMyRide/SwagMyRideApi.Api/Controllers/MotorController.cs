using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwagMyRideApi.Services.Services;

namespace SwagMyRideApi.Api.Controllers
{
    [Produces("application/json")]
    public class MotorController : BaseController
    {
        public MotorController()
        {
            Ibase = new MotorCatalogue();
        }
        

        //[Microsoft.AspNetCore.Mvc.HttpGet]
        //[Microsoft.AspNetCore.Mvc.Route("api/data/motor")]
        //public IActionResult GetBodyData()
        //{
        //    var bodyData = _motorCatalogue.GetAllData()
        //    if (bodyData == null)
        //    {
        //        return Content(HttpStatusCode.BadRequest.ToString(), "Internal Error");
        //    }

        //    return Ok(bodyData);
        //}
        //[Microsoft.AspNetCore.Mvc.HttpGet]
        //[Microsoft.AspNetCore.Mvc.Route("api/data/motor/{id}")]
        //public IActionResult GetBody(int id)
        //{
        //    var bodyData = _motorCatalogue.GetData(id);
        //    if (bodyData == null)
        //    {
        //        return Content(HttpStatusCode.BadRequest.ToString(), "Internal Error");
        //    }

        //    return Ok(bodyData);
        //}
    }
}
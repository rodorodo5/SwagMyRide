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
    }
}
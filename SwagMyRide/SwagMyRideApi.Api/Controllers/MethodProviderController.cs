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
    public class MethodProviderController : Controller
    {
        private readonly IMethodProvider _methodProvider = new MethodProvider();

        [Microsoft.AspNetCore.Mvc.HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("api/data/methodprovider/")]
        public IActionResult GetAllData()
        {
            var bodyData = _methodProvider.GetAllData();
            if (bodyData == null)
            {
                return Content(HttpStatusCode.BadRequest.ToString(), "Internal Error");
            }
            return Ok(bodyData);
        }

        [Microsoft.AspNetCore.Mvc.HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("api/data/methodprovider/{id}")]
        public IActionResult GetData(int id)
        {
            var bodyData = _methodProvider.GetData(id);
            if (bodyData == null)
            {
                return Content(HttpStatusCode.BadRequest.ToString(), "Internal Error");
            }
            return Ok(bodyData);
        }
    }
}
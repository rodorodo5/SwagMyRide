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
    public class ProviderController : Controller
    {
        private readonly IProviders _providers = new ProviderComponents();

        [Microsoft.AspNetCore.Mvc.HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("api/data/providers/")]
        public IActionResult GetAllData()
        {
            var bodyData = _providers.GetAllProviders();
            if (bodyData == null)
            {
                return Content(HttpStatusCode.BadRequest.ToString(), "Internal Error");
            }
            return Ok(bodyData);
        }

        [Microsoft.AspNetCore.Mvc.HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("api/data/providers/{id}")]
        public IActionResult GetData(int id)
        {
            var bodyData = _providers.GetProvider(id);
            if (bodyData == null)
            {
                return Content(HttpStatusCode.BadRequest.ToString(), "Internal Error");
            }
            return Ok(bodyData);
        }

        [Microsoft.AspNetCore.Mvc.HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("api/data/providers/brand/{id}")]
        public IActionResult GetByBrand(int id)
        {
            var bodyData = _providers.GetProviderByBrand(id);
            if (bodyData == null)
            {
                return Content(HttpStatusCode.BadRequest.ToString(), "Internal Error");
            }
            return Ok(bodyData);
        }

    }
}
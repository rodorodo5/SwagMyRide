using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwagMyRideApi.Services.Services;
namespace SwagMyRideApi.Api.Controllers
{
    [Produces("application/json")]
    public class BodyWorkController : Controller
    {
        private  readonly IBodyWorkCatalogue _iBodyWorkCatalogue = new BodyWorkCatalogue();

        [Microsoft.AspNetCore.Mvc.HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("api/data/BodyWork")]
        public IActionResult GetBodyData()
        {
            var bodyData = _iBodyWorkCatalogue.GetAllData();
            if (bodyData == null)
            {
                return Content(HttpStatusCode.BadRequest.ToString(), "Internal Error");
            }

            return Ok(bodyData);
        }
    }
}
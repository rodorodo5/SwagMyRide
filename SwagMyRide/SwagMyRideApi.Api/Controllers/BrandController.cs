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
    public class BrandController : BaseController
    {
        public BrandController()
        {
            Ibase = new BodyWorkCatalogue();
        }
        //private readonly IBrandCatalogue _iBrandCatalogue = new BrandCatalogue();

        //[Microsoft.AspNetCore.Mvc.HttpGet]
        //[Microsoft.AspNetCore.Mvc.Route("api/data/brand")]
        //public IActionResult GetBodyData()
        //{
        //    var bodyData = _iBrandCatalogue.GetAllData();
        //    if (bodyData == null)
        //    {
        //        return Content(HttpStatusCode.BadRequest.ToString(), "Internal Error");
        //    }

        //    return Ok(bodyData);
        //}
        //[Microsoft.AspNetCore.Mvc.HttpGet]
        //[Microsoft.AspNetCore.Mvc.Route("api/data/brand/{id}")]
        //public IActionResult GetBody(int id)
        //{
        //    var bodyData = _iBrandCatalogue.GetData(id);
        //    if (bodyData == null)
        //    {
        //        return Content(HttpStatusCode.BadRequest.ToString(), "Internal Error");
        //    }

        //    return Ok(bodyData);
        //}
    }
}
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
    [System.Web.Http.Route("api/data/body")]
    public class BodyWorkController : BaseController
    {
        public BodyWorkController()
        {
            Ibase = new BodyWorkCatalogue();
        }
        //private  readonly IBodyWorkCatalogue _iBodyWorkCatalogue = new BodyWorkCatalogue();

        //[Microsoft.AspNetCore.Mvc.HttpGet]
        //[Microsoft.AspNetCore.Mvc.Route("api/[controller]/all")]
        //public IActionResult GetBodyData()
        //{
        //    var bodyData = _iBodyWorkCatalogue.GetAllData();
        //    if (bodyData == null)
        //    {
        //        return Content(HttpStatusCode.BadRequest.ToString(), "Internal Error");
        //    }

        //    return Ok(bodyData);
        //}

        //[Microsoft.AspNetCore.Mvc.HttpGet]
        //[Microsoft.AspNetCore.Mvc.Route("api/data/bodywork/{id}")]
        //public IActionResult GetBody(int id)
        //{
        //    var bodyData = _iBodyWorkCatalogue.GetData(id);
        //    if (bodyData == null)
        //    {
        //        return Content(HttpStatusCode.BadRequest.ToString(), "Internal Error");
        //    }

        //    return Ok(bodyData);
        //}
    }
}
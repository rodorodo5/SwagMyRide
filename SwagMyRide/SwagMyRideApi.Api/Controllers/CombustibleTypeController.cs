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
    public class CombustibleTypeController : Controller
    {
        private readonly ICombustibleType _combustibleType = new CombustibleType();
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("api/data/combustibleType/")]
        public IActionResult GetAllData()
        {
            var bodyData = _combustibleType.GetCombustibleTypes();
            if (bodyData == null)
            {
                return Content(HttpStatusCode.BadRequest.ToString(), "Internal Error");
            }

            /* return Ok("loggedin");*/ //return data in json with status lable and new uniqid

            return Ok();//return data in json with status lable and new uniqid

        }

        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("api/data/combustibleType/{id}")]
        public IActionResult GetDataById(int id)
        {
            var bodyData = _combustibleType.GetCombustibleTypesId(id);
            if (bodyData == null)
            {
                return Content(HttpStatusCode.BadRequest.ToString(), "Internal Error");
            }

            /* return Ok("loggedin");*/ //return data in json with status lable and new uniqid

            return Ok();//return data in json with status lable and new uniqid

        }
    }
}
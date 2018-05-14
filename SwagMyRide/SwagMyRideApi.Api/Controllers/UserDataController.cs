using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SwagMyRideApi.Services.Services;
namespace SwagMyRideApi.Api.Controllers
{
    [Produces("application/json")]
    public class UserDataController : Controller
    {
        private readonly IUserProfile _userProfile = new UserProfile();

    
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("api/userdata/{email}/{password}")]
        public IActionResult GetBodyData(string email,string password)
        {
            var bodyData = _userProfile.GetPassword(email,password);
            if (bodyData == null)
            {
                return Content(HttpStatusCode.BadRequest.ToString(), "Internal Error");
            }

            return Ok("loggedin"); //return data in json with status lable and new uniqid
        }

    }
}
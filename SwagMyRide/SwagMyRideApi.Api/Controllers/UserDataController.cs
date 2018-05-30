using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SwagMyRideApi.Services.Buissnes.Authentification.Abstract;
using SwagMyRideApi.Services.Buissnes.Authentification.ConcreteClasses;
using SwagMyRideApi.Services.Services;
using SwagMyRideApi.Services.Services.Interfaces;
using Formatting = Newtonsoft.Json.Formatting;

namespace SwagMyRideApi.Api.Controllers
{
    [Produces("application/json")]
    public class UserDataController : Controller
    {
        private readonly IUserProfile _userProfile = new UserProfile();

    
        [Microsoft.AspNetCore.Mvc.HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("api/userdata/{email}/{password}")]
        public IActionResult GetBodyData(string email,string password)
        {
            
            var bodyData = _userProfile.GetPassword(email,password);
            if (bodyData == null)
            {
                return  Json("Error");
            }

            AuthResponse getResponse = new Version1(bodyData);
            var response = getResponse.BuildResponse();
            return Ok(response);
            
        }

        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("api/userdata/add/")]
        public IActionResult AddUserData([FromBody] SwagMyRide.Data.Models.UserData.UserProfile value)
        {
            
            var bodyData = value;
            if (bodyData == null)
            {
                return BadRequest("Params are Invalid");
            }

            _userProfile.CreateUser(bodyData);


            return Ok("Success");

        }



    }
}
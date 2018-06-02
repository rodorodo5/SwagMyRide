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
    public class BillingAddressController : Controller
    {
        private readonly IBillingAddress _billingAddress = new BillingAddress();

        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("api/data/billing/")]
        public IActionResult SetBillingAddress([FromBody]SwagMyRide.Data.Models.UserData.BillingAddress value)
        {
            var bodyData = _billingAddress.SaveBillingAddress(value);
            if (bodyData == null)
            {
                return BadRequest();
            }

            if (bodyData.IsSuccessStatusCode)
            {
                return Ok("Success");
            }
            return BadRequest();

        }

        [Microsoft.AspNetCore.Mvc.HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("api/data/billing/{id}")]
        public IActionResult SetBillingAddress(int id)
        {
            var bodyData = _billingAddress.GetBillingAddressByUserId(id);
            if (bodyData == null)
            {
                return Content(HttpStatusCode.BadRequest.ToString(), "Internal Error");
            }
            return Ok(bodyData);

        }
    }
}
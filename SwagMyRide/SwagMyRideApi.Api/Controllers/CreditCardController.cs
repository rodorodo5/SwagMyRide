using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwagMyRideApi.Services.Buissnes;
using SwagMyRideApi.Services.Buissnes.CreditCard;
using SwagMyRideApi.Services.Services.Interfaces;

namespace SwagMyRideApi.Api.Controllers
{
    [Produces("application/json")]
    public class CreditCardController : Controller
    {
        private readonly ICreditCard _creditCard = new CreditCardBuissness();

        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("api/data/creditcard/")]
        public IActionResult InsertCreditCard([FromBody]SwagMyRide.Data.Models.Payment.CreditCard value)
        {
            var bodyData = _creditCard.SavedCreditCard(value);
            return Ok(bodyData);
        }

        [Microsoft.AspNetCore.Mvc.HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("api/data/creditcard/{id}")]
        public IActionResult GetCreditCard(int id)
        {
            var bodyData = _creditCard.GetCreditCard(id);
            return Ok(bodyData);
        }
    }
}
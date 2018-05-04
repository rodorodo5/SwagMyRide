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
    [Route("api/ElectricSystem")]
    public class ElectricSystemController : BaseController
    {
        public ElectricSystemController()
        {
            Ibase = new ElectricSystemCatalogue();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwagMyRideApi.Services.Services;

namespace SwagMyRideApi.Api.Controllers
{
    [Produces("application/json")]
    public class BoatBladesController : BaseController
    {
        public BoatBladesController()
        {
            Ibase = new BoatBladesCatalogue();
        }
    }
}
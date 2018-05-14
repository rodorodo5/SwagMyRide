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
    [System.Web.Http.Route("api/data/break")]
    public class BreakController : BaseController
    {
        public BreakController()
        {
            Ibase = new BreakCatalogue();
        }

        
    }
}
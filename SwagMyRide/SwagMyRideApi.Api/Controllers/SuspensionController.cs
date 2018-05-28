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
    public class SuspensionController : BaseController
    {
        public SuspensionController()
        {
            Ibase = new SuspensionCatalogue();
        }
    }
}
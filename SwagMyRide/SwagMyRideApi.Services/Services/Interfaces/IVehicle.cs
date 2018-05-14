using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SwagMyRideApi.Services.Services.Interfaces
{
    interface IVehicle
    {
        HttpResponseMessage SavedVehicle(SwagMyRide.Data.Models.Vehicles.Vehicle vehicle);
    }
}

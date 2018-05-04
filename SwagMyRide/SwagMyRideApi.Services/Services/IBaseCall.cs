using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SwagMyRide.Data.Services;

namespace SwagMyRideApi.Services.Services
{
    public interface IBaseCall
    {
      
        IEnumerable<Service> GetData(int id);
        IEnumerable<Service> GetAllData();
    }
}

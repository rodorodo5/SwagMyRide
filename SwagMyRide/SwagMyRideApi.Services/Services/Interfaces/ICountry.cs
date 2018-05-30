using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwagMyRideApi.Services.Services.Interfaces
{
    public interface ICountry
    {
        List<SwagMyRide.Data.Models.GlobalData.Country> GetAllData();
    }
}

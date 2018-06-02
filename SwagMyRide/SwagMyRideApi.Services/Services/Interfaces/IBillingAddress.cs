using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SwagMyRideApi.Services.Services.Interfaces
{
    public interface IBillingAddress
    {
        HttpResponseMessage SaveBillingAddress(SwagMyRide.Data.Models.UserData.BillingAddress value);
        IQueryable<SwagMyRide.Data.Models.UserData.BillingAddress> GetBillingAddressByUserId(int id);
    }
}

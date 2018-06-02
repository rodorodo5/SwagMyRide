using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using SwagMyRide.Data.Models.Payment;

namespace SwagMyRideApi.Services.Services.Interfaces
{
    public interface ICreditCard
    {
        HttpResponseMessage SavedCreditCard(SwagMyRide.Data.Models.Payment.CreditCard data);
        string GetCreditCard(int id);
    }
}

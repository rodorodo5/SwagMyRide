using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using SwagMyRide.Data.DataContext;
using SwagMyRideApi.Services.Buissnes.AddUser.Abstract;
using SwagMyRideApi.Services.Buissnes.AddUser.ConcreteClasses;
using SwagMyRideApi.Services.Services.Interfaces;

namespace SwagMyRideApi.Services.Buissnes.CreditCard
{
    public class CreditCardBuissness:ICreditCard
    {
        private readonly ApplicationContext _db; 
        public CreditCardBuissness()
        {
            _db = new ApplicationContext();
        }
        public HttpResponseMessage SavedCreditCard(SwagMyRide.Data.Models.Payment.CreditCard value)
        {
            var data = value;
            GetLastCreditNumbers getLastCreditNumbers = new GetLastCreditNumbers();
            data.LastNumbers = getLastCreditNumbers.LastDigits(data.CreditCardNumber);
            SecurityAlgorithm secureCreditCard = new Sha256S(data.CreditCardNumber);
            SecurityAlgorithm secureCvv = new Sha256S(data.Cvv);
            data.CreditCardNumber = secureCreditCard.Generated();
            data.Cvv = secureCvv.Generated();
            _db.CreditCard.Add(data);
            try
            {
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }

            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("Success")
            };

        }

        public string GetCreditCard(int id)
        {
            return _db.CreditCard.Where(x => x.UserProfileId == id).Select(x => new {x.LastNumbers, x.ExpirationDate}).FirstOrDefault()?.ToString();
        }
    }
}

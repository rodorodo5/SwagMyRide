using System;

namespace SwagMyRideApi.Services.Buissnes.CreditCard
{
    public class GetLastCreditNumbers
    {
        public string LastDigits(string creditcardnumber)
        {
            return creditcardnumber.Substring(Math.Max(0, creditcardnumber.Length - 4));
        }
    }
}

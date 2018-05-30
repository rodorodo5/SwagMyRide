using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwagMyRideApi.Services.Buissnes.AddUser
{
    public class GetUserAge
    {
        public int GetAge(DateTime birthday)
        {
            var today = DateTime.Now;
            var age = today.Year - birthday.Year;
            return age;
        }
    }
}

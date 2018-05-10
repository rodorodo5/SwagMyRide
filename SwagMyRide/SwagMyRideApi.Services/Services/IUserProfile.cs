using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwagMyRideApi.Services.Services
{
   public interface IUserProfile
    {
        IQueryable<string> GetPassword(string email, string password);
    }
}

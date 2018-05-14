using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using SwagMyRide.Data.DataContext;
using SwagMyRide.Data.Services;
using SwagMyRideApi.Services.Services.Interfaces;

namespace SwagMyRideApi.Services.Services
{
    public class UserProfile:IUserProfile
    {
        private readonly ApplicationContext _db;
        public UserProfile()
        {
            _db = new ApplicationContext();
        }

       

        public IQueryable<string> GetPassword(string email, string password)
        {
            return _db.UserProfile.Where(x => x.Email==email && x.Password==password).Select(x=> x.UserName);
        }
    }
}

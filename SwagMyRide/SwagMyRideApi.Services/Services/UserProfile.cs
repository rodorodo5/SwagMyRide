using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SwagMyRide.Data.DataContext;
using SwagMyRide.Data.Services;
using SwagMyRideApi.Services.Buissnes.AddUser.Abstract;
using SwagMyRideApi.Services.Buissnes.AddUser.ConcreteClasses;
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

       

        public string GetPassword(string email, string password)
        {
            SecurityAlgorithm securityAlgorithm = new Sha256S(password);
            var tempass = securityAlgorithm.Generated();

            return _db.UserProfile.Where(x => x.Email==email && x.Password== tempass).Select(x=> x.UserName).FirstOrDefault();
        }

        public HttpResponseMessage CreateUser(SwagMyRide.Data.Models.UserData.UserProfile user)
        {
            var userdata = user;
            if (userdata == null)
            {
                
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
            else
            {
                var tempass = userdata.Password;
                SecurityAlgorithm securityAlgorithm = new Sha256S(tempass);
                userdata.Password = securityAlgorithm.Generated();
                _db.UserProfile.Add(userdata);
                try
                {
                    _db.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return new HttpResponseMessage(HttpStatusCode.InternalServerError);
                }

            }
           
            return new HttpResponseMessage(HttpStatusCode.Created);
        }
    }
}

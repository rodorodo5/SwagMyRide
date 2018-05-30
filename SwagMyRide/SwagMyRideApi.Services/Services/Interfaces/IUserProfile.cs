using System.Linq;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace SwagMyRideApi.Services.Services.Interfaces
{
   public interface IUserProfile
    {
        string GetPassword(string email, string password);
        HttpResponseMessage CreateUser(SwagMyRide.Data.Models.UserData.UserProfile user);
    }
}

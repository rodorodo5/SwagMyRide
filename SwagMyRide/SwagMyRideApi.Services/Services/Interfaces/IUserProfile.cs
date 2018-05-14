using System.Linq;

namespace SwagMyRideApi.Services.Services.Interfaces
{
   public interface IUserProfile
    {
        IQueryable<string> GetPassword(string email, string password);
    }
}

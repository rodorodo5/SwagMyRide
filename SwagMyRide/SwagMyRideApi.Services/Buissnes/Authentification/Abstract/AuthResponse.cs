using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SwagMyRideApi.Services.Buissnes.Authentification.Abstract
{
    public abstract class AuthResponse
    {
        public abstract string BuildResponse();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SwagMyRideApi.Services.Buissnes.Authentification.Abstract;

namespace SwagMyRideApi.Services.Buissnes.Authentification.ConcreteClasses
{
    public class Version1:AuthResponse
    {
        private JObject _json;
        private readonly string _userName;
    
        public Version1(string username)
        {

            _userName = username;
        }
   
        public override string BuildResponse()
        {
            _json = new JObject()
            {
                ["user"] = _userName,
                ["status"] = "loggeind",
                ["id"] = Guid.NewGuid()
            };

            var response = JsonConvert.SerializeObject(_json, Formatting.Indented);
            return response;
        }
    }
}

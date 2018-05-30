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
        private readonly string _userid;
    
        public Version1(string username)
        {

            _userName = username.Split(',')[0].Split("=").Last().Replace(" ",string.Empty);
            _userid = username.Split(",")[1].Split("=").Last().Replace(" ",string.Empty).Replace("}",string.Empty);
        }
   
        public override string BuildResponse()
        {
            _json = new JObject()
            {
                ["user"] =_userName,
                ["status"]="loggedin",
                 ["id"]= _userid
            };

            var response = JsonConvert.SerializeObject(_json, Formatting.Indented);
            return response;
        }
    }
}

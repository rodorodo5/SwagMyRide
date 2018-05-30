using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SwagMyRide.Data.DataContext;
using SwagMyRideApi.Services.Services.Interfaces;

namespace SwagMyRideApi.Services.Services
{
    public class Country:ICountry
    {
        private readonly ApplicationContext _db;
        public Country()
        {
            _db = new ApplicationContext();
        }
        public List<SwagMyRide.Data.Models.GlobalData.Country> GetAllData()
        {
          return  _db.Country.ToList();
        }
    }
}

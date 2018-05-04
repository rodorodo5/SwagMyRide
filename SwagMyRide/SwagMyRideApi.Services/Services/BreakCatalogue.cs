using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SwagMyRide.Data.DataContext;
using SwagMyRide.Data.Services;

namespace SwagMyRideApi.Services.Services
{
    public class BreakCatalogue: IBaseCall
    {
        private readonly ApplicationContext _db;

        public BreakCatalogue()
        {
            _db =  new ApplicationContext();
        }

        public IEnumerable<Service> GetData(int id)
        {
            
            return _db.BreakCatalogue.Where(x => x.BreakId == id).ToList();
        }

        public IEnumerable<Service> GetAllData()
        {
            return _db.BreakCatalogue.ToList();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SwagMyRide.Data.DataContext;
using SwagMyRide.Data.Services;
using SwagMyRideApi.Services.Services.Interfaces;

namespace SwagMyRideApi.Services.Services
{
    public class CombustibleType:IBaseCall
    {
        private readonly ApplicationContext _db; 

        public CombustibleType()
        {
            _db = new ApplicationContext();
        } 
    
        public IEnumerable<Service> GetData(int id)
        {
            return _db.CombustibleType.Where(x => x.CombustibleId == id).ToList();

        }

        public IEnumerable<Service> GetAllData()
        {
            return _db.CombustibleType.ToList();
        }
    }
}

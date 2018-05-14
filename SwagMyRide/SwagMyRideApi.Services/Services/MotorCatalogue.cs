using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SwagMyRide.Data.DataContext;
using SwagMyRide.Data.Services;
using SwagMyRideApi.Services.Services.Interfaces;

namespace SwagMyRideApi.Services.Services
{
    public class MotorCatalogue:IBaseCall
    {
        private readonly ApplicationContext _db;

        public MotorCatalogue()
        {
            _db= new ApplicationContext();
        }

        IEnumerable<Service> IBaseCall.GetAllData()
        {
            return _db.MotorCatalogue.ToList();
        }

        IEnumerable<Service> IBaseCall.GetData(int id)
        {
            return _db.MotorCatalogue.Where(x => x.MotorId == id).ToList();
        }
    }
}

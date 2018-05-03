using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SwagMyRide.Data.DataContext;
using SwagMyRideApi.Api;


namespace SwagMyRideApi.Services.Services
{
    public class BodyWorkCatalogue: IBodyWorkCatalogue
    {
        private readonly ApplicationContext _db = new ApplicationContext();
                
        public List<SwagMyRide.Data.Models.VehicleComponents.BodyWorkCatalogue> GetAllData()
        {
           return _db.BodyWorkCatalogue.ToList();
        }

        public List<SwagMyRide.Data.Models.VehicleComponents.BodyWorkCatalogue> GetData(int index)
        {
            return _db.BodyWorkCatalogue.Where(x => x.BodyWorkId==index).ToList();
        }
    }
}

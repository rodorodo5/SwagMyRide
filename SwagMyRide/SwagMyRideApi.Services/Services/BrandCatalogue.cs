using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SwagMyRide.Data.DataContext;

namespace SwagMyRideApi.Services.Services
{
    public class BrandCatalogue: IBrandCatalogue
    {
        private readonly ApplicationContext _db = new ApplicationContext();

        public List<SwagMyRide.Data.Models.VehicleComponents.BrandCatalogue> GetAllData()
        {
            return _db.BrandCatalogue.ToList();
        }

        public List<SwagMyRide.Data.Models.VehicleComponents.BrandCatalogue> GetData(int index)
        {
            return _db.BrandCatalogue.Where(x => x.BrandId == index).ToList();
        }
    }
}

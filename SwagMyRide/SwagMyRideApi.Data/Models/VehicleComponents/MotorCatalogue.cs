using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwagMyRideApi.Data.Models.VehicleComponents
{
    public class MotorCatalogue
    {
        public long MotorId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public BrandsCatalogue BrandId { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public bool Active { get; set; }
        public string Image { get; set; }
        public string AssembledIn { get; set; }
        public string Manufactured { get; set; }
        public double Weight { get; set; }
        public short HorsePower { get; set; }
        public short Cylinders  { get; set; }
        public CombustibleType CombustibleTypeId { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using SwagMyRide.Data.Models.UserData;
using SwagMyRide.Data.Models.VehicleComponents;
using SwagMyRide.Data.Models.VehicleData;
using SwagMyRide.Data.Services;

namespace SwagMyRide.Data.Models.Vehicles
{
    public class VehicleWater: VehicleBase
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public long VehicleWaterId { get; set; }

        //[Required]
        //public new long VehicleBaseId { get; set; }
        //[ForeignKey("VehicleBaseId")]
        //public VehicleBase VehicleBase { get; set; }


        public long BoatBladesCount { get; set; }


        public long MotorId { get; set; }
       


        public long BoatBladesId { get; set; }
       

    }
}

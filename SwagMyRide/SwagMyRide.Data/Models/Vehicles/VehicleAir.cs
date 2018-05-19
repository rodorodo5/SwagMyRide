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
    public class VehicleAir:VehicleBase
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public long VehicleAirId { get; set; }

        [Required]
        public new long VehicleBaseId { get; set; }
        [ForeignKey("VehicleBaseId")]
        public VehicleBase VehicleBase { get; set; }

      
        [Required]
        public short TurbinesCount { get; set; }

      
        [Required]
        public long TurbinesId { get; set; }
        [ForeignKey("TurbinesId")]
        public TurbinesCatalogue TurbinesCatalogue { get; set; }

        [Required]
        public long SuspensionId;
        [ForeignKey("SuspensionId")]
        public SuspensionCatalogue SuspensionCatalogue { get; set; }

        [Required]
        public long WheelId;
        [ForeignKey("WheelId")]
        public WheelCatalogue WheelCatalogue { get; set; }





    }
}

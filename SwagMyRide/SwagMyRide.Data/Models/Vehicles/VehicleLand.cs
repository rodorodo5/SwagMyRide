using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SwagMyRide.Data.Models.UserData;
using SwagMyRide.Data.Models.VehicleComponents;
using SwagMyRide.Data.Models.VehicleData;
using SwagMyRide.Data.Services;

namespace SwagMyRide.Data.Models.Vehicles
{
    public  class VehicleLand: VehicleBase
    {

        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public long VehicleLandId { get; set; }

        [Required]
        public new long VehicleBaseId { get; set; }
        [ForeignKey("VehicleBaseId")]
        public VehicleBase VehicleBase { get; set; }
      
        [Required]
        public long TiresId;
        [ForeignKey("TiresId")]
        public TiresCatalogue TiresCatalogue { get; set; }

        [Required]
        public long SuspensionId;
        [ForeignKey("SuspensionId")]
        public SuspensionCatalogue SuspensionCatalogue { get; set; }

        [Required]
        public long WheelId;
        [ForeignKey("WheelId")]
        public WheelCatalogue WheelCatalogue { get; set; }

        [Required]
        public long BrakeId;
        [ForeignKey("BrakeId")]
        public BrakeCatalogue BrakeCatalogue { get; set; }
       
        [Required]
        public long MotorId { get; set; }
        [ForeignKey("MotorId")]
        public MotorCatalogue MotorCatalogue { get; set; }

     
    }
}

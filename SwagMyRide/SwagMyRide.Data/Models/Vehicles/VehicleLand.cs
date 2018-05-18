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

namespace SwagMyRide.Data.Models.Vehicles
{
    public  class VehicleLand
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long VehicleLandId { get; set; }

      
        [Required]
        public DateTime LastModifyTime { get; set; }

        [Required]
        public long VehicleYear { get; set; }

        [Required]
        [MaxLength(8)]
        public string Color { get; set; }

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
        public long UserProfileId { get; set; }
        [ForeignKey("UserProfileId")]
        public UserProfile UserProfile { get; set; }

        [Required]
        public long BodyWorkId { get; set; }
        [ForeignKey("BodyWorkId")]
        public BodyWorkCatalogue BodyWorkCatalogue { get; set; }

        [Required]
        public long CombustibleId { get; set; }
        [ForeignKey("CombustibleId")]
        public CombustibleType CombustibleType { get; set; }

        [Required]
        public long ElecticSystemId { get; set; }
        [ForeignKey("ElecticSystemId")]
        public ElectricSystemCatalogue ElectricSystemCatalogue { get; set; }

        [Required]
        public long MotorId { get; set; }
        [ForeignKey("MotorId")]
        public MotorCatalogue MotorCatalogue { get; set; }
      

        [Required]
        public long VehicleBrandId { get; set; }
        [ForeignKey("VehicleBrandId")]
        public VehicleBrand VehicleBrand { get; set; }

        [Required]
        public long VehicleModelId { get; set; }
        [ForeignKey("VehicleModelId")]
        public VehicleModel VehicleModel { get; set; }

        [Required]
        public short VechileTypeId { get; set; }
        [ForeignKey("VechileTypeId")]
        public VehicleType VehicleType { get; set; }

    




       

        

      

     
    }
}

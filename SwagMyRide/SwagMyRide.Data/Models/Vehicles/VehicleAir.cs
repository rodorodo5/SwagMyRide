using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using SwagMyRide.Data.Models.UserData;
using SwagMyRide.Data.Models.VehicleComponents;
using SwagMyRide.Data.Models.VehicleData;

namespace SwagMyRide.Data.Models.Vehicles
{
    public class VehicleAir
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long VehicleAirId { get; set; }

        [Required]
        public long UserProfileId { get; set; }
        [ForeignKey("UserProfileId")]
        public UserProfile UserProfile { get; set; }

        [Required]
        public DateTime LastModifyTime { get; set; }

        [Required]
        public long VehicleYear { get; set; }

        [Required]
        public short TurbinesCount { get; set; }

        [Required]
        public long BodyWorkId { get; set; }
        [ForeignKey("BodyWorkId")]
        public BodyWorkCatalogue BodyWorkCatalogue { get; set; }

        [Required]
        public long CombustibleId { get; set; }
        [ForeignKey("CombustibleId")]
        public long CombustibleType { get; set; }

        [Required]
        public long ElecticSystemId { get; set; }
        [ForeignKey("ElecticSystemId")]
        public ElectricSystemCatalogue ElectricSystemCatalogue { get; set; }

        [Required]
        public long TurbinesId { get; set; }
        [ForeignKey("TurbinesId")]
        public TurbinesCatalogue TurbinesCatalogue { get; set; }


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

        [Required]
        [MaxLength(8)]
        public string Color { get; set; }

      

      
    }
}

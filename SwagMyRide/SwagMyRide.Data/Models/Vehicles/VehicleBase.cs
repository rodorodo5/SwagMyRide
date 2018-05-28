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
    public abstract class VehicleBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long VehicleBaseId { get; set; }

        [Required]
        public DateTime LastModifyTime { get; set; }

        [Required]
        public long VehicleYear { get; set; }

        [Required]
        [MaxLength(8)]
        public string Color { get; set; }


        [Required]
        public long UserProfileId { get; set; }
        

        [Required]
        public long BodyWorkId { get; set; }
        

        [Required]
        public long CombustibleId { get; set; }
        

        [Required]
        public long ElecticSystemId { get; set; }
      
      
        [Required]
        public long VehicleBrandId { get; set; }
       

        [Required]
        public long VehicleModelId { get; set; }
       

        [Required]
        public short VechileTypeId { get; set; }
       

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SwagMyRide.Data.Models.VehicleData
{
    public class VehicleBrand
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long VehicleBrandId { get; set; }
        [MaxLength(100)]
        public string BrandName { get; set; }

        [Required]
        public short VehicleTypeId { get; set; }
        [ForeignKey("VehicleTypeId")]
        public virtual VehicleType VehicleType { get; set; }
    }
}

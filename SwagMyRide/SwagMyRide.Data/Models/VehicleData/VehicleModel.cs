using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SwagMyRide.Data.Models.VehicleData
{
    public class VehicleModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long VehicleModelId { get; set; }
        [Required]
        [MaxLength(100)]
        public string VehicleNameModel { get; set; }
        [Required]
        [MaxLength(4)]
        public short VehicleYearModel { get; set; }

    }
}

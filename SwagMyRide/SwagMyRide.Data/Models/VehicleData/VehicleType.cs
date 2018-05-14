using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SwagMyRide.Data.Models.VehicleData
{
    public class VehicleType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short VehicleTypeId { get; set; }

        [Required]
        [MaxLength(90)]
        public string VehicleTypeName { get; set; }

    }
}

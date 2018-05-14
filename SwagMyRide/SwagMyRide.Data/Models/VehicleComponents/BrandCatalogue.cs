using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SwagMyRide.Data.Models.VehicleData;
using SwagMyRide.Data.Services;

namespace SwagMyRide.Data.Models.VehicleComponents
{
    public class BrandCatalogue:Service
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long BrandId { get; set; }
        [Required]
        [MaxLength(90)]
        public string Name { get; set; }
        [Required]
        [MaxLength(90)]
        public string Logo { get; set; }
        [Required]
        [MaxLength(255)]
        public string Description { get; set; }
        [Required]
        public bool Active { get; set; }

        [Required]
        public short VechileTypeId { get; set; }
        [ForeignKey("VechileTypeId")]
        public VehicleType VehicleType { get; set; }

    }
}

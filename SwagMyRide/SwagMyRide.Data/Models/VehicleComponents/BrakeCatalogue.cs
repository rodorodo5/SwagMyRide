using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SwagMyRide.Data.Models.GlobalData;
using SwagMyRide.Data.Models.VehicleData;
using SwagMyRide.Data.Services;

namespace SwagMyRide.Data.Models.VehicleComponents
{
    public class BrakeCatalogue: Service
    { 
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long BrakeId { get; set; }
        [Required]
        [MaxLength(90)]
        public string Name { get; set; }
        [Required]
        [MaxLength(255)]
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int Stock { get; set; }
        [Required]
        public bool Active { get; set; }
        [Required]
        [MaxLength(255)]
        public string Image { get; set; }
        [Required]
        public double Weight { get; set; }
        [Required]
        public double Pressure { get; set; }

        [Required]
        public long Brand { get; set; }
        [ForeignKey("Brand")]
        public BrandCatalogue BrandId { get; set; }

        [Required]
        public long Manufactured { get; set; }
        [ForeignKey("Manufactured")]
        public Country CountryId { get; set; }

        [Required]
        public short VechileTypeId { get; set; }
        [ForeignKey("VechileTypeId")]
        public VehicleType VehicleType { get; set; }

        [Required]
        public long VehicleModelId { get; set; }
        [ForeignKey("VehicleModelId")]
        public VehicleModel VehicleModel { get; set; }

    }
}

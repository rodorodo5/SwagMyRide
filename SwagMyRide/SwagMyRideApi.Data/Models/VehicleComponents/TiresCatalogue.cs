using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SwagMyRideApi.Data.Models.VehicleComponents
{
    public class TiresCatalogue
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long TiresId { get; set; }
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
        public short Size { get; set; }

        [Required]
        public long Brand { get; set; }
        [ForeignKey("Brand")]
        public BrandCatalogue BrandId { get; set; }

        [Required]
        public long Manufactured { get; set; }
        [ForeignKey("Manufactured")]
        public Country CountryId { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwagMyRideApi.Api.Models.VehicleComponents
{
    public class BrandCatalogue
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

    }
}

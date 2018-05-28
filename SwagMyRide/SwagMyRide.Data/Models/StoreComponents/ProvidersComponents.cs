using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SwagMyRide.Data.Models.VehicleComponents;

namespace SwagMyRide.Data.Models.StoreComponents
{
    public class ProvidersComponents
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ProvidersId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public double ServiceCost { get; set; }

        [Required]
        public short GuaranteedDays { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        public long Brand { get; set; }
        [ForeignKey("Brand")]
        public BrandCatalogue BrandId { get; set; }

        [Required]
        public long MethodProviderId { get; set; }
        [ForeignKey("MethodProviderId")]
        public MethodProvider MethodProvider { get; set; }


    }
}

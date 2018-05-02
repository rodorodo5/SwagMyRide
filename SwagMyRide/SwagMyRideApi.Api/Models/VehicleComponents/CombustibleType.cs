using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwagMyRideApi.Api.Models.VehicleComponents
{
    public class CombustibleType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long CombustibleId { get; set; }
        [Required]
        [MaxLength(90)]
        public string Name { get; set; }
    }
}

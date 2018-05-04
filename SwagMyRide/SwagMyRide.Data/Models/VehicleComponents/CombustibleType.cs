using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SwagMyRide.Data.Services;

namespace SwagMyRide.Data.Models.VehicleComponents
{
    public class CombustibleType: Service
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long CombustibleId { get; set; }
        [Required]
        [MaxLength(90)]
        public string Name { get; set; }
    }
}

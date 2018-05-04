using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SwagMyRide.Data.Services;

namespace SwagMyRide.Data.Models.GlobalData
{
    public class State: Service
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long StateId { get; set; }
        [Required]
        [MaxLength(90)]
        public string Name { get; set; }

        [Required]
        public bool Active { get; set; }

        public long Country { get; set; }
        [ForeignKey("Country")]
        public Country CountryId { get; set; }
    }
}

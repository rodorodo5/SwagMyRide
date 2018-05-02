using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SwagMyRideApi.Api.Models
{
    public class State
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

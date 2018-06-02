using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SwagMyRide.Data.Models.UserData
{
    public class BillingAddress
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long BillingAddressId { get; set; }

        [Required]
        public  string AddressLine1 { get; set; }

        public  string AddressLine2 { get; set; }

        [Required]
        public int CityId { get; set; }

        [Required]
        public int StateId { get; set; }

        [Required]
        public int CountryId { get; set; }

        [Required]
        public int ZipCode { get; set; }

        [Required]
        public long UserProfileId { get; set; }
        [ForeignKey("UserProfileId")]
        public virtual UserProfile UserProfile { get; set; }

    }
}

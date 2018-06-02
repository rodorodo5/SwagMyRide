using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using SwagMyRide.Data.Models.UserData;

namespace SwagMyRide.Data.Models.Payment
{
    public class CreditCard
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long CreditCardId { get; set; }

        [Required]
        public string CreditCardNumber { get; set; }

        [Required]
        public string ExpirationDate { get; set; }

        [Required]
        public string Cvv { get; set; }

        [Required]
        public string LastNumbers { get; set; }

        [Required]
        public long UserProfileId { get; set; }
        [ForeignKey("UserProfileId")]
        public virtual UserProfile UserProfile { get; set; }


    }
}

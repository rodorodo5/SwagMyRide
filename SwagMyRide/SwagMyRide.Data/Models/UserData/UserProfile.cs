using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SwagMyRide.Data.Models.GlobalData;
using SwagMyRide.Data.Services;

namespace SwagMyRide.Data.Models.UserData
{
    public class UserProfile:Service
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long UserProfileId { get; set; }
        [Required]
        [MaxLength(100)]
        public string UserName { get; set; }
        [Required]
        [MaxLength(100)]
        public string UserLastName { get; set; }
        [Required]
        public DateTime RegisterDate { get; set; }
        [Required]
        public DateTime Brithday { get; set; }
        [Required]  
        public short Age { get; set; }
        [Required]
        [MaxLength(1)]
        public string Gender { get; set; }
        [Required]
        [MaxLength(30)]
        public string Phone { get; set; }
        [Required]
        [MaxLength(Int32.MaxValue)]
        public string Email { get; set; }
        [Required]
        public long Country { get; set; }

        [Required]
        public string Password { get; set; }

        [ForeignKey("Country")]
        public Country CountryId { get; set; }
        
    }
}

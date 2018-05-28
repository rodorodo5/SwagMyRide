using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using SwagMyRide.Data.Models.GlobalData;

namespace SwagMyRide.Data.Models.UserData
{
    public class OrderList
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long OrderListId { get; set; }

        [Required]
        public DateTime LastOrderDate { get; set; }

        [Required]
        public long UserProfileId { get; set; }
        [ForeignKey("UserProfileId")]
        public virtual UserProfile UserProfile { get; set; }

        [Required]
        public long ComponentType { get; set; }

        [Required]
        public long ComponentId { get; set; }
    }
}

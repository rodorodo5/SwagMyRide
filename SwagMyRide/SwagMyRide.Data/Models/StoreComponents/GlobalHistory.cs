using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using SwagMyRide.Data.Models.UserData;
using SwagMyRide.Data.Models.VehicleData;

namespace SwagMyRide.Data.Models.StoreComponents
{
    public class GlobalHistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long GlobalHisoryId { get; set; }

        [Required]
        public long OrderListId { get; set; }
        [ForeignKey("OrderListId")]
        public OrderList OrderList { get; set; }

        [Required]
        public long UserProfileId { get; set; }
        [ForeignKey("UserProfileId")]
        public UserProfile UserProfile { get; set; }

        [Required]
        public DateTime LastBuyDateTime { get; set; }
    }
}

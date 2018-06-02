using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using SwagMyRide.Data.Models.GlobalData;
using SwagMyRide.Data.Models.Vehicles;

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
        public long ComponentType { get; set; }

        [Required]
        public long ComponentId { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public bool IsBought { get; set; }

        [Required]
        public long UserProfileId { get; set; }
        [ForeignKey("UserProfileId")]
        public virtual UserProfile UserProfile { get; set; }


    
        public long UserVehicleBaseId { get; set; }
        [ForeignKey("UserVehicleBaseId")]
        public virtual VehicleBase VehicleBase { get; set; }
    }
}

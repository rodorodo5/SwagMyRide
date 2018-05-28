using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SwagMyRide.Data.Models.StoreComponents
{
    public class MethodProvider
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long MethodProviderId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public double ServiceCost { get; set; }

        [Required]
        public int DeliveryDay { get; set; }

        [Required]
        public string Image { get; set; }
    }
}

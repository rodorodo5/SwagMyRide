﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SwagMyRide.Data.Models.GlobalData
{
    public class ComponentType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ComponentTypeId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}

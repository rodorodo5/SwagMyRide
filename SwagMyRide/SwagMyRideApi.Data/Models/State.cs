﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SwagMyRideApi.Data.Models
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

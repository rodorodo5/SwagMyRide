﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SwagMyRide.Data.Models.UserData;
using SwagMyRide.Data.Models.VehicleComponents;
using SwagMyRide.Data.Models.VehicleData;
using SwagMyRide.Data.Services;

namespace SwagMyRide.Data.Models.Vehicles
{
    public  class VehicleLand: VehicleBase
    {

        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public long VehicleLandId { get; set; }

        //[Required]
        //public new long VehicleBaseId { get; set; }
        //[ForeignKey("VehicleBaseId")]
        //public VehicleBase VehicleBase { get; set; }
      
        public long TiresId { get; set; }
       

        public long SuspensionId { get; set; }
       

        public long WheelId { get; set; }
       

        public long BrakeId { get; set; }
       
        public long MotorId { get; set; }
       
     
    }
}

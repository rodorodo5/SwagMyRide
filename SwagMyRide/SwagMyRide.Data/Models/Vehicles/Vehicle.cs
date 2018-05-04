using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using SwagMyRide.Data.Models.VehicleComponents;

namespace SwagMyRide.Data.Models.Vehicles
{
    public class Vehicle
    {
        [Key]
        public long VehicleId { get; set; }
        [Required]
        public long UserProfileId { get; set; }
        public DateTime LastModifyTime { get; set; }
        public long VehicleBrandId { get; set; }
        public long VehicleModelId { get; set; }
        public long VehicleYear { get; set; }
        public BodyWorkCatalogue BodyWorkCatalogue { get; set; }
        public BreakCatalogue BreakCatalogue { get; set; }
        public CombustibleType CombustibleType { get; set; }
        public ElectricSystemCatalogue ElectricSystemCatalogue { get; set; }
        public MotorCatalogue MotorCatalogue { get; set; }
        public SuspensionCatalogue SuspensionCatalogue { get; set; }
        public TiresCatalogue TiresCatalogue { get; set; }
        public WheelCatalogue WheelCatalogue { get; set; }
    }
}

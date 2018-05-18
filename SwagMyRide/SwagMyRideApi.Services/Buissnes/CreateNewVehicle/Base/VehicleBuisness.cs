using System;

namespace SwagMyRideApi.Services.Buissnes.CreateNewVehicle.Base
{
    public abstract class VehicleBuisness
    {
       

        public  long VehicleId { get; set; }
        public  long UserProfileId { get; set; }
        public DateTime LastModifyTime { get; set; }
        public long VehicleYear { get; set; }
        public long BodyWorkId { get; set; }
        public long CombustibleId { get; set; }
        public long ElecticSystemId { get; set; }
        public long MotorId { get; set; }
        public long VehicleBrandId { get; set; }
        public long VehicleModelId { get; set; }
        public short VechileTypeId { get; set; }
        public string Color { get; set; }

    

        //public abstract void VehicleType();
        //public abstract void ProvideColor();
        //public abstract void ProvideMotor();
        //public abstract void ProvideBodyWork();
        //public abstract void ProvideElectrySystem();
        //public abstract void ProvideLastModifyTime();
        //public abstract void ProvideCombustibleId();
    }
}

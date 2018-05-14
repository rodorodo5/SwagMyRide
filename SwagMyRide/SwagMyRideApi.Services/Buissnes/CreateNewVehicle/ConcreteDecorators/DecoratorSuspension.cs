using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SwagMyRideApi.Services.Buissnes.CreateNewVehicle.Abstract;

namespace SwagMyRideApi.Services.Buissnes.CreateNewVehicle.ConcreteDecorators
{
    public class DecoratorSuspension:Components
    {
        private readonly SwagMyRide.Data.Models.Vehicles.Vehicle _vehicle;
        private readonly string _description;
        public DecoratorSuspension(SwagMyRide.Data.Models.Vehicles.Vehicle vehicle)
        {
            this._vehicle = vehicle;
            this._description = vehicle.SuspensionCatalogue.Description;

        }

        public override string GetDescription()
        {
            return _vehicle.GetDescription() + _description;
        }


        public override string GetPiece()
        {
            return _vehicle.BodyWorkCatalogue.Name;
        }
    }
}

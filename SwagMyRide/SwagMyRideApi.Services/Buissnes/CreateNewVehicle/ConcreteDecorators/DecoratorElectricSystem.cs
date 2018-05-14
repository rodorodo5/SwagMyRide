using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SwagMyRideApi.Services.Buissnes.CreateNewVehicle.Abstract;

namespace SwagMyRideApi.Services.Buissnes.CreateNewVehicle.ConcreteDecorators
{
    public class DecoratorElectricSystem:Components
    {
        private readonly SwagMyRide.Data.Models.Vehicles.Vehicle _vehicle;
        private readonly string _description;
        public DecoratorElectricSystem(SwagMyRide.Data.Models.Vehicles.Vehicle vehicle)
        {
            this._vehicle = vehicle;
            this._description = vehicle.ElectricSystemCatalogue.Description;

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

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SwagMyRide.Data.Models.VehicleComponents;
using SwagMyRideApi.Services.Buissnes.CreateNewVehicle.Abstract;

namespace SwagMyRideApi.Services.Buissnes.CreateNewVehicle.ConcreteDecorators
{
    public class DecoratorBodyWork:Components
    {
        private readonly SwagMyRide.Data.Models.Vehicles.Vehicle _vehicle;
        private readonly string _description;
        public DecoratorBodyWork(SwagMyRide.Data.Models.Vehicles.Vehicle vehicle)
        {
            this._vehicle = vehicle;
            this._description = vehicle.BodyWorkCatalogue.Description;

        }

        public override string GetDescription()
        {
            return _vehicle.GetDescription()+_description;
        }


        public override string GetPiece()
        {
            return _vehicle.BodyWorkCatalogue.Name;
        }
    }
}
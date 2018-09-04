using FurnitureManufacturer.Commands.Contracts;
using FurnitureManufacturer.Data1;
using FurnitureManufacturer.Engine;
using FurnitureManufacturer.Interfaces;
using FurnitureManufacturer.Interfaces.Engine;
using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureManufacturer.Commands
{
    public class CreateChairCommand : ICreatCommand
    {
        private IData data;
        private IFurnitureFactory factory;

        public CreateChairCommand(IData data, IFurnitureFactory factory)
        {
            this.data = data;
            this.factory = factory;
        }

        public string Execute(IList<string> parameters)
        {
            var chairModel = parameters[0];
            var chairMaterial = parameters[1];
            var chairPrice = decimal.Parse(parameters[2]);
            var chairHeight = decimal.Parse(parameters[3]);
            var chairLegs = int.Parse(parameters[4]);
            return this.CreateChair(chairModel, chairMaterial, chairPrice, chairHeight, chairLegs);
        }

        private string CreateChair(string model, string material, decimal price, decimal height, int legs)
        {
            if (this.data.Furnitures.ContainsKey(model))
            {
                return string.Format(EngineConstants.FurnitureExistsErrorMessage, model);
            }

            IFurniture chair = this.factory.CreateChair(model, material, price, height, legs);
            this.data.Furnitures.Add(model, chair);

            return string.Format(EngineConstants.ChairCreatedSuccessMessage, model);
        }
    }
}

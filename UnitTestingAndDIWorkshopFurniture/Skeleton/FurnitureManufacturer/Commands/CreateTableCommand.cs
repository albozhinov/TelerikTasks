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
    public class CreateTableCommand : ICreatCommand
    {
        private IData data;
        private IFurnitureFactory factory;

        public CreateTableCommand(IData data, IFurnitureFactory factory)
        {
            this.data = data;
            this.factory = factory;
        }

        public string Execute(IList<string> parameters)
        {
            var tableModel = parameters[0];
            var tableMaterial = parameters[1];
            var tablePrice = decimal.Parse(parameters[2]);
            var tableHeight = decimal.Parse(parameters[3]);
            var tableLength = decimal.Parse(parameters[4]);
            var tableWidth = decimal.Parse(parameters[5]);
            return CreateTable(tableModel, tableMaterial, tablePrice, tableHeight, tableLength, tableWidth);
        }

        private string CreateTable(string model, string material, decimal price, decimal height, decimal length, decimal width)
        {
            if (this.data.Furnitures.ContainsKey(model))
            {
                return string.Format(EngineConstants.FurnitureExistsErrorMessage, model);
            }

            var table = this.factory.CreateTable(model, material, price, height, length, width);
            this.data.Furnitures.Add(model, table);

            return string.Format(EngineConstants.TableCreatedSuccessMessage, model);
        }
    }
}

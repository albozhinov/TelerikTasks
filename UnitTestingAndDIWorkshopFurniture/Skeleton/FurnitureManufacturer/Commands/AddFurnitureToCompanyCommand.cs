using FurnitureManufacturer.Commands.Contracts;
using FurnitureManufacturer.Data1;
using FurnitureManufacturer.Engine;
using FurnitureManufacturer.Interfaces.Engine;
using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureManufacturer.Commands
{
    public class AddFurnitureToCompanyCommand : ICreatCommand
    {
        private IData data;        

        public AddFurnitureToCompanyCommand(IData data)
        {
            this.data = data;            
        }

        public string Execute(IList<string> parameters)
        {
            var companyToAddTo = parameters[0];
            var furnitureToBeAdded = parameters[1];
            return this.AddFurnitureToCompany(companyToAddTo, furnitureToBeAdded);
        }

        private string AddFurnitureToCompany(string companyName, string furnitureName)
        {
            if (!this.data.Companies.ContainsKey(companyName))
            {
                return string.Format(EngineConstants.CompanyNotFoundErrorMessage, companyName);
            }

            if (!this.data.Furnitures.ContainsKey(furnitureName))
            {
                return string.Format(EngineConstants.FurnitureNotFoundErrorMessage, furnitureName);
            }

            var company = this.data.Companies[companyName];
            var furniture = this.data.Furnitures[furnitureName];
            company.Add(furniture);

            return string.Format(EngineConstants.FurnitureAddedSuccessMessage, furnitureName, companyName);
        }
    }
}

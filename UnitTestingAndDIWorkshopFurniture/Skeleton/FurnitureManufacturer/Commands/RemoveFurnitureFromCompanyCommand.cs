using FurnitureManufacturer.Commands.Contracts;
using FurnitureManufacturer.Data1;
using FurnitureManufacturer.Engine;
using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureManufacturer.Commands
{
    public class RemoveFurnitureFromCompanyCommand : ICreatCommand
    {
        private IData data;


        public RemoveFurnitureFromCompanyCommand(IData data)
        {
            this.data = data;
        }

        public string Execute(IList<string> parameters)
        {
            var companyToRemoveFrom = parameters[0];
            var furnitureToBeRemoved = parameters[1];
            return this.RemoveFurnitureFromCompany(companyToRemoveFrom, furnitureToBeRemoved);            
        }

        private string RemoveFurnitureFromCompany(string companyName, string furnitureName)
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
            company.Remove(furniture);

            return string.Format(EngineConstants.FurnitureRemovedSuccessMessage, furnitureName, companyName);
        }
    }
}

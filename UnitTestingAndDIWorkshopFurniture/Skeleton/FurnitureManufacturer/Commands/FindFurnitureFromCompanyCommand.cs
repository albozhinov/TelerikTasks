using FurnitureManufacturer.Commands.Contracts;
using FurnitureManufacturer.Data1;
using FurnitureManufacturer.Engine;
using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureManufacturer.Commands
{
    public class FindFurnitureFromCompanyCommand : ICreatCommand
    {
        private IData data;

        public FindFurnitureFromCompanyCommand(IData data)
        {
            this.data = data;
        }

        public string Execute(IList<string> parameters)
        {
            var companyToFindFrom = parameters[0];
            var furnitureToBeFound = parameters[1];
            return this.FindFurnitureFromCompany(companyToFindFrom, furnitureToBeFound);
        }

        private string FindFurnitureFromCompany(string companyName, string furnitureName)
        {
            if (!this.data.Companies.ContainsKey(companyName))
            {
                return string.Format(EngineConstants.CompanyNotFoundErrorMessage, companyName);
            }

            var company = this.data.Companies[companyName];
            var furniture = company.Find(furnitureName);
            if (furniture == null)
            {
                return string.Format(EngineConstants.FurnitureNotFoundErrorMessage, furnitureName);
            }

            return furniture.ToString();
        }
    }
}

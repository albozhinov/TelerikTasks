using FurnitureManufacturer.Commands.Contracts;
using FurnitureManufacturer.Data1;
using FurnitureManufacturer.Engine;
using FurnitureManufacturer.Interfaces.Engine;
using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureManufacturer.Commands
{
    public class CreateCompanyCommand : ICreatCommand
    {
        private IData data;
        private iCommandFactory factory;

        public CreateCompanyCommand(IData data, iCommandFactory factory)
        {
            this.data = data;
            this.factory = factory;
        }

        public string Execute(IList<string> parameters)
        {
            var companyName = parameters[0];
            var companyRegistrationNumber = parameters[1];
            return this.CreateCompany(companyName, companyRegistrationNumber);
        }

        private string CreateCompany(string name, string registrationNumber)
        {
            if (this.data.Companies.ContainsKey(name))
            {
                return string.Format(EngineConstants.CompanyExistsErrorMessage, name);
            }

            var company = this.factory.CreateCompany(name, registrationNumber);
            this.data.Companies.Add(name, company);

            return string.Format(EngineConstants.CompanyCreatedSuccessMessage, name);
        }
    }
}

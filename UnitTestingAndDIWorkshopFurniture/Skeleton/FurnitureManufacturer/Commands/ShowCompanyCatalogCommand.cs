using FurnitureManufacturer.Commands.Contracts;
using FurnitureManufacturer.Data1;
using FurnitureManufacturer.Engine;
using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureManufacturer.Commands
{
    public class ShowCompanyCatalogCommand : ICreatCommand
    {
        private IData data;

        public ShowCompanyCatalogCommand(IData data)
        {
            this.data = data;
        }

        public string Execute(IList<string> parameters)
        {
            var companyToShowCatalog = parameters[0];
            return this.ShowCompanyCatalog(companyToShowCatalog);
        }

        private string ShowCompanyCatalog(string companyName)
        {
            if (!this.data.Companies.ContainsKey(companyName))
            {
                return string.Format(EngineConstants.CompanyNotFoundErrorMessage, companyName);
            }

            return this.data.Companies[companyName].Catalog();
        }
    }
}

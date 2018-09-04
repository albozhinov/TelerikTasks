using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureManufacturer.Data1
{
    public class Data : IData
    {
        public Data()
        {
            this.Companies = new Dictionary<string, ICompany>();

            this.Furnitures = new Dictionary<string, IFurniture>();
        }


        public Dictionary<string, ICompany> Companies { get; }

        public Dictionary<string, IFurniture> Furnitures { get; }

        //// Homework
        //public void AddCompany(ICompany company)
        //{
        //    this.Companies.Add(company.Name, company);
        //}

        //public bool CompanyExists(string name)
        //{
        //    return this.Companies.ContainsKey(name);
        //}

        //public ICompany GetCompany(string name)
        //{
        //    throw new NotImplementedException();
        //}

        //public void RemoveCompany(ICompany company)
        //{
        //    throw new NotImplementedException();
        //}
    }
}

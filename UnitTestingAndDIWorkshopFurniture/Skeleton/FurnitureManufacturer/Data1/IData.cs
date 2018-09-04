using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureManufacturer.Data1
{
    public interface IData
    {
         Dictionary<string, ICompany> Companies { get; }

         Dictionary<string, IFurniture> Furnitures { get; }

        //void AddCompany(ICompany company);

        //void RemoveCompany(ICompany company);

        //ICompany GetCompany(string name);

        //bool CompanyExists(string name);
    }
}
